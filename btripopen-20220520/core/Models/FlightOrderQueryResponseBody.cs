// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderQueryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightOrderQueryResponseBodyModule Module { get; set; }
        public class FlightOrderQueryResponseBodyModule : TeaModel {
            [NameInMap("flight_change_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightChangeTicketInfoList> FlightChangeTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightChangeTicketInfoList : TeaModel {
                public string ArrTime { get; set; }
                public string ChangeCabin { get; set; }
                public string ChangeCabinLevel { get; set; }
                public double? ChangeFee { get; set; }
                public string ChangeFlightNo { get; set; }
                public long? ChangeOrderId { get; set; }
                public string ChangeReason { get; set; }
                public int? ChangeType { get; set; }
                public string DepTime { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public string OriginTicketNo { get; set; }
                public string TicketNo { get; set; }
                public double? UpgradeFee { get; set; }
            }
            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightInfoList : TeaModel {
                public string AirlineCode { get; set; }
                public string AirlineName { get; set; }
                public string ArrAirportCode { get; set; }
                public string ArrAirportName { get; set; }
                public string ArrCityCode { get; set; }
                public string ArrCityName { get; set; }
                public string ArrTime { get; set; }
                public string Cabin { get; set; }
                public string CabinLevel { get; set; }
                public string DepAirportCode { get; set; }
                public string DepAirportName { get; set; }
                public string DepCityCode { get; set; }
                public string DepCityName { get; set; }
                public string DepTime { get; set; }
                public int? FlightMile { get; set; }
                public string FlightNo { get; set; }
            }
            [NameInMap("flight_refund_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightRefundTicketInfoList> FlightRefundTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightRefundTicketInfoList : TeaModel {
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public long? RefundOrderId { get; set; }
                public string RefundReason { get; set; }
                public double? RefundTicketFee { get; set; }
                public int? RefundType { get; set; }
                public string TicketNo { get; set; }
            }
            [NameInMap("flight_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightTicketInfoList> FlightTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightTicketInfoList : TeaModel {
                public double? BuildPrice { get; set; }
                public bool? Changed { get; set; }
                public int? Discount { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public double? OilPrice { get; set; }
                public int? PayType { get; set; }
                public double? SettlePrice { get; set; }
                public string TicketNo { get; set; }
                public double? TicketPrice { get; set; }
                public string TicketStatus { get; set; }
                public int? TicketStatusCode { get; set; }
                public string UserId { get; set; }
            }
            [NameInMap("insurance_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleInsuranceInfoList> InsuranceInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleInsuranceInfoList : TeaModel {
                public double? Amount { get; set; }
                public string InsuranceNo { get; set; }
                public int? Status { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public FlightOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class FlightOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }
            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public FlightOrderQueryResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class FlightOrderQueryResponseBodyModuleOrderBaseInfo : TeaModel {
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

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
                public string GmtCreate { get; set; }

                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("thirdpart_corp_id")]
                [Validation(Required=false)]
                public string ThirdpartCorpId { get; set; }

                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }
            [NameInMap("passenger_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModulePassengerInfoList> PassengerInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModulePassengerInfoList : TeaModel {
                public long? CostCenterId { get; set; }
                public string CostCenterName { get; set; }
                public string CostCenterNumber { get; set; }
                public string ProjectCode { get; set; }
                public long? ProjectId { get; set; }
                public string ProjectTitle { get; set; }
                public string ThirdpartProjectId { get; set; }
                public string UserId { get; set; }
                public string UserName { get; set; }
                public int? UserType { get; set; }
            }
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                public int? CategoryCode { get; set; }
                public string GmtCreate { get; set; }
                public string PassengerName { get; set; }
                public int? PayType { get; set; }
                public double? Price { get; set; }
                public string TradeId { get; set; }
                public int? Type { get; set; }
            }
        };

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
