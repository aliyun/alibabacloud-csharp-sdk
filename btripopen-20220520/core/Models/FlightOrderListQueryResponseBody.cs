// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<FlightOrderListQueryResponseBodyModule> Module { get; set; }
        public class FlightOrderListQueryResponseBodyModule : TeaModel {
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("arr_airport")]
            [Validation(Required=false)]
            public string ArrAirport { get; set; }

            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            [NameInMap("btrip_title")]
            [Validation(Required=false)]
            public string BtripTitle { get; set; }

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

            [NameInMap("dep_airport")]
            [Validation(Required=false)]
            public string DepAirport { get; set; }

            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            [NameInMap("discount")]
            [Validation(Required=false)]
            public string Discount { get; set; }

            [NameInMap("flight_no")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("insure_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryResponseBodyModuleInsureInfoList> InsureInfoList { get; set; }
            public class FlightOrderListQueryResponseBodyModuleInsureInfoList : TeaModel {
                [NameInMap("insure_no")]
                [Validation(Required=false)]
                public string InsureNo { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("invoice")]
            [Validation(Required=false)]
            public FlightOrderListQueryResponseBodyModuleInvoice Invoice { get; set; }
            public class FlightOrderListQueryResponseBodyModuleInvoice : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

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
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                [NameInMap("change_flight_no")]
                [Validation(Required=false)]
                public string ChangeFlightNo { get; set; }

                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                [NameInMap("end_time")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("original_ticket_no")]
                [Validation(Required=false)]
                public string OriginalTicketNo { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                [NameInMap("start_time")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

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

            [NameInMap("ret_date")]
            [Validation(Required=false)]
            public string RetDate { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("third_part_project_id")]
            [Validation(Required=false)]
            public string ThirdPartProjectId { get; set; }

            [NameInMap("thirdpart_apply_id")]
            [Validation(Required=false)]
            public string ThirdpartApplyId { get; set; }

            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

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

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
