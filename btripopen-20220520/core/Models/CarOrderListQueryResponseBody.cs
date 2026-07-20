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

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>出差</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>白色本田</para>
            /// </summary>
            [NameInMap("car_info")]
            [Validation(Required=false)]
            public string CarInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>601</para>
            /// </summary>
            [NameInMap("car_level")]
            [Validation(Required=false)]
            public int? CarLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>企业id</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试公司</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试成本中心</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>部门ID</para>
            /// </summary>
            [NameInMap("dept_id")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>部门名称</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>阿里巴巴西溪园区</para>
            /// </summary>
            [NameInMap("from_address")]
            [Validation(Required=false)]
            public string FromAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("from_city_ad_code")]
            [Validation(Required=false)]
            public string FromCityAdCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>阿里巴巴-飞猪</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>加班</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1012051200419312345</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>订单状态</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>乘客姓名</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三,李四</para>
                /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>北京项目</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>高新文教区东部软件园创新大厦(马塍路)</para>
            /// </summary>
            [NameInMap("real_from_address")]
            [Validation(Required=false)]
            public string RealFromAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("real_from_city_ad_code")]
            [Validation(Required=false)]
            public string RealFromCityAdCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("real_from_city_name")]
            [Validation(Required=false)]
            public string RealFromCityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>联创街</para>
            /// </summary>
            [NameInMap("real_to_address")]
            [Validation(Required=false)]
            public string RealToAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("real_to_city_ad_code")]
            [Validation(Required=false)]
            public string RealToCityAdCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>上海</para>
            /// </summary>
            [NameInMap("real_to_city_name")]
            [Validation(Required=false)]
            public string RealToCityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>00021230711000001Test-2</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>乐佳国际</para>
            /// </summary>
            [NameInMap("to_address")]
            [Validation(Required=false)]
            public string ToAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330100</para>
            /// </summary>
            [NameInMap("to_city_ad_code")]
            [Validation(Required=false)]
            public string ToCityAdCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>上海</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>预定人用户ID</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>预定人姓名</para>
            /// </summary>
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
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
