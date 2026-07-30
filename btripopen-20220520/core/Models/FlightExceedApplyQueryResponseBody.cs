// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightExceedApplyQueryResponseBody : TeaModel {
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
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The approval order object.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightExceedApplyQueryResponseBodyModule Module { get; set; }
        public class FlightExceedApplyQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The business travel approval order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            /// <summary>
            /// <para>The intended travel information.</para>
            /// </summary>
            [NameInMap("apply_intention_info_do")]
            [Validation(Required=false)]
            public FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDo ApplyIntentionInfoDo { get; set; }
            public class FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDo : TeaModel {
                /// <summary>
                /// <para>The arrival airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                /// <summary>
                /// <para>The arrival city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The arrival city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-12T16:47Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The cabin class that exceeds the standard. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>P: premium economy class.</description></item>
                /// <item><description>C: business class.</description></item>
                /// <item><description>F: first class.</description></item>
                /// <item><description>Y: economy class.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>F</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class applied for that exceeds the standard. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: first class.</description></item>
                /// <item><description>1: business class.</description></item>
                /// <item><description>2: economy class.</description></item>
                /// <item><description>3: premium economy class.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public int? CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class description. Values: first class, business class, economy class, or premium economy class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_class_str")]
                [Validation(Required=false)]
                public string CabinClassStr { get; set; }

                /// <summary>
                /// <para>The departure airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                /// <summary>
                /// <para>The departure city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <para>The departure city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-12T16:47Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4折</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU2759</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The price in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <para>The excess type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: discount.</description></item>
                /// <item><description>3, 9, 11: discount and time.</description></item>
                /// <item><description>2, 8, 10: time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The collection of intended travel information (multiple segments for round-trip scenarios).</para>
            /// </summary>
            [NameInMap("apply_intention_info_do_list")]
            [Validation(Required=false)]
            public List<FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDoList> ApplyIntentionInfoDoList { get; set; }
            public class FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDoList : TeaModel {
                /// <summary>
                /// <para>The arrival airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JJN</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-13 09:12:22</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>F</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YS</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public int? CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class description. Values: first class, business class, economy class, or premium economy class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_class_str")]
                [Validation(Required=false)]
                public string CabinClassStr { get; set; }

                /// <summary>
                /// <para>The departure airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <para>The departure city name, such as Beijing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure time of the rebooked ticket.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-12 09:12:22</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The discount rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4折</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1371</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The price in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <para>The submission type of the application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: submitted on behalf of another person.</description></item>
                /// <item><description>2: submitted by the applicant.</description></item>
                /// </list>
                /// <para>Note: When the application is submitted on behalf of another person, the submitter cannot place an order for themselves.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The recommended flight information.</para>
            /// </summary>
            [NameInMap("apply_recommend_flights")]
            [Validation(Required=false)]
            public FlightExceedApplyQueryResponseBodyModuleApplyRecommendFlights ApplyRecommendFlights { get; set; }
            public class FlightExceedApplyQueryResponseBodyModuleApplyRecommendFlights : TeaModel {
                /// <summary>
                /// <para>The arrival airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                /// <summary>
                /// <para>The arrival city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>上海</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-12T16:47Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The flight cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>F</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The flight cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public int? CabinClass { get; set; }

                /// <summary>
                /// <para>The cabin class description. Values: first class, business class, economy class, or premium economy class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>头等舱</para>
                /// </summary>
                [NameInMap("cabin_class_str")]
                [Validation(Required=false)]
                public string CabinClassStr { get; set; }

                /// <summary>
                /// <para>The departure airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                /// <summary>
                /// <para>The departure city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-12T16:47Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4折</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU6390</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The price in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <para>The transfer airport name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>萧山国际机场</para>
                /// </summary>
                [NameInMap("transfer_airport_name")]
                [Validation(Required=false)]
                public string TransferAirportName { get; set; }

            }

            /// <summary>
            /// <para>The reason for the business trip.</para>
            /// 
            /// <b>Example:</b>
            /// <para>出差</para>
            /// </summary>
            [NameInMap("btrip_cause")]
            [Validation(Required=false)]
            public string BtripCause { get; set; }

            /// <summary>
            /// <para>The business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The reason for exceeding the standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>原因</para>
            /// </summary>
            [NameInMap("exceed_reason")]
            [Validation(Required=false)]
            public string ExceedReason { get; set; }

            /// <summary>
            /// <para>The excess type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: discount.</description></item>
            /// <item><description>3, 9, 11: discount and time.</description></item>
            /// <item><description>2, 8, 10: time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("exceed_type")]
            [Validation(Required=false)]
            public int? ExceedType { get; set; }

            /// <summary>
            /// <para>The original travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>经济舱（2折及以下）</para>
            /// </summary>
            [NameInMap("origin_standard")]
            [Validation(Required=false)]
            public string OriginStandard { get; set; }

            /// <summary>
            /// <para>The approval order status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: pending approval.</description></item>
            /// <item><description>1: approved.</description></item>
            /// <item><description>2: rejected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The submission time of the approval order.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T16:47Z</para>
            /// </summary>
            [NameInMap("submit_time")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The third-party business trip approval order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0001A1100000007EX08O</para>
            /// </summary>
            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            /// <summary>
            /// <para>The third-party enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_corp</para>
            /// </summary>
            [NameInMap("thirdpart_corp_id")]
            [Validation(Required=false)]
            public string ThirdpartCorpId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
