using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;
using System.Text;

namespace EntitySample
{
    public partial class Form1 : Form
    {
        TestDBContext _dbContext;

        public Form1()
        {
            InitializeComponent();
            _dbContext = new TestDBContext();
        }

        private void buttonNew1_Click(object sender, EventArgs e)
        {
            Book1Form form = new Book1Form(_dbContext);
            form.ShowDialog();

        }

        private void buttonNew2_Click(object sender, EventArgs e)
        {
            Book2Form form = new Book2Form(_dbContext);
            form.ShowDialog();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            var categoryList = _dbContext.BookCategorys.ToList();

            listView1.Items.Clear();

            var lists = _dbContext.Books.ToList();
            foreach (var data in lists)
            {
                string[] item1 = new string[2];
                item1[0] = data.BookName;
                if (data.Category != null)
                {
                    item1[1] = data.Category.CategoryName;
                }

                listView1.Items.Add(new ListViewItem(item1));
            }
        }

        private void buttonRead2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT a.Book2ID, a.BookName, a.CategoryID, b.CategoryName from Book2 a, BookCategory b where a.CategoryID = b.CategoryID";
            var datas = _dbContext.ViewBook2s.FromSqlRaw(sql).ToList();

            listView2.Items.Clear();

            var categoryList = _dbContext.BookCategorys.ToList();

            var lists = _dbContext.Book2s.AsNoTracking().ToList();
            foreach (var data in lists)
            {
                string[] item1 = new string[2];
                item1[0] = data.BookName;
                var category = _dbContext.BookCategorys.FirstOrDefault(a => a.CategoryID == data.CategoryID);
                if (category != null)
                {
                    item1[1] = category.CategoryName;
                }

                listView2.Items.Add(new ListViewItem(item1));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // (listView1.SelectedIndices.Count == 0)
            //{
                //buttonUpdate.Enabled = false;
            //}
            //else
            //{
                //buttonUpdate.Enabled = true;
            //}
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView2.SelectedIndices.Count == 0)
            //{
                //buttonUpdate.Enabled = false;
            //}
            //else
            //{
                //buttonUpdate.Enabled = true;
            //}
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var lists = _dbContext.Books.ToList();
            if (lists.Count == 0)
                return;

            string whereStr = "where BookID IN (";
            foreach (var table in lists)
            {
                whereStr = whereStr + table.BookID + ",";
            }

            whereStr = whereStr.Substring(0, whereStr.Length - 1);
            whereStr = whereStr + ")";

            var sql = @"UPDATE Book set BookName = 'VIP-' + BookName " + whereStr;
            System.FormattableString fstr1 = FormattableStringFactory.Create(sql);

            _dbContext.Database.ExecuteSql(fstr1);
        }

        private void buttonUpdate2_Click(object sender, EventArgs e)
        {
            var lists = _dbContext.Book2s.AsNoTracking().ToList();
            if (lists.Count == 0)
                return;

            string whereStr = "where Book2ID IN (";
            foreach (var table in lists)
            {
                whereStr = whereStr + table.Book2ID + ",";
            }

            whereStr = whereStr.Substring(0, whereStr.Length - 1);
            whereStr = whereStr + ")";

            var sql = @"UPDATE Book2 set BookName = 'VIP-' + BookName " + whereStr;
            System.FormattableString fstr1 = FormattableStringFactory.Create(sql);

            _dbContext.Database.ExecuteSql(fstr1);
        }
    }
}