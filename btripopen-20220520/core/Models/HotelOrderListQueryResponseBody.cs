// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderListQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<HotelOrderListQueryResponseBodyModule> Module { get; set; }
        public class HotelOrderListQueryResponseBodyModule : TeaModel {
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("btrip_title")]
            [Validation(Required=false)]
            public string BtripTitle { get; set; }

            [NameInMap("check_in")]
            [Validation(Required=false)]
            public string CheckIn { get; set; }

            [NameInMap("check_out")]
            [Validation(Required=false)]
            public string CheckOut { get; set; }

            [NameInMap("city")]
            [Validation(Required=false)]
            public string City { get; set; }

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
            public HotelOrderListQueryResponseBodyModuleCostCenter CostCenter { get; set; }
            public class HotelOrderListQueryResponseBodyModuleCostCenter : TeaModel {
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("number")]
                [Validation(Required=false)]
                public string Number { get; set; }

            }

            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("guest")]
            [Validation(Required=false)]
            public string Guest { get; set; }

            [NameInMap("hotel_name")]
            [Validation(Required=false)]
            public string HotelName { get; set; }

            [NameInMap("hotel_support_vat_invoice_type")]
            [Validation(Required=false)]
            public int? HotelSupportVatInvoiceType { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("invoice")]
            [Validation(Required=false)]
            public HotelOrderListQueryResponseBodyModuleInvoice Invoice { get; set; }
            public class HotelOrderListQueryResponseBodyModuleInvoice : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("night")]
            [Validation(Required=false)]
            public int? Night { get; set; }

            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            [NameInMap("order_status_desc")]
            [Validation(Required=false)]
            public string OrderStatusDesc { get; set; }

            [NameInMap("order_type")]
            [Validation(Required=false)]
            public int? OrderType { get; set; }

            [NameInMap("order_type_desc")]
            [Validation(Required=false)]
            public string OrderTypeDesc { get; set; }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderListQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class HotelOrderListQueryResponseBodyModulePriceInfoList : TeaModel {
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

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

            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            [NameInMap("room_num")]
            [Validation(Required=false)]
            public int? RoomNum { get; set; }

            [NameInMap("room_type")]
            [Validation(Required=false)]
            public string RoomType { get; set; }

            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

            [NameInMap("thirdpart_project_id")]
            [Validation(Required=false)]
            public string ThirdpartProjectId { get; set; }

            [NameInMap("user_affiliate_list")]
            [Validation(Required=false)]
            public List<HotelOrderListQueryResponseBodyModuleUserAffiliateList> UserAffiliateList { get; set; }
            public class HotelOrderListQueryResponseBodyModuleUserAffiliateList : TeaModel {
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
        public HotelOrderListQueryResponseBodyPageInfo PageInfo { get; set; }
        public class HotelOrderListQueryResponseBodyPageInfo : TeaModel {
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
