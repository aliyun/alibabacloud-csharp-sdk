// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillGetResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<MonthBillGetResponseBodyModule> Module { get; set; }
        public class MonthBillGetResponseBodyModule : TeaModel {
            [NameInMap("end_date")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("monthAccountBillDetail")]
            [Validation(Required=false)]
            public MonthBillGetResponseBodyModuleMonthAccountBillDetail MonthAccountBillDetail { get; set; }
            public class MonthBillGetResponseBodyModuleMonthAccountBillDetail : TeaModel {
                [NameInMap("carAmount")]
                [Validation(Required=false)]
                public double? CarAmount { get; set; }

                [NameInMap("damageAmount")]
                [Validation(Required=false)]
                public double? DamageAmount { get; set; }

                [NameInMap("flightAmount")]
                [Validation(Required=false)]
                public double? FlightAmount { get; set; }

                [NameInMap("fuPoint")]
                [Validation(Required=false)]
                public double? FuPoint { get; set; }

                [NameInMap("hotelAmount")]
                [Validation(Required=false)]
                public double? HotelAmount { get; set; }

                [NameInMap("ieFlightAmount")]
                [Validation(Required=false)]
                public double? IeFlightAmount { get; set; }

                [NameInMap("mailBillDate")]
                [Validation(Required=false)]
                public long? MailBillDate { get; set; }

                [NameInMap("serviceAmount")]
                [Validation(Required=false)]
                public double? ServiceAmount { get; set; }

                [NameInMap("trainAmount")]
                [Validation(Required=false)]
                public double? TrainAmount { get; set; }

            }

            [NameInMap("start_date")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
