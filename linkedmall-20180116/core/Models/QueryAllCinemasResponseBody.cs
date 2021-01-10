// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryAllCinemasResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Cinemas")]
        [Validation(Required=false)]
        public QueryAllCinemasResponseBodyCinemas Cinemas { get; set; }
        public class QueryAllCinemasResponseBodyCinemas : TeaModel {
            [NameInMap("Cinema")]
            [Validation(Required=false)]
            public List<QueryAllCinemasResponseBodyCinemasCinema> Cinema { get; set; }
            public class QueryAllCinemasResponseBodyCinemasCinema : TeaModel {
                public string StandardId { get; set; }
                public long? ScheduleCloseTime { get; set; }
                public long? CityId { get; set; }
                public string CinemaName { get; set; }
                public string CityName { get; set; }
                public string Address { get; set; }
                public string Longitude { get; set; }
                public string Latitude { get; set; }
                public string Phone { get; set; }
                public long? Id { get; set; }
            }
        };

    }

}
