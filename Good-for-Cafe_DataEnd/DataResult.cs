/*
 * Result.cs
 *
 * Result 형 반환용 클래스
 * 각 인스턴스는 SeoulOpenData.getData 으로부터 할당 될 데이터를 포함하고 있습니다.
 * 
 * hominlab@gmail.com / iCAROS7
*/

using System.Collections.Generic;

namespace Good_for_Cafe_DataEnd {
    public class SPOP_LOCAL_RESD_DONG {
        public int list_total_count { get; set; }
    }

    public class RESULT {
        public string CODE { get; set; }
        public string MESSAGE { get; set; }
    }
    
    public class row {
        public int STDR_DE_ID { get; set; }
        public int TMZON_PD_SE { get; set; }
        public int ADSTRD_CODE_SE { get; set; }
        public double TOT_LVPOP_CO { get; set; }
        public double MALE_F0T9_LVPOP_CO { get; set; }
        public double MALE_F10T14_LVPOP_CO { get; set; }
        public double MALE_F15T19_LVPOP_CO { get; set; }
        public double MALE_F20T24_LVPOP_CO { get; set; }
        public double MALE_F25T29_LVPOP_CO { get; set; }
        public double MALE_F30T34_LVPOP_CO { get; set; }
        public double MALE_F35T39_LVPOP_CO { get; set; }
        public double MALE_F40T44_LVPOP_CO { get; set; }
        public double MALE_F45T49_LVPOP_CO { get; set; }
        public double MALE_F50T54_LVPOP_CO { get; set; }
        public double MALE_F55T59_LVPOP_CO { get; set; }
        public double MALE_F60T64_LVPOP_CO { get; set; }
        public double MALE_F65T69_LVPOP_CO { get; set; }
        public double MALE_F70T74_LVPOP_CO { get; set; }
        public double FEMALE_F0T9_LVPOP_CO { get; set; }
        public double FEMALE_F10T14_LVPOP_CO { get; set; }
        public double FEMALE_F15T19_LVPOP_CO { get; set; }
        public double FEMALE_F20T24_LVPOP_CO { get; set; }
        public double FEMALE_F25T29_LVPOP_CO { get; set; }
        public double FEMALE_F30T34_LVPOP_CO { get; set; }
        public double FEMALE_F35T39_LVPOP_CO { get; set; }
        public double FEMALE_F40T44_LVPOP_CO { get; set; }
        public double FEMALE_F45T49_LVPOP_CO { get; set; }
        public double FEMALE_F50T54_LVPOP_CO { get; set; }
        public double FEMALE_F55T59_LVPOP_CO { get; set; }
        public double FEMALE_F60T64_LVPOP_CO { get; set; }
        public double FEMALE_F65T69_LVPOP_CO { get; set; }
        public double FEMALE_F70T74_LVPOP_CO { get; set; }
    }

    public class DataResult {
        public SPOP_LOCAL_RESD_DONG SPOP_LOCAL_RESD_DONG { get; set; }
        public RESULT RESULT { get; set; }
        public List<row> row { get; set; }
    }
}

