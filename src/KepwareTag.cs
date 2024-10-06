using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TagBuilder
{
    public enum TagDataType
    {
        Double,
        Float,
        QWord,
        Short,
        String,
        Long,
        LLong,
        Word
    }
    public class KepwareTag
    {
        //
        private string m_GroupName_1 = "DefaultGroupName";
        private string m_TagName_1 = "DefaultTagName";
        private string m_Address_2 = "";
        private TagDataType m_DataType_3 = TagDataType.Word;
        private string m_RespectDataType_4 = "1";
        private string m_ClientAccess_5 = "RO";
        private string m_ScanRate_6 = "100";
        private string m_Scaling_7 = "";
        private string m_RawLow_8 = "";
        private string m_RawHigh_9 = "";
        private string m_ScaledLow_10 = "";
        private string m_ScaledHigh_11 = "";
        private string m_ScaledDataType_12 = "";
        private string m_ClampLow_13 = "";
        private string m_ClampHigh_14 = "";
        private string m_EngUnits_15 = "";
        private string m_Description_16 = "Default Description";
        private string m_NegateValue_17 = "";

        //

        #region Public Property
        public string GroupName_1
        {
            get
            {
                return m_GroupName_1; 
            }
            set
            {
                m_GroupName_1 = value;
            }
        }

        public string TagName_1
        {
            get
            {
                return m_TagName_1;
            }
            set
            {
                m_TagName_1 = value;
            }
        }

        public string Address_2
        {
            get
            {
                if (DataType_3 == TagDataType.Float)
                {
                    return BuildFloatAddress();
                }
                else
                {
                    return BuildIntegerAddress();
                }
            }
            set => m_Address_2 = value;
        }
        public TagDataType DataType_3 { get => m_DataType_3; set => m_DataType_3 = value; }
        public string RespectDataType_4 { get => m_RespectDataType_4; set => m_RespectDataType_4 = value; }
        public string ClientAccess_5 { get => m_ClientAccess_5; set => m_ClientAccess_5 = value; }
        public string ScanRate_6 { get => m_ScanRate_6; set => m_ScanRate_6 = value; }
        public string Scaling_7 { get => m_Scaling_7; set => m_Scaling_7 = value; }
        public string RawLow_8 { get => m_RawLow_8; set => m_RawLow_8 = value; }
        public string RawHigh_9 { get => m_RawHigh_9; set => m_RawHigh_9 = value; }
        public string ScaledLow_10 { get => m_ScaledLow_10; set => m_ScaledLow_10 = value; }
        public string ScaledHigh_11 { get => m_ScaledHigh_11; set => m_ScaledHigh_11 = value; }
        public string ScaledDataType_12 { get => m_ScaledDataType_12; set => m_ScaledDataType_12 = value; }
        public string ClampLow_13 { get => m_ClampLow_13; set => m_ClampLow_13 = value; }
        public string ClampHigh_14 { get => m_ClampHigh_14; set => m_ClampHigh_14 = value; }
        public string EngUnits_15 { get => m_EngUnits_15; set => m_EngUnits_15 = value; }
        public string Description_16 { get => m_Description_16; set => m_Description_16 = value; }
        public string NegateValue_17 { get => m_NegateValue_17; set => m_NegateValue_17 = value; }

        #endregion


        private string BuildFloatAddress()
        {
            //
            float by = 0.17f;
            int every = 1000;

            //
            float from = NextRandom.NextRandomFloat(0.0f, 2.0f);
            float to = NextRandom.NextRandomFloat(0.0f, 2.0f);

            if (from > to)
            {
                float tmp = from;
                from = to;
                to = tmp * 7;
            }

            //
            string address = @"""RAMP (" + every + ", " + from + ", " + to + ", " + by + @")""";
            return address;
        }

        private string BuildIntegerAddress()
        {
            //
            int every = 1000;

            //
            int from = NextRandom.NextRandomInteger(1, 1000);
            int to = NextRandom.NextRandomInteger(1, 1000);

            if (from == to)
            {
                to = to + 10;
            }

            if (from > to)
            {
                int tmp = from;
                from = to;
                to = tmp;
            }

            //
            string address = @"""RANDOM (" + every + ", " + from + ", " + to + @")""";
            return address;
        }

        public KepwareTag() 
        {
        }

        public string Dump()
        {
            string tag = this.GroupName_1 + "." + this.TagName_1
                + "," + this.Address_2
                + "," + DataType_3
                + "," + this.RespectDataType_4
                + "," + this.ClientAccess_5
                + "," + this.ScanRate_6
                + "," + this.Scaling_7
                + "," + this.RawLow_8
                + "," + this.RawHigh_9
                + "," + this.ScaledLow_10
                + "," + this.ScaledHigh_11
                + "," + this.ScaledDataType_12
                + "," + this.ClampLow_13
                + "," + this.ClampHigh_14
                + "," + this.EngUnits_15
                + "," + this.Description_16
                + "," + this.NegateValue_17;

            return tag;
        }
    }
}
