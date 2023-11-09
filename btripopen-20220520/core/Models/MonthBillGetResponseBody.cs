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

            /// <summary>
            /// CorpMonthAccountBillFeeDetail
            /// </summary>
            [NameInMap("monthAccountBillDetail")]
            [Validation(Required=false)]
            public MonthBillGetResponseBodyModuleMonthAccountBillDetail MonthAccountBillDetail { get; set; }
            public class MonthBillGetResponseBodyModuleMonthAccountBillDetail : TeaModel {
                [NameInMap("billConfirmed")]
                [Validation(Required=false)]
                public int? BillConfirmed { get; set; }

                /// <summary>
                /// 用车金额（单位：元）
                /// </summary>
                [NameInMap("carAmount")]
                [Validation(Required=false)]
                public double? CarAmount { get; set; }

                /// <summary>
                /// 违约金金额（单位：元）
                /// </summary>
                [NameInMap("damageAmount")]
                [Validation(Required=false)]
                public double? DamageAmount { get; set; }

                /// <summary>
                /// 机票金额（单位：元）
                /// </summary>
                [NameInMap("flightAmount")]
                [Validation(Required=false)]
                public double? FlightAmount { get; set; }

                /// <summary>
                /// 福豆金额（单位：元）
                /// </summary>
                [NameInMap("fuPoint")]
                [Validation(Required=false)]
                public double? FuPoint { get; set; }

                /// <summary>
                /// 酒店金额（单位：元）
                /// </summary>
                [NameInMap("hotelAmount")]
                [Validation(Required=false)]
                public double? HotelAmount { get; set; }

                /// <summary>
                /// 国际机票金额（单位：元）
                /// </summary>
                [NameInMap("ieFlightAmount")]
                [Validation(Required=false)]
                public double? IeFlightAmount { get; set; }

                [NameInMap("ieHotelAmount")]
                [Validation(Required=false)]
                public double? IeHotelAmount { get; set; }

                /// <summary>
                /// 账期日：YYYYMMDD
                /// </summary>
                [NameInMap("mailBillDate")]
                [Validation(Required=false)]
                public long? MailBillDate { get; set; }

                /// <summary>
                /// 服务费金额（单位：元）
                /// </summary>
                [NameInMap("serviceAmount")]
                [Validation(Required=false)]
                public double? ServiceAmount { get; set; }

                /// <summary>
                /// 火车票金额（单位：元）
                /// </summary>
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
