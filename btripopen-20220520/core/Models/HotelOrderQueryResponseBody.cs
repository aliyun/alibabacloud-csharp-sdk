// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module。
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelOrderQueryResponseBodyModule Module { get; set; }
        public class HotelOrderQueryResponseBodyModule : TeaModel {
            [NameInMap("hotel_info")]
            [Validation(Required=false)]
            public HotelOrderQueryResponseBodyModuleHotelInfo HotelInfo { get; set; }
            public class HotelOrderQueryResponseBodyModuleHotelInfo : TeaModel {
                [NameInMap("check_in")]
                [Validation(Required=false)]
                public long? CheckIn { get; set; }

                [NameInMap("check_out")]
                [Validation(Required=false)]
                public long? CheckOut { get; set; }

                [NameInMap("city")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("city_ad_code")]
                [Validation(Required=false)]
                public string CityAdCode { get; set; }

                [NameInMap("hotel_address")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("hotel_phone")]
                [Validation(Required=false)]
                public string HotelPhone { get; set; }

                [NameInMap("hotel_support_vat_invoice_type")]
                [Validation(Required=false)]
                public int? HotelSupportVatInvoiceType { get; set; }

                [NameInMap("night")]
                [Validation(Required=false)]
                public int? Night { get; set; }

                [NameInMap("room_num")]
                [Validation(Required=false)]
                public int? RoomNum { get; set; }

                [NameInMap("room_type")]
                [Validation(Required=false)]
                public string RoomType { get; set; }

            }

            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public HotelOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class HotelOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public HotelOrderQueryResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class HotelOrderQueryResponseBodyModuleOrderBaseInfo : TeaModel {
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

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

                [NameInMap("exceed_apply_nos")]
                [Validation(Required=false)]
                public List<string> ExceedApplyNos { get; set; }

                [NameInMap("extend_field")]
                [Validation(Required=false)]
                public string ExtendField { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmt_modified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("order_type")]
                [Validation(Required=false)]
                public int? OrderType { get; set; }

                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("thirdpart_business_id")]
                [Validation(Required=false)]
                public string ThirdpartBusinessId { get; set; }

                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

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
            public List<HotelOrderQueryResponseBodyModulePassengerList> PassengerList { get; set; }
            public class HotelOrderQueryResponseBodyModulePassengerList : TeaModel {
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("occupant_type")]
                [Validation(Required=false)]
                public int? OccupantType { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

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
            public List<HotelOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class HotelOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

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
