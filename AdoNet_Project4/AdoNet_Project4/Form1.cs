using System;
using System.Drawing;
using System.Windows.Forms;
using Net.Code.ADONet;

namespace AdoNet_Project4
{
    public partial class AdoNet : MetroFramework.Forms.MetroForm
    {
        EntiteState entiteState = EntiteState.Unchanged;
        public AdoNet()
        {
            InitializeComponent();
        }

        private void ButtonPhoto_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    PhotoPic.Image = Image.FromFile(ofd.FileName);
                    Persons obj = personsBindingSource.Current as Persons;
                    if(obj != null)
                    {
                        obj.PhotoURL = ofd.FileName;
                    }
                }
            }
        void ClearInput()
        {
            FullName_textBox.Text = null;
            LastName_textBox.Text = null;
            Gender_textBox.Text = null;
            Birthday_textBox.Text = null;
            Email_textBox.Text = null;
            Adress_textBox.Text = null;
            PhotoPic.Image = null;
        }

        private void AdoNet_Load(object sender, EventArgs e)
        {
            using (var db = Db.FromConfig("cn"))
            {
                personsBindingSource.DataSource = db.Sql("select * from Person1").AsEnumerable<Persons>();
            }
            PanelConteiner.Enabled = false;


            Persons obj = personsBindingSource.Current as Persons;
            if (obj != null)
            {
                if (!string.IsNullOrEmpty(obj.PhotoURL))
                    PhotoPic.Image = Image.FromFile(obj.PhotoURL);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            entiteState = EntiteState.Changed;
            PanelConteiner.Enabled = true;
            FullName_textBox.Focus();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,"Вы точно хотите удалить?","Сообщения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                entiteState = EntiteState.Deleted;
                try
                {
                    Persons obj = personsBindingSource.Current as Persons;
                    if(obj != null)
                    {
                        using (var db = Db.FromConfig("cn"))
                        {
                            db.Sql("delete from Person1 where ID = @ID").WithParameters(new {obj.ID }).AsNonQuery();
                            personsBindingSource.RemoveCurrent();
                            PanelConteiner.Enabled = false;
                            ClearInput();
                            entiteState = EntiteState.Unchanged;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            PanelConteiner.Enabled = false;
            personsBindingSource.ResetBindings(false);
            ClearInput();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                personsBindingSource.EndEdit();
                Persons obj = personsBindingSource.Current as Persons;
                if (obj != null)
                {
                    using (var db = Db.FromConfig("cn"))
                    {
                        if (entiteState == EntiteState.Add)
                        {
                            obj.ID = db.Sql("insert into Person1(FullName,LastName,Gender,Bithday,Email,Addres,PhotoURL) values(@FullName, @LastName, @Gender, @Birthday, @Email, @Adress, @PhotoURL); select SCOPE_IDENTITY()").WithParameters(new { FullName = obj.FullName,LastName = obj.LastName,Email= obj.Email, Addres = obj.Addres,Gender = obj.Gender,Bithday =  obj.Birthday, PhotoPic = obj.PhotoURL }).AsScalar<int>();
                        }
                        else if (entiteState == EntiteState.Changed)
                        {
                            db.StoredProcedure("Sp_Person1_Update").WithParameters(new {ID = obj.ID, FullName = obj.FullName,LastName = obj.LastName, Email = obj.Email, Addres = obj.Addres, Gender = obj.Gender, Bithday = obj.Birthday, PhotoPic = obj.PhotoURL }).AsNonQuery();
                        }
                        dataGrid.Refresh();
                        PanelConteiner.Enabled = false;
                        entiteState = EntiteState.Unchanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            entiteState = EntiteState.Add;
            PhotoPic.Image = null;
            PanelConteiner.Enabled = true;
            personsBindingSource.Add(new Persons());
            personsBindingSource.MoveLast();
            FullName_textBox.Focus();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Persons obj = personsBindingSource.Current as Persons;
            if(obj != null)
            {
                if (!string.IsNullOrEmpty(obj.PhotoURL))
                    PhotoPic.Image = Image.FromFile(obj.PhotoURL);
            }
        }
    }
}
