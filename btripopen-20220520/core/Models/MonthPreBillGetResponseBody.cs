// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthPreBillGetResponseBody : TeaModel {
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
        public List<MonthPreBillGetResponseBodyModule> Module { get; set; }
        public class MonthPreBillGetResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-04-30</para>
            /// </summary>
            [NameInMap("end_date")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("monthAccountBillDetail")]
            [Validation(Required=false)]
            public MonthPreBillGetResponseBodyModuleMonthAccountBillDetail MonthAccountBillDetail { get; set; }
            public class MonthPreBillGetResponseBodyModuleMonthAccountBillDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("billConfirmed")]
                [Validation(Required=false)]
                public int? BillConfirmed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>56.70</para>
                /// </summary>
                [NameInMap("carAmount")]
                [Validation(Required=false)]
                public double? CarAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("damageAmount")]
                [Validation(Required=false)]
                public double? DamageAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234.00</para>
                /// </summary>
                [NameInMap("flightAmount")]
                [Validation(Required=false)]
                public double? FlightAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.50</para>
                /// </summary>
                [NameInMap("fuPoint")]
                [Validation(Required=false)]
                public double? FuPoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500.00</para>
                /// </summary>
                [NameInMap("hotelAmount")]
                [Validation(Required=false)]
                public double? HotelAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3456.00</para>
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
                /// <b>Example:</b>
                /// <para>20200601</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>45.00</para>
                /// </summary>
                [NameInMap("serviceAmount")]
                [Validation(Required=false)]
                public double? ServiceAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>648.00</para>
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
            /// <para><a href="https://cdn.ewt360.com/resources/tiku_h5/uploads/2026/5/3/6fc104f3-561e-4960-b962-a112db1e9d00.jpg">https://cdn.ewt360.com/resources/tiku_h5/uploads/2026/5/3/6fc104f3-561e-4960-b962-a112db1e9d00.jpg</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3D082D37-160A-53BE-9CF1-7AB8E100045B</para>
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
        /// <para>3b52151317702574069534727d0099</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
