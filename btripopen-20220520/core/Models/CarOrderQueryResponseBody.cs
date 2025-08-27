// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarOrderQueryResponseBody : TeaModel {
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
        public CarOrderQueryResponseBodyModule Module { get; set; }
        public class CarOrderQueryResponseBodyModule : TeaModel {
            [NameInMap("car_info")]
            [Validation(Required=false)]
            public CarOrderQueryResponseBodyModuleCarInfo CarInfo { get; set; }
            public class CarOrderQueryResponseBodyModuleCarInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TRAVEL</para>
                /// </summary>
                [NameInMap("business_category")]
                [Validation(Required=false)]
                public string BusinessCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("cancel_time")]
                [Validation(Required=false)]
                public long? CancelTime { get; set; }

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

                [NameInMap("driver_card")]
                [Validation(Required=false)]
                public string DriverCard { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("driver_confirm_time")]
                [Validation(Required=false)]
                public long? DriverConfirmTime { get; set; }

                [NameInMap("driver_name")]
                [Validation(Required=false)]
                public string DriverName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2900</para>
                /// </summary>
                [NameInMap("estimate_price")]
                [Validation(Required=false)]
                public long? EstimatePrice { get; set; }

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
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_special")]
                [Validation(Required=false)]
                public bool? IsSpecial { get; set; }

                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public long? PayTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("publish_time")]
                [Validation(Required=false)]
                public long? PublishTime { get; set; }

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
                /// <para>3</para>
                /// </summary>
                [NameInMap("service_type")]
                [Validation(Required=false)]
                public int? ServiceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v_sp_t_1,v_sp_t_2,v_sp_t_3,v_sp_t_4,v_sp_t_5</para>
                /// </summary>
                [NameInMap("special_types")]
                [Validation(Required=false)]
                public string SpecialTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("taken_time")]
                [Validation(Required=false)]
                public long? TakenTime { get; set; }

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
                /// <para>12</para>
                /// </summary>
                [NameInMap("travel_distance")]
                [Validation(Required=false)]
                public string TravelDistance { get; set; }

                [NameInMap("way_points")]
                [Validation(Required=false)]
                public List<CarOrderQueryResponseBodyModuleCarInfoWayPoints> WayPoints { get; set; }
                public class CarOrderQueryResponseBodyModuleCarInfoWayPoints : TeaModel {
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    [NameInMap("latitude")]
                    [Validation(Required=false)]
                    public string Latitude { get; set; }

                    [NameInMap("longitude")]
                    [Validation(Required=false)]
                    public string Longitude { get; set; }

                }

            }

            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public CarOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class CarOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public CarOrderQueryResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class CarOrderQueryResponseBodyModuleOrderBaseInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("btrip_cause")]
                [Validation(Required=false)]
                public string BtripCause { get; set; }

                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxxx</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10101010</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("gmt_modified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1012000000000000</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public long? SubOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>thirdpart_1010101010</para>
                /// </summary>
                [NameInMap("third_depart_id")]
                [Validation(Required=false)]
                public string ThirdDepartId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("thirdpart_business_id")]
                [Validation(Required=false)]
                public string ThirdpartBusinessId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxxx</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<CarOrderQueryResponseBodyModulePassengerList> PassengerList { get; set; }
            public class CarOrderQueryResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>costId</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>costName</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>costNumber</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>projectCode1</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>projectId</para>
                /// </summary>
                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>thirdpartCostId</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>thirdpartProjectId</para>
                /// </summary>
                [NameInMap("thirdpart_project_id")]
                [Validation(Required=false)]
                public string ThirdpartProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>userId</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<CarOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class CarOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("person_price")]
                [Validation(Required=false)]
                public long? PersonPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1012000000001</para>
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

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
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
