// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOrderDetailResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightOrderDetailResponseBodyModule Module { get; set; }
        public class IntlFlightOrderDetailResponseBodyModule : TeaModel {
            [NameInMap("book_user_id")]
            [Validation(Required=false)]
            public string BookUserId { get; set; }

            [NameInMap("book_user_name")]
            [Validation(Required=false)]
            public string BookUserName { get; set; }

            [NameInMap("close_reason")]
            [Validation(Required=false)]
            public string CloseReason { get; set; }

            [NameInMap("close_time")]
            [Validation(Required=false)]
            public long? CloseTime { get; set; }

            [NameInMap("close_time_str")]
            [Validation(Required=false)]
            public string CloseTimeStr { get; set; }

            [NameInMap("contact_info")]
            [Validation(Required=false)]
            public IntlFlightOrderDetailResponseBodyModuleContactInfo ContactInfo { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleContactInfo : TeaModel {
                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                [NameInMap("send_msg_to_passenger")]
                [Validation(Required=false)]
                public bool? SendMsgToPassenger { get; set; }

            }

            [NameInMap("create_time")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("create_time_str")]
            [Validation(Required=false)]
            public string CreateTimeStr { get; set; }

            [NameInMap("ext_info_map")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtInfoMap { get; set; }

            [NameInMap("journey_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModuleJourneyList> JourneyList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleJourneyList : TeaModel {
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentList> SegmentList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentList : TeaModel {
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

                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("code_share")]
                    [Validation(Required=false)]
                    public bool? CodeShare { get; set; }

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

                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_other_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListFlightOtherInfo FlightOtherInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListFlightOtherInfo : TeaModel {
                        [NameInMap("aircraft_age")]
                        [Validation(Required=false)]
                        public string AircraftAge { get; set; }

                        [NameInMap("avg_delay_time")]
                        [Validation(Required=false)]
                        public string AvgDelayTime { get; set; }

                        [NameInMap("equip_type")]
                        [Validation(Required=false)]
                        public string EquipType { get; set; }

                        [NameInMap("flight_cancel_rate")]
                        [Validation(Required=false)]
                        public string FlightCancelRate { get; set; }

                        [NameInMap("flight_distance")]
                        [Validation(Required=false)]
                        public int? FlightDistance { get; set; }

                        [NameInMap("flight_duration")]
                        [Validation(Required=false)]
                        public int? FlightDuration { get; set; }

                        [NameInMap("flight_size")]
                        [Validation(Required=false)]
                        public string FlightSize { get; set; }

                        [NameInMap("jet_bridge_rate")]
                        [Validation(Required=false)]
                        public string JetBridgeRate { get; set; }

                        [NameInMap("manufacturer")]
                        [Validation(Required=false)]
                        public string Manufacturer { get; set; }

                        [NameInMap("meal")]
                        [Validation(Required=false)]
                        public int? Meal { get; set; }

                        [NameInMap("meal_desc")]
                        [Validation(Required=false)]
                        public string MealDesc { get; set; }

                        [NameInMap("on_time_rate")]
                        [Validation(Required=false)]
                        public string OnTimeRate { get; set; }

                        [NameInMap("wifi")]
                        [Validation(Required=false)]
                        public bool? Wifi { get; set; }

                    }

                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("luggage_direct_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListLuggageDirectInfo LuggageDirectInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListLuggageDirectInfo : TeaModel {
                        [NameInMap("dep_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? DepCityLuggageDirect { get; set; }

                        [NameInMap("stop_city_luggage_direct")]
                        [Validation(Required=false)]
                        public int? StopCityLuggageDirect { get; set; }

                    }

                    [NameInMap("marketing_airline")]
                    [Validation(Required=false)]
                    public string MarketingAirline { get; set; }

                    [NameInMap("marketing_airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListMarketingAirlineInfo MarketingAirlineInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListMarketingAirlineInfo : TeaModel {
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_name")]
                        [Validation(Required=false)]
                        public string AirlineName { get; set; }

                        [NameInMap("alliance_name")]
                        [Validation(Required=false)]
                        public string AllianceName { get; set; }

                        [NameInMap("cheap_airline")]
                        [Validation(Required=false)]
                        public bool? CheapAirline { get; set; }

                        [NameInMap("icon_url")]
                        [Validation(Required=false)]
                        public string IconUrl { get; set; }

                        [NameInMap("logo_url")]
                        [Validation(Required=false)]
                        public string LogoUrl { get; set; }

                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    [NameInMap("marketing_flight_no")]
                    [Validation(Required=false)]
                    public string MarketingFlightNo { get; set; }

                    [NameInMap("operating_airline")]
                    [Validation(Required=false)]
                    public string OperatingAirline { get; set; }

                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListOperatingAirlineInfo : TeaModel {
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        [NameInMap("airline_name")]
                        [Validation(Required=false)]
                        public string AirlineName { get; set; }

                        [NameInMap("alliance_name")]
                        [Validation(Required=false)]
                        public string AllianceName { get; set; }

                        [NameInMap("cheap_airline")]
                        [Validation(Required=false)]
                        public bool? CheapAirline { get; set; }

                        [NameInMap("icon_url")]
                        [Validation(Required=false)]
                        public string IconUrl { get; set; }

                        [NameInMap("logo_url")]
                        [Validation(Required=false)]
                        public string LogoUrl { get; set; }

                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    [NameInMap("segment_visa_remark")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListSegmentVisaRemark SegmentVisaRemark { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListSegmentVisaRemark : TeaModel {
                        [NameInMap("dep_city_visa_remark")]
                        [Validation(Required=false)]
                        public string DepCityVisaRemark { get; set; }

                        [NameInMap("dep_city_visa_type")]
                        [Validation(Required=false)]
                        public int? DepCityVisaType { get; set; }

                        [NameInMap("stop_city_visa_remarks")]
                        [Validation(Required=false)]
                        public List<string> StopCityVisaRemarks { get; set; }

                        [NameInMap("stop_city_visa_types")]
                        [Validation(Required=false)]
                        public List<int?> StopCityVisaTypes { get; set; }

                    }

                    [NameInMap("stop_city_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListStopCityList> StopCityList { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModuleJourneyListSegmentListStopCityList : TeaModel {
                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        [NameInMap("stop_airport_name")]
                        [Validation(Required=false)]
                        public string StopAirportName { get; set; }

                        [NameInMap("stop_arr_terminal")]
                        [Validation(Required=false)]
                        public string StopArrTerminal { get; set; }

                        [NameInMap("stop_arr_time")]
                        [Validation(Required=false)]
                        public string StopArrTime { get; set; }

                        [NameInMap("stop_city_code")]
                        [Validation(Required=false)]
                        public string StopCityCode { get; set; }

                        [NameInMap("stop_city_name")]
                        [Validation(Required=false)]
                        public string StopCityName { get; set; }

                        [NameInMap("stop_dep_terminal")]
                        [Validation(Required=false)]
                        public string StopDepTerminal { get; set; }

                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                    }

                    [NameInMap("stop_quantity")]
                    [Validation(Required=false)]
                    public int? StopQuantity { get; set; }

                }

                [NameInMap("transfer_count")]
                [Validation(Required=false)]
                public int? TransferCount { get; set; }

                [NameInMap("transfer_time")]
                [Validation(Required=false)]
                public int? TransferTime { get; set; }

            }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("order_item_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModuleOrderItemList> OrderItemList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModuleOrderItemList : TeaModel {
                [NameInMap("baggage_rule")]
                [Validation(Required=false)]
                public IntlFlightOrderDetailResponseBodyModuleOrderItemListBaggageRule BaggageRule { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleOrderItemListBaggageRule : TeaModel {
                    [NameInMap("baggage_digest")]
                    [Validation(Required=false)]
                    public string BaggageDigest { get; set; }

                    [NameInMap("baggage_info_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleOrderItemListBaggageRuleBaggageInfoMapValue>> BaggageInfoMap { get; set; }

                    [NameInMap("structured_baggage")]
                    [Validation(Required=false)]
                    public bool? StructuredBaggage { get; set; }

                }

                [NameInMap("passenger_price_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModuleOrderItemListPassengerPriceList> PassengerPriceList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleOrderItemListPassengerPriceList : TeaModel {
                    [NameInMap("discount")]
                    [Validation(Required=false)]
                    public double? Discount { get; set; }

                    [NameInMap("discount_info")]
                    [Validation(Required=false)]
                    public string DiscountInfo { get; set; }

                    [NameInMap("modify_fee")]
                    [Validation(Required=false)]
                    public long? ModifyFee { get; set; }

                    [NameInMap("modify_tax_spread")]
                    [Validation(Required=false)]
                    public long? ModifyTaxSpread { get; set; }

                    [NameInMap("passenger_type")]
                    [Validation(Required=false)]
                    public int? PassengerType { get; set; }

                    [NameInMap("sell_price")]
                    [Validation(Required=false)]
                    public long? SellPrice { get; set; }

                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public long? Tax { get; set; }

                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public long? UpgradeFee { get; set; }

                }

                [NameInMap("refund_change_rule")]
                [Validation(Required=false)]
                public IntlFlightOrderDetailResponseBodyModuleOrderItemListRefundChangeRule RefundChangeRule { get; set; }
                public class IntlFlightOrderDetailResponseBodyModuleOrderItemListRefundChangeRule : TeaModel {
                    [NameInMap("cancel_fee_ind")]
                    [Validation(Required=false)]
                    public bool? CancelFeeInd { get; set; }

                    [NameInMap("change_fee_ind")]
                    [Validation(Required=false)]
                    public bool? ChangeFeeInd { get; set; }

                    [NameInMap("offer_penalty_info_map")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<ModuleOrderItemListRefundChangeRuleOfferPenaltyInfoMapValue>> OfferPenaltyInfoMap { get; set; }

                    [NameInMap("refund_change_digest")]
                    [Validation(Required=false)]
                    public string RefundChangeDigest { get; set; }

                    [NameInMap("structured_refund")]
                    [Validation(Required=false)]
                    public bool? StructuredRefund { get; set; }

                }

                [NameInMap("segment_key_list")]
                [Validation(Required=false)]
                public List<string> SegmentKeyList { get; set; }

            }

            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            [NameInMap("passenger_item_detail_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModulePassengerItemDetailList> PassengerItemDetailList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModulePassengerItemDetailList : TeaModel {
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                [NameInMap("ticket_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketList> TicketList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketList : TeaModel {
                    [NameInMap("issue_time")]
                    [Validation(Required=false)]
                    public string IssueTime { get; set; }

                    [NameInMap("price_info")]
                    [Validation(Required=false)]
                    public IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketListPriceInfo PriceInfo { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketListPriceInfo : TeaModel {
                        [NameInMap("modify_fee")]
                        [Validation(Required=false)]
                        public long? ModifyFee { get; set; }

                        [NameInMap("modify_tax_spread")]
                        [Validation(Required=false)]
                        public long? ModifyTaxSpread { get; set; }

                        [NameInMap("sell_price")]
                        [Validation(Required=false)]
                        public long? SellPrice { get; set; }

                        [NameInMap("tax")]
                        [Validation(Required=false)]
                        public long? Tax { get; set; }

                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public long? TicketPrice { get; set; }

                        [NameInMap("upgrade_fee")]
                        [Validation(Required=false)]
                        public long? UpgradeFee { get; set; }

                    }

                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    [NameInMap("ticket_segment_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketListTicketSegmentList> TicketSegmentList { get; set; }
                    public class IntlFlightOrderDetailResponseBodyModulePassengerItemDetailListTicketListTicketSegmentList : TeaModel {
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        [NameInMap("modified")]
                        [Validation(Required=false)]
                        public bool? Modified { get; set; }

                        [NameInMap("open_ticket_status")]
                        [Validation(Required=false)]
                        public string OpenTicketStatus { get; set; }

                        [NameInMap("refunded")]
                        [Validation(Required=false)]
                        public bool? Refunded { get; set; }

                        [NameInMap("segment_key")]
                        [Validation(Required=false)]
                        public string SegmentKey { get; set; }

                    }

                }

            }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<IntlFlightOrderDetailResponseBodyModulePassengerList> PassengerList { get; set; }
            public class IntlFlightOrderDetailResponseBodyModulePassengerList : TeaModel {
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                [NameInMap("cascade_dept_mask")]
                [Validation(Required=false)]
                public string CascadeDeptMask { get; set; }

                [NameInMap("cascade_dept_name")]
                [Validation(Required=false)]
                public string CascadeDeptName { get; set; }

                [NameInMap("cert_info")]
                [Validation(Required=false)]
                public IntlFlightOrderDetailResponseBodyModulePassengerListCertInfo CertInfo { get; set; }
                public class IntlFlightOrderDetailResponseBodyModulePassengerListCertInfo : TeaModel {
                    [NameInMap("cert_nation")]
                    [Validation(Required=false)]
                    public string CertNation { get; set; }

                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public int? CertType { get; set; }

                    [NameInMap("cert_valid_date")]
                    [Validation(Required=false)]
                    public string CertValidDate { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                [NameInMap("dept_id")]
                [Validation(Required=false)]
                public string DeptId { get; set; }

                [NameInMap("dept_name")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                [NameInMap("invoice_id")]
                [Validation(Required=false)]
                public string InvoiceId { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                [NameInMap("nationality_code")]
                [Validation(Required=false)]
                public string NationalityCode { get; set; }

                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public int? PassengerType { get; set; }

                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("subsidiary_cert_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightOrderDetailResponseBodyModulePassengerListSubsidiaryCertInfoList> SubsidiaryCertInfoList { get; set; }
                public class IntlFlightOrderDetailResponseBodyModulePassengerListSubsidiaryCertInfoList : TeaModel {
                    [NameInMap("cert_nation")]
                    [Validation(Required=false)]
                    public string CertNation { get; set; }

                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public int? CertType { get; set; }

                    [NameInMap("cert_valid_date")]
                    [Validation(Required=false)]
                    public string CertValidDate { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("pay_expire_time")]
            [Validation(Required=false)]
            public long? PayExpireTime { get; set; }

            [NameInMap("pay_expire_time_str")]
            [Validation(Required=false)]
            public string PayExpireTimeStr { get; set; }

            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            [NameInMap("pay_time_str")]
            [Validation(Required=false)]
            public string PayTimeStr { get; set; }

            [NameInMap("pay_type")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("succeed_time")]
            [Validation(Required=false)]
            public long? SucceedTime { get; set; }

            [NameInMap("succeed_time_str")]
            [Validation(Required=false)]
            public string SucceedTimeStr { get; set; }

            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

        }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("trace_id")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
