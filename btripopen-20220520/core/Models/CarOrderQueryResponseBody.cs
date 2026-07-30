// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarOrderQueryResponseBody : TeaModel {
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
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public CarOrderQueryResponseBodyModule Module { get; set; }
        public class CarOrderQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The car service information.</para>
            /// </summary>
            [NameInMap("car_info")]
            [Validation(Required=false)]
            public CarOrderQueryResponseBodyModuleCarInfo CarInfo { get; set; }
            public class CarOrderQueryResponseBodyModuleCarInfo : TeaModel {
                /// <summary>
                /// <para>The car service scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TRAVEL</para>
                /// </summary>
                [NameInMap("business_category")]
                [Validation(Required=false)]
                public string BusinessCategory { get; set; }

                /// <summary>
                /// <para>The time when the order was canceled. This value may be null.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("cancel_time")]
                [Validation(Required=false)]
                public long? CancelTime { get; set; }

                /// <summary>
                /// <para>The vehicle type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>长安 白色</para>
                /// </summary>
                [NameInMap("car_info")]
                [Validation(Required=false)]
                public string CarInfo { get; set; }

                /// <summary>
                /// <para>The car type code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>601</para>
                /// </summary>
                [NameInMap("car_level")]
                [Validation(Required=false)]
                public int? CarLevel { get; set; }

                /// <summary>
                /// <para>The driver\&quot;s license plate number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙AB8888</para>
                /// </summary>
                [NameInMap("driver_card")]
                [Validation(Required=false)]
                public string DriverCard { get; set; }

                /// <summary>
                /// <para>The time when the driver confirmed delivery. This value may be null.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("driver_confirm_time")]
                [Validation(Required=false)]
                public long? DriverConfirmTime { get; set; }

                /// <summary>
                /// <para>The driver\&quot;s name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>林师傅</para>
                /// </summary>
                [NameInMap("driver_name")]
                [Validation(Required=false)]
                public string DriverName { get; set; }

                /// <summary>
                /// <para>The estimated price, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2900</para>
                /// </summary>
                [NameInMap("estimate_price")]
                [Validation(Required=false)]
                public long? EstimatePrice { get; set; }

                /// <summary>
                /// <para>The departure address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>海宁西站</para>
                /// </summary>
                [NameInMap("from_address")]
                [Validation(Required=false)]
                public string FromAddress { get; set; }

                /// <summary>
                /// <para>The six-digit administrative division code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("from_city_ad_code")]
                [Validation(Required=false)]
                public string FromCityAdCode { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>嘉兴市</para>
                /// </summary>
                [NameInMap("from_city_name")]
                [Validation(Required=false)]
                public string FromCityName { get; set; }

                /// <summary>
                /// <para>Indicates whether this is a specially flagged order. This value is null for non-special orders.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_special")]
                [Validation(Required=false)]
                public bool? IsSpecial { get; set; }

                /// <summary>
                /// <para>The reason for using the car service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>拜访客户</para>
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <para>The payment time. This value may be null.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public long? PayTime { get; set; }

                /// <summary>
                /// <para>The scheduled car service time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("publish_time")]
                [Validation(Required=false)]
                public long? PublishTime { get; set; }

                /// <summary>
                /// <para>The actual departure address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>海宁西站</para>
                /// </summary>
                [NameInMap("real_from_address")]
                [Validation(Required=false)]
                public string RealFromAddress { get; set; }

                /// <summary>
                /// <para>The six-digit administrative division code of the actual departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("real_from_city_ad_code")]
                [Validation(Required=false)]
                public string RealFromCityAdCode { get; set; }

                /// <summary>
                /// <para>The actual departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>嘉兴市</para>
                /// </summary>
                [NameInMap("real_from_city_name")]
                [Validation(Required=false)]
                public string RealFromCityName { get; set; }

                /// <summary>
                /// <para>The actual destination address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州东站</para>
                /// </summary>
                [NameInMap("real_to_address")]
                [Validation(Required=false)]
                public string RealToAddress { get; set; }

                /// <summary>
                /// <para>The six-digit administrative division code of the actual destination city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("real_to_city_ad_code")]
                [Validation(Required=false)]
                public string RealToCityAdCode { get; set; }

                /// <summary>
                /// <para>The actual destination city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市</para>
                /// </summary>
                [NameInMap("real_to_city_name")]
                [Validation(Required=false)]
                public string RealToCityName { get; set; }

                /// <summary>
                /// <para>The vehicle type. Fixed value: 3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("service_type")]
                [Validation(Required=false)]
                public int? ServiceType { get; set; }

                /// <summary>
                /// <para>The special order identifiers, separated by commas. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>v_sp_t_1: travel distance.</description></item>
                /// <item><description>v_sp_t_2: actual drop-off location.</description></item>
                /// <item><description>v_sp_t_3: travel amount.</description></item>
                /// <item><description>v_sp_t_4: number of rides.</description></item>
                /// <item><description>v_sp_t_5: cross-city order.</description></item>
                /// </list>
                /// <para>This value is null for non-special orders.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v_sp_t_1,v_sp_t_2,v_sp_t_3,v_sp_t_4,v_sp_t_5</para>
                /// </summary>
                [NameInMap("special_types")]
                [Validation(Required=false)]
                public string SpecialTypes { get; set; }

                /// <summary>
                /// <para>The time when the passenger boarded the vehicle. This value may be null.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("taken_time")]
                [Validation(Required=false)]
                public long? TakenTime { get; set; }

                /// <summary>
                /// <para>The destination address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州东站</para>
                /// </summary>
                [NameInMap("to_address")]
                [Validation(Required=false)]
                public string ToAddress { get; set; }

                /// <summary>
                /// <para>The six-digit administrative division code of the destination city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
                /// </summary>
                [NameInMap("to_city_ad_code")]
                [Validation(Required=false)]
                public string ToCityAdCode { get; set; }

                /// <summary>
                /// <para>The destination city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市</para>
                /// </summary>
                [NameInMap("to_city_name")]
                [Validation(Required=false)]
                public string ToCityName { get; set; }

                /// <summary>
                /// <para>The travel distance. This value may be null.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("travel_distance")]
                [Validation(Required=false)]
                public string TravelDistance { get; set; }

                /// <summary>
                /// <para>The waypoints.</para>
                /// </summary>
                [NameInMap("way_points")]
                [Validation(Required=false)]
                public List<CarOrderQueryResponseBodyModuleCarInfoWayPoints> WayPoints { get; set; }
                public class CarOrderQueryResponseBodyModuleCarInfoWayPoints : TeaModel {
                    /// <summary>
                    /// <para>The location name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>南宁市总部路3号中国-东盟科技企业孵化基地二期7号厂房第四、五层</para>
                    /// </summary>
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>The index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <para>The latitude.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34.26900287757989</para>
                    /// </summary>
                    [NameInMap("latitude")]
                    [Validation(Required=false)]
                    public string Latitude { get; set; }

                    /// <summary>
                    /// <para>The longitude.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>114.058959</para>
                    /// </summary>
                    [NameInMap("longitude")]
                    [Validation(Required=false)]
                    public string Longitude { get; set; }

                }

            }

            /// <summary>
            /// <para>The invoice information.</para>
            /// </summary>
            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public CarOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class CarOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                /// <summary>
                /// <para>The invoice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The basic order information.</para>
            /// </summary>
            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public CarOrderQueryResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class CarOrderQueryResponseBodyModuleOrderBaseInfo : TeaModel {
                /// <summary>
                /// <para>The approval form ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The travel reason from the approval form.</para>
                /// 
                /// <b>Example:</b>
                /// <para>拜访客户</para>
                /// </summary>
                [NameInMap("btrip_cause")]
                [Validation(Required=false)]
                public string BtripCause { get; set; }

                /// <summary>
                /// <para>The travel title from the approval form.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州出差</para>
                /// </summary>
                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                /// <summary>
                /// <para>The source type of the car service order. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Alibaba Business Travel.</description></item>
                /// <item><description>1: AMAP H5.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("car_order_source_type")]
                [Validation(Required=false)]
                public long? CarOrderSourceType { get; set; }

                /// <summary>
                /// <para>The enterprise ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxxxx</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The enterprise name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX公司</para>
                /// </summary>
                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                /// <summary>
                /// <para>The department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10101010</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                /// <summary>
                /// <para>The department name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>部门A</para>
                /// </summary>
                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                /// <summary>
                /// <para>The order creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The order update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("gmt_modified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1012000000000000</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <para>The order status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                /// <summary>
                /// <para>The sub-order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public long? SubOrderId { get; set; }

                /// <summary>
                /// <para>The third-party department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thirdpart_1010101010</para>
                /// </summary>
                [NameInMap("third_depart_id")]
                [Validation(Required=false)]
                public string ThirdDepartId { get; set; }

                /// <summary>
                /// <para>The third-party approval form ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                /// <summary>
                /// <para>The external approval form ID displayed to the user.</para>
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
                /// <para>xxxxx</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <para>The booker ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxxxx</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The booker name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The passenger information list.</para>
            /// </summary>
            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<CarOrderQueryResponseBodyModulePassengerList> PassengerList { get; set; }
            public class CarOrderQueryResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <para>The cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>costId</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>costName</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The cost center code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>costNumber</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <para>The project code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>projectCode1</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>projectId</para>
                /// </summary>
                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>项目A</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <para>The third-party cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thirdpartCostId</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                /// <summary>
                /// <para>The third-party project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thirdpartProjectId</para>
                /// </summary>
                [NameInMap("thirdpart_project_id")]
                [Validation(Required=false)]
                public string ThirdpartProjectId { get; set; }

                /// <summary>
                /// <para>The DingTalk ID of the traveler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userId</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The traveler name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The traveler type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            /// <summary>
            /// <para>The car service fee information list.</para>
            /// </summary>
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<CarOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class CarOrderQueryResponseBodyModulePriceInfoList : TeaModel {
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
                /// <para>The transaction record creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669274251000</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The settlement method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The personal payment amount, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("person_price")]
                [Validation(Required=false)]
                public long? PersonPrice { get; set; }

                /// <summary>
                /// <para>The enterprise transaction amount, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <para>The order transaction serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1012000000001</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
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
