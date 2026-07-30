// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthPreBillGetResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The remarks about the result, such as a description of the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The return value from the server. Returns empty if there is no result or an exception occurs.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<MonthPreBillGetResponseBodyModule> Module { get; set; }
        public class MonthPreBillGetResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The end date.</para>
            /// 
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
            public MonthPreBillGetResponseBodyModuleMonthAccountBillDetail MonthAccountBillDetail { get; set; }
            public class MonthPreBillGetResponseBodyModuleMonthAccountBillDetail : TeaModel {
                /// <summary>
                /// <para>The bill confirmation status. Valid values: null: no confirmation required. 0: unconfirmed. 1: confirmed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("billConfirmed")]
                [Validation(Required=false)]
                public int? BillConfirmed { get; set; }

                /// <summary>
                /// <para>The car service amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>56.70</para>
                /// </summary>
                [NameInMap("carAmount")]
                [Validation(Required=false)]
                public double? CarAmount { get; set; }

                /// <summary>
                /// <para>The penalty amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("damageAmount")]
                [Validation(Required=false)]
                public double? DamageAmount { get; set; }

                /// <summary>
                /// <para>The flight amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234.00</para>
                /// </summary>
                [NameInMap("flightAmount")]
                [Validation(Required=false)]
                public double? FlightAmount { get; set; }

                /// <summary>
                /// <para>The FuPoint amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.50</para>
                /// </summary>
                [NameInMap("fuPoint")]
                [Validation(Required=false)]
                public double? FuPoint { get; set; }

                /// <summary>
                /// <para>The hotel amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>500.00</para>
                /// </summary>
                [NameInMap("hotelAmount")]
                [Validation(Required=false)]
                public double? HotelAmount { get; set; }

                /// <summary>
                /// <para>The international flight amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>3456.00</para>
                /// </summary>
                [NameInMap("ieFlightAmount")]
                [Validation(Required=false)]
                public double? IeFlightAmount { get; set; }

                /// <summary>
                /// <para>The international hotel amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000.00</para>
                /// </summary>
                [NameInMap("ieHotelAmount")]
                [Validation(Required=false)]
                public double? IeHotelAmount { get; set; }

                /// <summary>
                /// <para>The billing date in YYYYMMDD format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20200601</para>
                /// </summary>
                [NameInMap("mailBillDate")]
                [Validation(Required=false)]
                public long? MailBillDate { get; set; }

                /// <summary>
                /// <para>The meal amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22.40</para>
                /// </summary>
                [NameInMap("mealAmount")]
                [Validation(Required=false)]
                public double? MealAmount { get; set; }

                /// <summary>
                /// <para>The service fee amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>45.00</para>
                /// </summary>
                [NameInMap("serviceAmount")]
                [Validation(Required=false)]
                public double? ServiceAmount { get; set; }

                /// <summary>
                /// <para>The train ticket amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>648.00</para>
                /// </summary>
                [NameInMap("trainAmount")]
                [Validation(Required=false)]
                public double? TrainAmount { get; set; }

                /// <summary>
                /// <para>The value-added service amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19.22</para>
                /// </summary>
                [NameInMap("vasAmount")]
                [Validation(Required=false)]
                public double? VasAmount { get; set; }

            }

            /// <summary>
            /// <para>The start date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-01</para>
            /// </summary>
            [NameInMap("start_date")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The data URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cdn.ewt360.com/resources/tiku_h5/uploads/2026/5/3/6fc104f3-561e-4960-b962-a112db1e9d00.jpg">https://cdn.ewt360.com/resources/tiku_h5/uploads/2026/5/3/6fc104f3-561e-4960-b962-a112db1e9d00.jpg</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D082D37-160A-53BE-9CF1-7AB8E100045B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The success flag set by the server. Set to false when an exception occurs or the result is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b52151317702574069534727d0099</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
