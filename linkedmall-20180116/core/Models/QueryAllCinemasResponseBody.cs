// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryAllCinemasResponseBody : TeaModel {
        [NameInMap("Cinemas")]
        [Validation(Required=false)]
        public QueryAllCinemasResponseBodyCinemas Cinemas { get; set; }
        public class QueryAllCinemasResponseBodyCinemas : TeaModel {
            [NameInMap("Cinema")]
            [Validation(Required=false)]
            public List<QueryAllCinemasResponseBodyCinemasCinema> Cinema { get; set; }
            public class QueryAllCinemasResponseBodyCinemasCinema : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("CinemaName")]
                [Validation(Required=false)]
                public string CinemaName { get; set; }

                [NameInMap("CityId")]
                [Validation(Required=false)]
                public long? CityId { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                [NameInMap("Longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("ScheduleCloseTime")]
                [Validation(Required=false)]
                public long? ScheduleCloseTime { get; set; }

                [NameInMap("StandardId")]
                [Validation(Required=false)]
                public string StandardId { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
