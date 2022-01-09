using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar.SuperGrid;
using ccO2urMNHFLXGD;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Collections;


namespace SchoolManagementSystem
{
    class common_code
    {
       
        public void CMB_in_SuperGridview_Load(SuperGridControl superGrid,int GridCol,string qry_)
        {
            //"Select measurements from measurements "
            List<string> orderArray = new List<string> { };
            c.da = new SqlDataAdapter(qry_, connection.con);
            c.dt = new DataTable();
            c.da.Fill(c.dt);

            GridPanel panel = superGrid.PrimaryGrid;

            foreach (DataRow row in c.dt.Rows)
            {
                orderArray.Add(row[0].ToString());

            }

            panel.Columns[GridCol].EditorType = typeof(FragrantComboBox);
            panel.Columns[GridCol].EditorParams = new object[] { orderArray };
        }

    }
    #region FragrantComboBox

    internal class FragrantComboBox : GridComboBoxExEditControl
    {
        public FragrantComboBox(IEnumerable orderArray)
        {
            DataSource = orderArray;
        }
    }

    #endregion
}
