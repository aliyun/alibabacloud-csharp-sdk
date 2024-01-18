// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryMovieSchedulesResponseBody : TeaModel {
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

        [NameInMap("Schedules")]
        [Validation(Required=false)]
        public QueryMovieSchedulesResponseBodySchedules Schedules { get; set; }
        public class QueryMovieSchedulesResponseBodySchedules : TeaModel {
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public List<QueryMovieSchedulesResponseBodySchedulesSchedule> Schedule { get; set; }
            public class QueryMovieSchedulesResponseBodySchedulesSchedule : TeaModel {
                [NameInMap("CinemaId")]
                [Validation(Required=false)]
                public long? CinemaId { get; set; }

                [NameInMap("HallName")]
                [Validation(Required=false)]
                public string HallName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsExpired")]
                [Validation(Required=false)]
                public bool? IsExpired { get; set; }

                [NameInMap("MaxCanBuy")]
                [Validation(Required=false)]
                public long? MaxCanBuy { get; set; }

                [NameInMap("MovieId")]
                [Validation(Required=false)]
                public long? MovieId { get; set; }

                [NameInMap("MovieVersion")]
                [Validation(Required=false)]
                public string MovieVersion { get; set; }

                [NameInMap("Price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("ReleaseDate")]
                [Validation(Required=false)]
                public string ReleaseDate { get; set; }

                [NameInMap("ScheduleArea")]
                [Validation(Required=false)]
                public string ScheduleArea { get; set; }

                [NameInMap("SectionId")]
                [Validation(Required=false)]
                public string SectionId { get; set; }

                [NameInMap("ServiceFee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

                [NameInMap("SessionEndingTime")]
                [Validation(Required=false)]
                public string SessionEndingTime { get; set; }

                [NameInMap("SessionStartingTime")]
                [Validation(Required=false)]
                public string SessionStartingTime { get; set; }

            }

        }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
