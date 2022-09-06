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
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("change_cabin")]
                [Validation(Required=false)]
                public string ChangeCabin { get; set; }

                [NameInMap("change_cabin_level")]
                [Validation(Required=false)]
                public string ChangeCabinLevel { get; set; }

                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                [NameInMap("change_flight_no")]
                [Validation(Required=false)]
                public string ChangeFlightNo { get; set; }

                [NameInMap("change_order_id")]
                [Validation(Required=false)]
                public long? ChangeOrderId { get; set; }

                [NameInMap("change_reason")]
                [Validation(Required=false)]
                public string ChangeReason { get; set; }

                [NameInMap("change_type")]
                [Validation(Required=false)]
                public int? ChangeType { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("origin_ticket_no")]
                [Validation(Required=false)]
                public string OriginTicketNo { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("upgrade_fee")]
                [Validation(Required=false)]
                public double? UpgradeFee { get; set; }

            }

            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightInfoList : TeaModel {
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                [NameInMap("cabin_level")]
                [Validation(Required=false)]
                public string CabinLevel { get; set; }

                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("flight_mile")]
                [Validation(Required=false)]
                public int? FlightMile { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

            }

            [NameInMap("flight_refund_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightRefundTicketInfoList> FlightRefundTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightRefundTicketInfoList : TeaModel {
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("refund_order_id")]
                [Validation(Required=false)]
                public long? RefundOrderId { get; set; }

                [NameInMap("refund_reason")]
                [Validation(Required=false)]
                public string RefundReason { get; set; }

                [NameInMap("refund_ticket_fee")]
                [Validation(Required=false)]
                public double? RefundTicketFee { get; set; }

                [NameInMap("refund_type")]
                [Validation(Required=false)]
                public int? RefundType { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            [NameInMap("flight_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightTicketInfoList> FlightTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightTicketInfoList : TeaModel {
                [NameInMap("build_price")]
                [Validation(Required=false)]
                public double? BuildPrice { get; set; }

                [NameInMap("changed")]
                [Validation(Required=false)]
                public bool? Changed { get; set; }

                [NameInMap("discount")]
                [Validation(Required=false)]
                public int? Discount { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public double? OilPrice { get; set; }

                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("settle_price")]
                [Validation(Required=false)]
                public double? SettlePrice { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public string TicketStatus { get; set; }

                [NameInMap("ticket_status_code")]
                [Validation(Required=false)]
                public int? TicketStatusCode { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("insurance_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleInsuranceInfoList> InsuranceInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleInsuranceInfoList : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                [NameInMap("insurance_no")]
                [Validation(Required=false)]
                public string InsuranceNo { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
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
            public List<FlightOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

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
