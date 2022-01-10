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
        private IRestResponse getData() {
             Debug.WriteLine(@"@[D]: Start getData Task");
             var client = new RestClient(BaseUrl);
             var request =
                 new RestRequest(_apiKey + @"/json/SPOP_LOCAL_RESD_DONG/1/1/" + _date + @"/" + _time + @"/" + _location, DataFormat.Json);
             var restResponse = client.Get(request);
             
             return restResponse;
         }

        /// <summary>
        /// 직렬화된 데이터 복원 메서드
        /// </summary>
        /// <param name="response">IRestResponse 형 데이터</param>
        /// <returns>DataResult 객체화 된 RestResponse</returns>
        private DataResult DataDeserialize(ref IRestResponse response) {
            Debug.WriteLine(@"@[D]: Start Data Deserialization");

            DataResult re = new DataResult();
            JObject jObject = JObject.Parse(response.Content);
            re.SPOP_LOCAL_RESD_DONG = JsonConvert.DeserializeObject<SPOP_LOCAL_RESD_DONG>(jObject["SPOP_LOCAL_RESD_DONG"].ToString());
            re.RESULT = JsonConvert.DeserializeObject<RESULT>(jObject["SPOP_LOCAL_RESD_DONG"]["RESULT"].ToString());
            re.row = JsonConvert.DeserializeObject<List<row>>(jObject["SPOP_LOCAL_RESD_DONG"]["row"].ToString());
            
            return re;
        }

        public void Connect() {
            if (!_isSet) {
                Debug.WriteLine(@"@[E]: Failed to start Connect, isSet is false.");
                return; 
            }
            Debug.WriteLine(@"@[D]: Start Connect");

            try {
                list = new List<DataResult>();
                for (int i = 0; i < _timeE - _timeS + 1; i++) {
                    _time = _timeE - i;
                    IRestResponse temp = getData();
                    list.Add(DataDeserialize(ref temp));
                }
            }
            catch (Exception e) { Debug.WriteLine(e); }
        }

        /// <summary>
        /// 검색 할 조건을 설정 메서드
        /// </summary>
        /// <param name="date">검색 날짜</param>
        /// <param name="timeS">시작 시간</param>
        /// <param name="timeE">종료 시간</param>
        /// <param name="location">행자부 행정동 코드</param>
        /// <param name="apiKey">서울시 열린 데이터 광장 API키</param>
        /// <returns></returns>
        public void setInfo(int date, int timeS, int timeE, int location) {
            Debug.WriteLine(@"@[D]: Start setInfo");
            _date = date;
            _timeS = timeS;
            _timeE = timeE;
            _location = location;
            _apiKey = apiKey;
            _isSet = true;
            Debug.WriteLine(@"@[I]: " + date + ", " + timeS + ", " + timeE + ", " + location);
        }

        /// <summary>
        /// 설정 정보 초기화 메서드
        /// </summary>
        public void clearInfo() {
            Debug.WriteLine(@"@[D]: Start setClear");
            _isSet = false;
        }
    }
}