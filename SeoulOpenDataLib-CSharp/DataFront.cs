/*
 * DataFront.cs
 *
 * 데이터-엔드 최상단
 * 
 * hominlab@gmail.com / iCAROS7
*/

using System;
using System.Collections.Generic;

namespace SeoulOpenDataLibCSharp {
    public class DataFront {
        private int _timeS, _timeE;
        private int _dateS { get; set; }
        private int _dateE { get; set; }
        private string _apiKey { get; set; }
        private SeoulOpenData _sod;
        private List<DataResult> _dataResults;

        // getter
        public ref List<DataResult> GetDataResults() { return ref _dataResults; }

        // setter
        public void SetDateStart(ref int dateS) { _dateS = dateS; }
        public void SetDateEnd(ref int dateE) { _dateE = dateE; }
        public void SetApiKey(ref string api) { _apiKey = api; }
        public void SetTime(ref int time) { _timeE = _dateS = time; }
        public void SetTime(ref int timeS, ref int timeE) {
            _timeS = timeS;
            _timeE = timeE;
        }

        // 생성자
        // Para: API키, 검색 시작 날짜, 검색 종료 날짜
        public DataFront() {
            SetDateToToday();
            _apiKey = null;
        }

        public DataFront(ref string apiKey) {
            SetDateToToday();
            _apiKey = apiKey;
        }

        public DataFront(int date) {
            _dateS = _dateE = date;
            _apiKey = null;
        }

        public DataFront(int date, ref string apiKey) {
            _dateE = _dateS = date;
            _apiKey = apiKey;
        }

        public DataFront(int dateS, int dateE) {
            _dateS = dateS;
            _dateE = dateE;
            _apiKey = null;
        }

        public DataFront(int dateS, int dateE, ref string apiKey) {
            _dateS = dateS;
            _dateE = dateE;
            _apiKey = apiKey;
        }
        
        /// <summary>
        /// 검색 날짜를 오늘로부터 7일 전으로 수정
        /// </summary>
        public void SetDateToToday() {
            _dateS = Int32.Parse(DateTime.Now.ToString("yyyyMMdd")) - 7;
            _dateE = _dateS;
        }

        //TODO: Main 실행 메서드 추가
        public string Run() {
            if (!CanIRun()) { return "ERROR: Need to argument"; }
        }

        /// <summary>
        /// 동작 가능 여부 boolean 반환
        /// </summary>
        /// <returns>동작 가능 여부</returns>
        public bool CanIRun() {
            if (_timeE.Equals(null) || _timeS.Equals(null) || _dateE.Equals(null) || _dateS.Equals(null) ||
                _apiKey.Equals(null)) {
                return false;
            }
            return true;
        }

        //TODO: 지정된 형식으로 출력 메서드 추가
        private void ExportToTxt() {
            
        }
    }
}