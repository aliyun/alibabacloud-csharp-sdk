// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class QueryResult : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryResultData> Data { get; set; }
        public class QueryResultData : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("cityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            [NameInMap("distanceMeter")]
            [Validation(Required=false)]
            public string DistanceMeter { get; set; }

            [NameInMap("districtCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            [NameInMap("districtName")]
            [Validation(Required=false)]
            public string DistrictName { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("images")]
            [Validation(Required=false)]
            public List<QueryResultDataImages> Images { get; set; }
            public class QueryResultDataImages : TeaModel {
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("metadata")]
            [Validation(Required=false)]
            public QueryResultDataMetadata Metadata { get; set; }
            public class QueryResultDataMetadata : TeaModel {
                [NameInMap("averageSpend")]
                [Validation(Required=false)]
                public string AverageSpend { get; set; }

                [NameInMap("businessArea")]
                [Validation(Required=false)]
                public string BusinessArea { get; set; }

                [NameInMap("dailyOpeningHours")]
                [Validation(Required=false)]
                public string DailyOpeningHours { get; set; }

                [NameInMap("mainTag")]
                [Validation(Required=false)]
                public string MainTag { get; set; }

                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("weeklyOpeningDays")]
                [Validation(Required=false)]
                public string WeeklyOpeningDays { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("provinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

            [NameInMap("provinceName")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

            [NameInMap("typeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }

            [NameInMap("types")]
            [Validation(Required=false)]
            public string Types { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
