// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightExceedApplyQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightExceedApplyQueryResponseBodyModule Module { get; set; }
        public class FlightExceedApplyQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("apply_intention_info_do")]
            [Validation(Required=false)]
            public FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDo ApplyIntentionInfoDo { get; set; }
            public class FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDo : TeaModel {
                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-12T16:47Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>F</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public int? CabinClass { get; set; }

                [NameInMap("cabin_class_str")]
                [Validation(Required=false)]
                public string CabinClassStr { get; set; }

                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-12T16:47Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MU2759</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("apply_intention_info_do_list")]
            [Validation(Required=false)]
            public List<FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDoList> ApplyIntentionInfoDoList { get; set; }
            public class FlightExceedApplyQueryResponseBodyModuleApplyIntentionInfoDoList : TeaModel {
                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public int? CabinClass { get; set; }

                [NameInMap("cabin_class_str")]
                [Validation(Required=false)]
                public string CabinClassStr { get; set; }

                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("apply_recommend_flights")]
            [Validation(Required=false)]
            public FlightExceedApplyQueryResponseBodyModuleApplyRecommendFlights ApplyRecommendFlights { get; set; }
            public class FlightExceedApplyQueryResponseBodyModuleApplyRecommendFlights : TeaModel {
                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public int? CabinClass { get; set; }

                [NameInMap("cabin_class_str")]
                [Validation(Required=false)]
                public string CabinClassStr { get; set; }

                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("transfer_airport_name")]
                [Validation(Required=false)]
                public string TransferAirportName { get; set; }

            }

            [NameInMap("btrip_cause")]
            [Validation(Required=false)]
            public string BtripCause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("exceed_reason")]
            [Validation(Required=false)]
            public string ExceedReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("exceed_type")]
            [Validation(Required=false)]
            public int? ExceedType { get; set; }

            [NameInMap("origin_standard")]
            [Validation(Required=false)]
            public string OriginStandard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-12T16:47Z</para>
            /// </summary>
            [NameInMap("submit_time")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0001A1100000007EX08O</para>
            /// </summary>
            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_corp</para>
            /// </summary>
            [NameInMap("thirdpart_corp_id")]
            [Validation(Required=false)]
            public string ThirdpartCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
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
