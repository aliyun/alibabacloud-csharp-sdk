// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AppMallsService20180224.Models
{
    public class TaobaoFilmGetSchedulesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Schedules")]
        [Validation(Required=false)]
        public List<TaobaoFilmGetSchedulesResponseBodySchedules> Schedules { get; set; }
        public class TaobaoFilmGetSchedulesResponseBodySchedules : TeaModel {
            [NameInMap("CinemaId")]
            [Validation(Required=false)]
            public long? CinemaId { get; set; }

            [NameInMap("CloseTime")]
            [Validation(Required=false)]
            public string CloseTime { get; set; }

            [NameInMap("HallId")]
            [Validation(Required=false)]
            public string HallId { get; set; }

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

            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("ScheduleArea")]
            [Validation(Required=false)]
            public string ScheduleArea { get; set; }

            [NameInMap("SectionId")]
            [Validation(Required=false)]
            public string SectionId { get; set; }

            [NameInMap("ServiceFee")]
            [Validation(Required=false)]
            public long? ServiceFee { get; set; }

            [NameInMap("ShowDate")]
            [Validation(Required=false)]
            public string ShowDate { get; set; }

            [NameInMap("ShowId")]
            [Validation(Required=false)]
            public long? ShowId { get; set; }

            [NameInMap("ShowTime")]
            [Validation(Required=false)]
            public string ShowTime { get; set; }

            [NameInMap("ShowVersion")]
            [Validation(Required=false)]
            public string ShowVersion { get; set; }

        }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMsg")]
        [Validation(Required=false)]
        public string SubMsg { get; set; }

    }

}
