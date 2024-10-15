// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarOrderListQueryResponseBody : TeaModel {
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
        public List<CarOrderListQueryResponseBodyModule> Module { get; set; }
        public class CarOrderListQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>117429516</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>201802031353000525653</para>
            /// </summary>
            [NameInMap("apply_show_id")]
            [Validation(Required=false)]
            public string ApplyShowId { get; set; }

            [NameInMap("btrip_title")]
            [Validation(Required=false)]
            public string BtripTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TRAVEL</para>
            /// </summary>
            [NameInMap("business_category")]
            [Validation(Required=false)]
            public string BusinessCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("cancel_time")]
            [Validation(Required=false)]
            public string CancelTime { get; set; }

            [NameInMap("car_info")]
            [Validation(Required=false)]
            public string CarInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("car_level")]
            [Validation(Required=false)]
            public int? CarLevel { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11376</para>
            /// </summary>
            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            [NameInMap("cost_center_name")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CT-134JHK</para>
            /// </summary>
            [NameInMap("cost_center_number")]
            [Validation(Required=false)]
            public string CostCenterNumber { get; set; }

            [NameInMap("dept_id")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("dept_name")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("driver_confirm_time")]
            [Validation(Required=false)]
            public string DriverConfirmTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("estimate_price")]
            [Validation(Required=false)]
            public double? EstimatePrice { get; set; }

            [NameInMap("from_address")]
            [Validation(Required=false)]
            public string FromAddress { get; set; }

            [NameInMap("from_city_ad_code")]
            [Validation(Required=false)]
            public string FromCityAdCode { get; set; }

            [NameInMap("from_city_name")]
            [Validation(Required=false)]
            public string FromCityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3615085</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11876</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            [NameInMap("invoice_title")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_special")]
            [Validation(Required=false)]
            public bool? IsSpecial { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            [NameInMap("passenger_name")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<CarOrderListQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class CarOrderListQueryResponseBodyModulePriceInfoList : TeaModel {
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
                /// <para>2022-07-04T16:13Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

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
                [NameInMap("person_price")]
                [Validation(Required=false)]
                public double? PersonPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8908076767</para>
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
            /// <para>P- JI87KK</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11546</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public int? Provider { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("publish_time")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            [NameInMap("real_from_address")]
            [Validation(Required=false)]
            public string RealFromAddress { get; set; }

            [NameInMap("real_from_city_ad_code")]
            [Validation(Required=false)]
            public string RealFromCityAdCode { get; set; }

            [NameInMap("real_from_city_name")]
            [Validation(Required=false)]
            public string RealFromCityName { get; set; }

            [NameInMap("real_to_address")]
            [Validation(Required=false)]
            public string RealToAddress { get; set; }

            [NameInMap("real_to_city_ad_code")]
            [Validation(Required=false)]
            public string RealToCityAdCode { get; set; }

            [NameInMap("real_to_city_name")]
            [Validation(Required=false)]
            public string RealToCityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("service_type")]
            [Validation(Required=false)]
            public int? ServiceType { get; set; }

            [NameInMap("special_types")]
            [Validation(Required=false)]
            public List<string> SpecialTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("taken_time")]
            [Validation(Required=false)]
            public string TakenTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-OIPK34H</para>
            /// </summary>
            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            [NameInMap("thirdpart_business_id")]
            [Validation(Required=false)]
            public string ThirdpartBusinessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-112JKDF</para>
            /// </summary>
            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

            [NameInMap("to_address")]
            [Validation(Required=false)]
            public string ToAddress { get; set; }

            [NameInMap("to_city_ad_code")]
            [Validation(Required=false)]
            public string ToCityAdCode { get; set; }

            [NameInMap("to_city_name")]
            [Validation(Required=false)]
            public string ToCityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.2</para>
            /// </summary>
            [NameInMap("travel_distance")]
            [Validation(Required=false)]
            public double? TravelDistance { get; set; }

            [NameInMap("user_affiliate_list")]
            [Validation(Required=false)]
            public List<CarOrderListQueryResponseBodyModuleUserAffiliateList> UserAffiliateList { get; set; }
            public class CarOrderListQueryResponseBodyModuleUserAffiliateList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>11342</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("user_confirm")]
            [Validation(Required=false)]
            public int? UserConfirm { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("page_info")]
        [Validation(Required=false)]
        public CarOrderListQueryResponseBodyPageInfo PageInfo { get; set; }
        public class CarOrderListQueryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
