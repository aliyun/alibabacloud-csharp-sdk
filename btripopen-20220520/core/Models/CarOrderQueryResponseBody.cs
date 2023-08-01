// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarOrderQueryResponseBody : TeaModel {
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
                [NameInMap("business_category")]
                [Validation(Required=false)]
                public string BusinessCategory { get; set; }

                [NameInMap("cancel_time")]
                [Validation(Required=false)]
                public long? CancelTime { get; set; }

                [NameInMap("car_info")]
                [Validation(Required=false)]
                public string CarInfo { get; set; }

                [NameInMap("car_level")]
                [Validation(Required=false)]
                public int? CarLevel { get; set; }

                [NameInMap("driver_card")]
                [Validation(Required=false)]
                public string DriverCard { get; set; }

                [NameInMap("driver_confirm_time")]
                [Validation(Required=false)]
                public long? DriverConfirmTime { get; set; }

                [NameInMap("driver_name")]
                [Validation(Required=false)]
                public string DriverName { get; set; }

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

                [NameInMap("is_special")]
                [Validation(Required=false)]
                public bool? IsSpecial { get; set; }

                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public long? PayTime { get; set; }

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

                [NameInMap("service_type")]
                [Validation(Required=false)]
                public int? ServiceType { get; set; }

                [NameInMap("special_types")]
                [Validation(Required=false)]
                public string SpecialTypes { get; set; }

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

                [NameInMap("travel_distance")]
                [Validation(Required=false)]
                public string TravelDistance { get; set; }

            }

            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public CarOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class CarOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public CarOrderQueryResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class CarOrderQueryResponseBodyModuleOrderBaseInfo : TeaModel {
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("btrip_cause")]
                [Validation(Required=false)]
                public string BtripCause { get; set; }

                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmt_modified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public long? SubOrderId { get; set; }

                [NameInMap("third_depart_id")]
                [Validation(Required=false)]
                public string ThirdDepartId { get; set; }

                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

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
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                [NameInMap("thirdpart_project_id")]
                [Validation(Required=false)]
                public string ThirdpartProjectId { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<CarOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class CarOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("person_price")]
                [Validation(Required=false)]
                public long? PersonPrice { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
