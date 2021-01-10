// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryMovieSchedulesResponseBody : TeaModel {
        [NameInMap("Schedules")]
        [Validation(Required=false)]
        public QueryMovieSchedulesResponseBodySchedules Schedules { get; set; }
        public class QueryMovieSchedulesResponseBodySchedules : TeaModel {
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public List<QueryMovieSchedulesResponseBodySchedulesSchedule> Schedule { get; set; }
            public class QueryMovieSchedulesResponseBodySchedulesSchedule : TeaModel {
                public string SessionEndingTime { get; set; }
                public string MovieVersion { get; set; }
                public long? MaxCanBuy { get; set; }
                public long? MovieId { get; set; }
                public string ScheduleArea { get; set; }
                public string HallName { get; set; }
                public bool? IsExpired { get; set; }
                public string SessionStartingTime { get; set; }
                public long? Price { get; set; }
                public string ReleaseDate { get; set; }
                public string SectionId { get; set; }
                public long? CinemaId { get; set; }
                public long? ServiceFee { get; set; }
                public long? Id { get; set; }
            }
        };

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

    }

}
