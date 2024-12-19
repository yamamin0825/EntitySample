using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySample
{
    public partial class Book2Form : Form
    {
        TestDBContext _dbContext;

        public Book2Form(TestDBContext dbContext)
        {
            InitializeComponent();

            _dbContext = dbContext;

            var categoryList = _dbContext.BookCategorys.AsNoTracking().OrderBy(a => a.CategoryID).ToList();
            foreach (var category in categoryList)
            {
                KeyValuePair kvp = new KeyValuePair(category.CategoryID, category.CategoryName);
                this.comboBoxCategory.Items.Add(kvp);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int key = ((KeyValuePair)this.comboBoxCategory.SelectedItem).Key;

            ModelBook2 modelBook = new ModelBook2();
            modelBook.BookName = textBoxName.Text;
            modelBook.CategoryID = key;
            
            _dbContext.Book2s.Add(modelBook);
            _dbContext.SaveChanges();

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
