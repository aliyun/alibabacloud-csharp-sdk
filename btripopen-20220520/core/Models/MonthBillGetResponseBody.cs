// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillGetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<MonthBillGetResponseBodyModule> Module { get; set; }
        public class MonthBillGetResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-04-30</para>
            /// </summary>
            [NameInMap("end_date")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>CorpMonthAccountBillFeeDetail</para>
            /// </summary>
            [NameInMap("monthAccountBillDetail")]
            [Validation(Required=false)]
            public MonthBillGetResponseBodyModuleMonthAccountBillDetail MonthAccountBillDetail { get; set; }
            public class MonthBillGetResponseBodyModuleMonthAccountBillDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("billConfirmed")]
                [Validation(Required=false)]
                public int? BillConfirmed { get; set; }

                /// <summary>
                /// <para>用车金额（单位：元）</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx</para>
                /// </summary>
                [NameInMap("carAmount")]
                [Validation(Required=false)]
                public double? CarAmount { get; set; }

                /// <summary>
                /// <para>违约金金额（单位：元）</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx</para>
                /// </summary>
                [NameInMap("damageAmount")]
                [Validation(Required=false)]
                public double? DamageAmount { get; set; }

                /// <summary>
                /// <para>机票金额（单位：元）</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx</para>
                /// </summary>
                [NameInMap("flightAmount")]
                [Validation(Required=false)]
                public double? FlightAmount { get; set; }

                /// <summary>
                /// <para>福豆金额（单位：元）</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx</para>
                /// </summary>
                [NameInMap("fuPoint")]
                [Validation(Required=false)]
                public double? FuPoint { get; set; }

                /// <summary>
                /// <para>酒店金额（单位：元）</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx</para>
                /// </summary>
                [NameInMap("hotelAmount")]
                [Validation(Required=false)]
                public double? HotelAmount { get; set; }

                /// <summary>
                /// <para>国际机票金额（单位：元）</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx</para>
                /// </summary>
                [NameInMap("ieFlightAmount")]
                [Validation(Required=false)]
                public double? IeFlightAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3000.00</para>
                /// </summary>
                [NameInMap("ieHotelAmount")]
                [Validation(Required=false)]
                public double? IeHotelAmount { get; set; }

                /// <summary>
                /// <para>账期日：YYYYMMDD</para>
                /// 
                /// <b>Example:</b>
                /// <para>20200501</para>
                /// </summary>
                [NameInMap("mailBillDate")]
                [Validation(Required=false)]
                public long? MailBillDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22.40</para>
                /// </summary>
                [NameInMap("mealAmount")]
                [Validation(Required=false)]
                public double? MealAmount { get; set; }

                [NameInMap("metroAmount")]
                [Validation(Required=false)]
                public double? MetroAmount { get; set; }

                /// <summary>
                /// <para>服务费金额（单位：元）</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx</para>
                /// </summary>
                [NameInMap("serviceAmount")]
                [Validation(Required=false)]
                public double? ServiceAmount { get; set; }

                /// <summary>
                /// <para>火车票金额（单位：元）</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx.xx</para>
                /// </summary>
                [NameInMap("trainAmount")]
                [Validation(Required=false)]
                public double? TrainAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19.22</para>
                /// </summary>
                [NameInMap("vasAmount")]
                [Validation(Required=false)]
                public double? VasAmount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-04-01</para>
            /// </summary>
            [NameInMap("start_date")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx">https://xxx</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
