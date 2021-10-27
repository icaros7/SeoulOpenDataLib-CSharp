/*
 * Result.cs
 *
 * Result 형 반환용 클래스
 * 각 인스턴스는 SeoulOpenData.getData 으로부터 할당 될 데이터를 포함하고 있습니다.
 * 
 * hominlab@gmail.com / iCAROS7
*/

namespace Good_for_Cafe_Backend {
    public class Result {
        public int date { get; set; } // 검색 날짜
        public int timeS { get; set; } // 시작 시간
        public int timeE { get; set; } // 종료 시간
        public string location { get; set; } // 행자부 행정동 코드
        public string result { get; set; } // 결과 JSON 데이터
    }
}

