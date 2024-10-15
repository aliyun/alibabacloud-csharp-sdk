// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryResponseBody : TeaModel {
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
        public List<FlightOrderListQueryResponseBodyModule> Module { get; set; }
        public class FlightOrderListQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>11774</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("arr_airport")]
            [Validation(Required=false)]
            public string ArrAirport { get; set; }

            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            [NameInMap("arr_city_ad_code")]
            [Validation(Required=false)]
            public string ArrCityAdCode { get; set; }

            [NameInMap("btrip_title")]
            [Validation(Required=false)]
            public string BtripTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("cabin_class")]
            [Validation(Required=false)]
            public string CabinClass { get; set; }

            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            [NameInMap("cost_center")]
            [Validation(Required=false)]
            public FlightOrderListQueryResponseBodyModuleCostCenter CostCenter { get; set; }
            public class FlightOrderListQueryResponseBodyModuleCostCenter : TeaModel {
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>44632</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NM98767</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public string Number { get; set; }

            }

            [NameInMap("dep_airport")]
            [Validation(Required=false)]
            public string DepAirport { get; set; }

            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            [NameInMap("dep_city_ad_code")]
            [Validation(Required=false)]
            public string DepCityAdCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30.12%</para>
            /// </summary>
            [NameInMap("discount")]
            [Validation(Required=false)]
            public string Discount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MU7854</para>
            /// </summary>
            [NameInMap("flight_no")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200042</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("insure_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryResponseBodyModuleInsureInfoList> InsureInfoList { get; set; }
            public class FlightOrderListQueryResponseBodyModuleInsureInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>KJ-879657</para>
                /// </summary>
                [NameInMap("insure_no")]
                [Validation(Required=false)]
                public string InsureNo { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("invoice")]
            [Validation(Required=false)]
            public FlightOrderListQueryResponseBodyModuleInvoice Invoice { get; set; }
            public class FlightOrderListQueryResponseBodyModuleInvoice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7304</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("passenger_count")]
            [Validation(Required=false)]
            public int? PassengerCount { get; set; }

            [NameInMap("passenger_name")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class FlightOrderListQueryResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MU5354</para>
                /// </summary>
                [NameInMap("change_flight_no")]
                [Validation(Required=false)]
                public string ChangeFlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12%</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00-7687</para>
                /// </summary>
                [NameInMap("original_ticket_no")]
                [Validation(Required=false)]
                public string OriginalTicketNo { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A-135767</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f98236773</para>
                /// </summary>
                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-PROJECT</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-PROJECT</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("ret_date")]
            [Validation(Required=false)]
            public string RetDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-PROJECT</para>
            /// </summary>
            [NameInMap("third_part_project_id")]
            [Validation(Required=false)]
            public string ThirdPartProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-UMN98989</para>
            /// </summary>
            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            [NameInMap("thirdpart_business_id")]
            [Validation(Required=false)]
            public string ThirdpartBusinessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cs9897766</para>
            /// </summary>
            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

            [NameInMap("user_affiliate_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryResponseBodyModuleUserAffiliateList> UserAffiliateList { get; set; }
            public class FlightOrderListQueryResponseBodyModuleUserAffiliateList : TeaModel {
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("page_info")]
        [Validation(Required=false)]
        public FlightOrderListQueryResponseBodyPageInfo PageInfo { get; set; }
        public class FlightOrderListQueryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
