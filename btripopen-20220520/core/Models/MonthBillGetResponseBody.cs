// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillGetResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The monthly billing information.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<MonthBillGetResponseBodyModule> Module { get; set; }
        public class MonthBillGetResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The end date of the billing period.</para>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-30</para>
            /// </summary>
            [NameInMap("end_date")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The bill object details.</para>
            /// </summary>
            [NameInMap("monthAccountBillDetail")]
            [Validation(Required=false)]
            public MonthBillGetResponseBodyModuleMonthAccountBillDetail MonthAccountBillDetail { get; set; }
            public class MonthBillGetResponseBodyModuleMonthAccountBillDetail : TeaModel {
                /// <summary>
                /// <para>Indicates whether the bill is confirmed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("billConfirmed")]
                [Validation(Required=false)]
                public int? BillConfirmed { get; set; }

                /// <summary>
                /// <para>The car service amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>56.70</para>
                /// </summary>
                [NameInMap("carAmount")]
                [Validation(Required=false)]
                public double? CarAmount { get; set; }

                /// <summary>
                /// <para>The penalty amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("damageAmount")]
                [Validation(Required=false)]
                public double? DamageAmount { get; set; }

                /// <summary>
                /// <para>The flight ticket amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234.00</para>
                /// </summary>
                [NameInMap("flightAmount")]
                [Validation(Required=false)]
                public double? FlightAmount { get; set; }

                /// <summary>
                /// <para>The Fu points amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.50</para>
                /// </summary>
                [NameInMap("fuPoint")]
                [Validation(Required=false)]
                public double? FuPoint { get; set; }

                /// <summary>
                /// <para>The hotel amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500.00</para>
                /// </summary>
                [NameInMap("hotelAmount")]
                [Validation(Required=false)]
                public double? HotelAmount { get; set; }

                /// <summary>
                /// <para>The international flight ticket amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3456.00</para>
                /// </summary>
                [NameInMap("ieFlightAmount")]
                [Validation(Required=false)]
                public double? IeFlightAmount { get; set; }

                /// <summary>
                /// <para>The international hotel amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000.00</para>
                /// </summary>
                [NameInMap("ieHotelAmount")]
                [Validation(Required=false)]
                public double? IeHotelAmount { get; set; }

                /// <summary>
                /// <para>The bill issue date.</para>
                /// <list type="bullet">
                /// <item><description>Format: yyyyMMdd.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>20200501</para>
                /// </summary>
                [NameInMap("mailBillDate")]
                [Validation(Required=false)]
                public long? MailBillDate { get; set; }

                /// <summary>
                /// <para>The meal amount. Unit: CNY.</para>
                /// 
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
                /// <para>The service fee amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45.00</para>
                /// </summary>
                [NameInMap("serviceAmount")]
                [Validation(Required=false)]
                public double? ServiceAmount { get; set; }

                /// <summary>
                /// <para>The train ticket amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>648.00</para>
                /// </summary>
                [NameInMap("trainAmount")]
                [Validation(Required=false)]
                public double? TrainAmount { get; set; }

                /// <summary>
                /// <para>The value-added service amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19.22</para>
                /// </summary>
                [NameInMap("vasAmount")]
                [Validation(Required=false)]
                public double? VasAmount { get; set; }

            }

            /// <summary>
            /// <para>The start date of the billing period.</para>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-01</para>
            /// </summary>
            [NameInMap("start_date")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The download link for the bill data. Retrieve it using HttpClient and parse it in GBK encoding.</para>
            /// <list type="bullet">
            /// <item><description>The data is in JSON format.</description></item>
            /// <item><description>The link is valid for 5 minutes.</description></item>
            /// <item><description>For object descriptions, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=5037134">Alibaba Business Travel bill object overview</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://alibtrip-oss.oss-cn-hangzhou.aliyuncs.com/">https://alibtrip-oss.oss-cn-hangzhou.aliyuncs.com/</a>********</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-<b><b>-</b></b>-****-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace ID of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
