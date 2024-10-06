using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagBuilder
{
    public partial class KepwareTagBuilder : Form
    {
        public const string TAG_CSVFILE = "KepwareTestTags.csv";
        public void TagCreateCSV()
        {
            //
            string filename = TAG_CSVFILE;

            //
            StreamWriter sw = File.CreateText(filename);

            //
            sw.Write(@"Tag Name,Address,Data Type,Respect Data Type,Client Access,Scan Rate,Scaling,Raw Low,Raw High,Scaled Low,Scaled High,Scaled Data Type,Clamp Low,Clamp High,Eng Units,Description,Negate Value" + "\n");

            //
            sw.Close();
        }

        /// <summary>
        /// 增加Float类型的点位
        /// </summary>
        public void TagAppendFloatTags()
        {
            //
            string filename = TAG_CSVFILE;

            //
            StreamWriter sw = File.AppendText(filename);

            //
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    KepwareTag tag = new KepwareTag();
                    tag.GroupName_1 = "group" + i;
                    tag.TagName_1 = "f" + j;
                    tag.DataType_3 = TagDataType.Float;
                    sw.Write(tag.Dump() + "\n");
                }
            }

            //
            sw.Close();
        }

        public void TagAppendIntegerTags()
        {
            //
            string filename = TAG_CSVFILE;

            //
            StreamWriter sw = File.AppendText(filename);

            //
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    KepwareTag tag = new KepwareTag();
                    tag.GroupName_1 = "group" + i;
                    tag.TagName_1 = "w" + j;
                    tag.DataType_3 = TagDataType.Word;
                    sw.Write(tag.Dump() + "\n");
                }
            }

            //
            sw.Close();
        }
        public KepwareTagBuilder()
        {
            InitializeComponent();
        }

        private void btnCreateCSV_Click(object sender, EventArgs e)
        {
            TagCreateCSV();
        }

        private void btnAddFloatTags_Click(object sender, EventArgs e)
        {
            TagAppendFloatTags();
        }

        private void btnAddIntegerTags_Click(object sender, EventArgs e)
        {
            TagAppendIntegerTags();
        }
    }
}
