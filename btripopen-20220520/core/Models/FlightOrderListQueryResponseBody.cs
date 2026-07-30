// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryResponseBody : TeaModel {
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<FlightOrderListQueryResponseBodyModule> Module { get; set; }
        public class FlightOrderListQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The business travel approval ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11774</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            /// <summary>
            /// <para>The arrival airport.</para>
            /// 
            /// <b>Example:</b>
            /// <para>白云机场</para>
            /// </summary>
            [NameInMap("arr_airport")]
            [Validation(Required=false)]
            public string ArrAirport { get; set; }

            /// <summary>
            /// <para>The administrative division code of the prefecture-level city to which the arrival airport belongs.</para>
            /// <remarks>
            /// <para>Notice: This field may not have a value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("arr_apt_prefecture_ad_code")]
            [Validation(Required=false)]
            public string ArrAptPrefectureAdCode { get; set; }

            /// <summary>
            /// <para>The name of the prefecture-level city to which the arrival airport belongs.</para>
            /// <remarks>
            /// <para>Notice: This field may not have a value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("arr_apt_prefecture_name")]
            [Validation(Required=false)]
            public string ArrAptPrefectureName { get; set; }

            /// <summary>
            /// <para>The arrival city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>上海</para>
            /// </summary>
            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            /// <summary>
            /// <para>The arrival city code.&gt;Notice: This field may not have a value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("arr_city_ad_code")]
            [Validation(Required=false)]
            public string ArrCityAdCode { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>出差</para>
            /// </summary>
            [NameInMap("btrip_title")]
            [Validation(Required=false)]
            public string BtripTitle { get; set; }

            /// <summary>
            /// <para>The cabin class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("cabin_class")]
            [Validation(Required=false)]
            public string CabinClass { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>商旅企业id</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The enterprise name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里巴巴</para>
            /// </summary>
            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>The cost center information.</para>
            /// </summary>
            [NameInMap("cost_center")]
            [Validation(Required=false)]
            public FlightOrderListQueryResponseBodyModuleCostCenter CostCenter { get; set; }
            public class FlightOrderListQueryResponseBodyModuleCostCenter : TeaModel {
                /// <summary>
                /// <para>The business travel enterprise ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅企业id</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The business travel cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44632</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里巴巴</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The cost center number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NM98767</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public string Number { get; set; }

            }

            /// <summary>
            /// <para>The departure airport.</para>
            /// 
            /// <b>Example:</b>
            /// <para>萧山机场</para>
            /// </summary>
            [NameInMap("dep_airport")]
            [Validation(Required=false)]
            public string DepAirport { get; set; }

            /// <summary>
            /// <para>The administrative division code of the prefecture-level city to which the departure airport belongs.</para>
            /// <remarks>
            /// <para>Notice: This field may not have a value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>110100</para>
            /// </summary>
            [NameInMap("dep_apt_prefecture_ad_code")]
            [Validation(Required=false)]
            public string DepAptPrefectureAdCode { get; set; }

            /// <summary>
            /// <para>The name of the prefecture-level city to which the departure airport belongs.</para>
            /// <remarks>
            /// <para>Notice: This field may not have a value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("dep_apt_prefecture_name")]
            [Validation(Required=false)]
            public string DepAptPrefectureName { get; set; }

            /// <summary>
            /// <para>The departure city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            /// <summary>
            /// <para>The departure city code.&gt;Notice: This field may not have a value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("dep_city_ad_code")]
            [Validation(Required=false)]
            public string DepCityAdCode { get; set; }

            /// <summary>
            /// <para>The departure date.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            /// <summary>
            /// <para>The ID of the department to which the user belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>用户所在部门id</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            /// <summary>
            /// <para>The department name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>淘宝</para>
            /// </summary>
            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>The discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.12%</para>
            /// </summary>
            [NameInMap("discount")]
            [Validation(Required=false)]
            public string Discount { get; set; }

            /// <summary>
            /// <para>The flight number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MU7854</para>
            /// </summary>
            [NameInMap("flight_no")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200042</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The list of insurance information.&gt;Notice: This field has a value only when an insurance order exists. Check for null values.</para>
            /// </summary>
            [NameInMap("insure_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryResponseBodyModuleInsureInfoList> InsureInfoList { get; set; }
            public class FlightOrderListQueryResponseBodyModuleInsureInfoList : TeaModel {
                /// <summary>
                /// <para>The insurance policy number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KJ-879657</para>
                /// </summary>
                [NameInMap("insure_no")]
                [Validation(Required=false)]
                public string InsureNo { get; set; }

                /// <summary>
                /// <para>The name of the passenger (insured person).</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>The invoice information.</para>
            /// </summary>
            [NameInMap("invoice")]
            [Validation(Required=false)]
            public FlightOrderListQueryResponseBodyModuleInvoice Invoice { get; set; }
            public class FlightOrderListQueryResponseBodyModuleInvoice : TeaModel {
                /// <summary>
                /// <para>The business travel invoice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7304</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试发票抬头</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The number of passengers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("passenger_count")]
            [Validation(Required=false)]
            public int? PassengerCount { get; set; }

            /// <summary>
            /// <para>The passenger names, separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三,李四</para>
            /// </summary>
            [NameInMap("passenger_name")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

            /// <summary>
            /// <para>The list of price details.&gt;Notice: This field has a value only after payment succeeds. The default value is []. Check for null values.</para>
            /// </summary>
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class FlightOrderListQueryResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <para>The transaction category code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <para>The transaction category type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                /// <summary>
                /// <para>The changed flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MU5354</para>
                /// </summary>
                [NameInMap("change_flight_no")]
                [Validation(Required=false)]
                public string ChangeFlightNo { get; set; }

                /// <summary>
                /// <para>The discount for the changed ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12%</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// <para>The arrival time of the changed ticket.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The transaction creation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The ticket number before the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00-7687</para>
                /// </summary>
                [NameInMap("original_ticket_no")]
                [Validation(Required=false)]
                public string OriginalTicketNo { get; set; }

                /// <summary>
                /// <para>The passenger names, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三,李四</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The payment method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <para>The departure time of the changed ticket.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The ticket number after the change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A-135767</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The transaction serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f98236773</para>
                /// </summary>
                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <para>The fund flow direction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The project code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-PROJECT</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-PROJECT</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试项目</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The arrival date.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("ret_date")]
            [Validation(Required=false)]
            public string RetDate { get; set; }

            /// <summary>
            /// <para>The order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The third-party project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-PROJECT</para>
            /// </summary>
            [NameInMap("third_part_project_id")]
            [Validation(Required=false)]
            public string ThirdPartProjectId { get; set; }

            /// <summary>
            /// <para>The third-party application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-UMN98989</para>
            /// </summary>
            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            /// <summary>
            /// <para>The external approval ID displayed to users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00021230711000001Test-2</para>
            /// </summary>
            [NameInMap("thirdpart_business_id")]
            [Validation(Required=false)]
            public string ThirdpartBusinessId { get; set; }

            /// <summary>
            /// <para>The third-party itinerary ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs9897766</para>
            /// </summary>
            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

            /// <summary>
            /// <para>The trip type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

            /// <summary>
            /// <para>The list of traveler information.</para>
            /// </summary>
            [NameInMap("user_affiliate_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryResponseBodyModuleUserAffiliateList> UserAffiliateList { get; set; }
            public class FlightOrderListQueryResponseBodyModuleUserAffiliateList : TeaModel {
                /// <summary>
                /// <para>The traveler ID (third-party user ID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>第三方用户id</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The traveler name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The third-party user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>第三方用户id</para>
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
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public FlightOrderListQueryResponseBodyPageInfo PageInfo { get; set; }
        public class FlightOrderListQueryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
