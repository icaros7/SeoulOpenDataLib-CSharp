/*
 * SeoulOpenData.cs
 * 
 * 서울시 열린 데이터 광장과 직접 닿는 클래스
 * 
 * hominlab@gmail.com / iCAROS7
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Good_for_Cafe_DataEnd {
    public class SeoulOpenData
    {
        private const string BaseUrl = @"http://openapi.seoul.go.kr:8088/";
        private string _apiKey; // 서울시 열린 광장 오픈API키 저장소
        private int _date { get; set; } // 검색 날짜
        private int _location { get; set; } // 검색 행자부 행정동 코드
        private int _time { get; set; } // 실제 검색 시간
        private int _timeS { get; set; } // 검색 시작 시간
        private int _timeE { get; set; } // 검색 종료 시간
        private bool _isSet { get; set; } // 검색 조건 설정 완료 유무
        private List<DataResult> list; // 검색 데이터 저장 리스트
        public List<DataResult> getList() { return list; } // list getter
        
        /// <summary>
        /// 생성자
        /// </summary>
        public SeoulOpenData() { _isSet = false; }
        
        /// <summary>
        /// 열린 데이터 광장으로 부터 데이터 반환 메서드
        /// </summary>
        /// <param name="searchId">검색 할 자료 ID</param>
        /// <returns>Result 형 인스턴스</returns>
        private Result getData(ref string searchId)
        {
            var re = new Result(); // 반환용 결과 저장 인스텐스 생성

            //TODO: re 객체 setter 호출 이후 반환
            re.result = null;
            
            return re;
        }

        /// <summary>
        /// 검색 할 조건을 설정 메서드
        /// </summary>
        /// <param name="date">검색 날짜</param>
        /// <param name="timeS">시작 시간</param>
        /// <param name="timeE">종료 시간</param>
        /// <param name="location">행자부 행정동 코드</param>
        /// <returns></returns>
        private void setInfo(int date, int timeS, int timeE, string location) {
            this.date = date;
            this.timeS = timeS;
            this.timeE = timeE;
            this.location = location;
        }
    }
}