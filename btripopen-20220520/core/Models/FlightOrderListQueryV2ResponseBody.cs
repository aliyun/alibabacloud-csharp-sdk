// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryV2ResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<FlightOrderListQueryV2ResponseBodyModule> Module { get; set; }
        public class FlightOrderListQueryV2ResponseBodyModule : TeaModel {
            [NameInMap("approve")]
            [Validation(Required=false)]
            public FlightOrderListQueryV2ResponseBodyModuleApprove Approve { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleApprove : TeaModel {
                [NameInMap("approve_id")]
                [Validation(Required=false)]
                public long? ApproveId { get; set; }

                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                [NameInMap("exceed_approve_id")]
                [Validation(Required=false)]
                public string ExceedApproveId { get; set; }

                [NameInMap("thirdpart_approve_id")]
                [Validation(Required=false)]
                public string ThirdpartApproveId { get; set; }

                [NameInMap("thirdpart_exceed_approve_id")]
                [Validation(Required=false)]
                public string ThirdpartExceedApproveId { get; set; }

            }

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

            [NameInMap("flight_order_ticket_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightOrderTicketList> FlightOrderTicketList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightOrderTicketList : TeaModel {
                [NameInMap("flight_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightOrderTicketListFlightList> FlightList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightOrderTicketListFlightList : TeaModel {
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("cabin_class_name")]
                    [Validation(Required=false)]
                    public string CabinClassName { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                }

                [NameInMap("ticket_no_list")]
                [Validation(Required=false)]
                public List<string> TicketNoList { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("flight_order_user_fee_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightOrderUserFeeList> FlightOrderUserFeeList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightOrderUserFeeList : TeaModel {
                [NameInMap("build_fee")]
                [Validation(Required=false)]
                public double? BuildFee { get; set; }

                [NameInMap("corp_pay_amount")]
                [Validation(Required=false)]
                public double? CorpPayAmount { get; set; }

                [NameInMap("oil_fee")]
                [Validation(Required=false)]
                public double? OilFee { get; set; }

                [NameInMap("person_pay_amount")]
                [Validation(Required=false)]
                public double? PersonPayAmount { get; set; }

                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("flight_refund_apply_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyList> FlightRefundApplyList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyList : TeaModel {
                [NameInMap("flight_refund_apply_ticket_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundApplyTicketList> FlightRefundApplyTicketList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundApplyTicketList : TeaModel {
                    [NameInMap("flight_list")]
                    [Validation(Required=false)]
                    public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundApplyTicketListFlightList> FlightList { get; set; }
                    public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundApplyTicketListFlightList : TeaModel {
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        [NameInMap("cabin_class_name")]
                        [Validation(Required=false)]
                        public string CabinClassName { get; set; }

                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    [NameInMap("ticket_no_list")]
                    [Validation(Required=false)]
                    public List<string> TicketNoList { get; set; }

                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("flight_refund_segment_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundSegmentList> FlightRefundSegmentList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundSegmentList : TeaModel {
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_mile")]
                    [Validation(Required=false)]
                    public int? FlightMile { get; set; }

                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public List<string> StopCity { get; set; }

                }

                [NameInMap("flight_refund_user_fee_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundUserFeeList> FlightRefundUserFeeList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundUserFeeList : TeaModel {
                    [NameInMap("already_use_amount")]
                    [Validation(Required=false)]
                    public double? AlreadyUseAmount { get; set; }

                    [NameInMap("non_refundable_reshop_change_amount")]
                    [Validation(Required=false)]
                    public double? NonRefundableReshopChangeAmount { get; set; }

                    [NameInMap("non_refundable_reshop_upgrade_amount")]
                    [Validation(Required=false)]
                    public double? NonRefundableReshopUpgradeAmount { get; set; }

                    [NameInMap("refund_amount")]
                    [Validation(Required=false)]
                    public double? RefundAmount { get; set; }

                    [NameInMap("refund_corp_amount")]
                    [Validation(Required=false)]
                    public double? RefundCorpAmount { get; set; }

                    [NameInMap("refund_hand_fee")]
                    [Validation(Required=false)]
                    public double? RefundHandFee { get; set; }

                    [NameInMap("refund_person_amount")]
                    [Validation(Required=false)]
                    public double? RefundPersonAmount { get; set; }

                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public string RefundApplyId { get; set; }

                [NameInMap("refund_approve_id")]
                [Validation(Required=false)]
                public string RefundApproveId { get; set; }

                [NameInMap("refund_corp_total_amount")]
                [Validation(Required=false)]
                public double? RefundCorpTotalAmount { get; set; }

                [NameInMap("refund_hand_fee")]
                [Validation(Required=false)]
                public double? RefundHandFee { get; set; }

                [NameInMap("refund_person_total_amount")]
                [Validation(Required=false)]
                public double? RefundPersonTotalAmount { get; set; }

                [NameInMap("refund_reason")]
                [Validation(Required=false)]
                public string RefundReason { get; set; }

                [NameInMap("refund_reason_code")]
                [Validation(Required=false)]
                public string RefundReasonCode { get; set; }

                [NameInMap("refund_total_amount")]
                [Validation(Required=false)]
                public double? RefundTotalAmount { get; set; }

                [NameInMap("relate_refund_apply_id")]
                [Validation(Required=false)]
                public string RelateRefundApplyId { get; set; }

                [NameInMap("user_id_list")]
                [Validation(Required=false)]
                public List<string> UserIdList { get; set; }

            }

            [NameInMap("flight_reshop_apply_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyList> FlightReshopApplyList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyList : TeaModel {
                [NameInMap("flight_reshop_apply_ticket_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopApplyTicketList> FlightReshopApplyTicketList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopApplyTicketList : TeaModel {
                    [NameInMap("flight_list")]
                    [Validation(Required=false)]
                    public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopApplyTicketListFlightList> FlightList { get; set; }
                    public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopApplyTicketListFlightList : TeaModel {
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        [NameInMap("cabin_class_name")]
                        [Validation(Required=false)]
                        public string CabinClassName { get; set; }

                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    [NameInMap("relate_ticket_no_list")]
                    [Validation(Required=false)]
                    public List<string> RelateTicketNoList { get; set; }

                    [NameInMap("ticket_no_list")]
                    [Validation(Required=false)]
                    public List<string> TicketNoList { get; set; }

                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("flight_reshop_segment_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopSegmentList> FlightReshopSegmentList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopSegmentList : TeaModel {
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_mile")]
                    [Validation(Required=false)]
                    public int? FlightMile { get; set; }

                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public List<string> StopCity { get; set; }

                }

                [NameInMap("flight_reshop_user_fee_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopUserFeeList> FlightReshopUserFeeList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopUserFeeList : TeaModel {
                    [NameInMap("change_fee")]
                    [Validation(Required=false)]
                    public double? ChangeFee { get; set; }

                    [NameInMap("reshop_corp_amount")]
                    [Validation(Required=false)]
                    public double? ReshopCorpAmount { get; set; }

                    [NameInMap("reshop_person_amount")]
                    [Validation(Required=false)]
                    public double? ReshopPersonAmount { get; set; }

                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public double? UpgradeFee { get; set; }

                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("relate_reshop_apply_id")]
                [Validation(Required=false)]
                public long? RelateReshopApplyId { get; set; }

                [NameInMap("reshop_apply_id")]
                [Validation(Required=false)]
                public long? ReshopApplyId { get; set; }

                [NameInMap("reshop_approve_id")]
                [Validation(Required=false)]
                public string ReshopApproveId { get; set; }

                [NameInMap("reshop_corp_total_amount")]
                [Validation(Required=false)]
                public double? ReshopCorpTotalAmount { get; set; }

                [NameInMap("reshop_person_total_amount")]
                [Validation(Required=false)]
                public double? ReshopPersonTotalAmount { get; set; }

                [NameInMap("reshop_reason")]
                [Validation(Required=false)]
                public string ReshopReason { get; set; }

                [NameInMap("reshop_reason_code")]
                [Validation(Required=false)]
                public string ReshopReasonCode { get; set; }

                [NameInMap("reshop_total_amount")]
                [Validation(Required=false)]
                public double? ReshopTotalAmount { get; set; }

                [NameInMap("user_id_list")]
                [Validation(Required=false)]
                public List<string> UserIdList { get; set; }

            }

            [NameInMap("flight_segment_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightSegmentList> FlightSegmentList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightSegmentList : TeaModel {
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                [NameInMap("arr_apt")]
                [Validation(Required=false)]
                public string ArrApt { get; set; }

                [NameInMap("arr_apt_code")]
                [Validation(Required=false)]
                public string ArrAptCode { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("dep_apt")]
                [Validation(Required=false)]
                public string DepApt { get; set; }

                [NameInMap("dep_apt_code")]
                [Validation(Required=false)]
                public string DepAptCode { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("flight_mile")]
                [Validation(Required=false)]
                public int? FlightMile { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public List<string> StopCity { get; set; }

            }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("insure_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleInsureInfoList> InsureInfoList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleInsureInfoList : TeaModel {
                [NameInMap("insure_id")]
                [Validation(Required=false)]
                public string InsureId { get; set; }

                [NameInMap("insure_order_amount")]
                [Validation(Required=false)]
                public double? InsureOrderAmount { get; set; }

                [NameInMap("insure_price")]
                [Validation(Required=false)]
                public double? InsurePrice { get; set; }

                [NameInMap("insure_type")]
                [Validation(Required=false)]
                public string InsureType { get; set; }

                [NameInMap("name_list")]
                [Validation(Required=false)]
                public List<string> NameList { get; set; }

                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("mix_pay")]
            [Validation(Required=false)]
            public bool? MixPay { get; set; }

            [NameInMap("order_reserve_amount")]
            [Validation(Required=false)]
            public double? OrderReserveAmount { get; set; }

            [NameInMap("passenger_count")]
            [Validation(Required=false)]
            public int? PassengerCount { get; set; }

            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModulePriceInfoList : TeaModel {
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("supplier")]
            [Validation(Required=false)]
            public string Supplier { get; set; }

            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public List<string> ThirdpartItineraryId { get; set; }

            [NameInMap("ticket_corp_reserve_amount")]
            [Validation(Required=false)]
            public double? TicketCorpReserveAmount { get; set; }

            [NameInMap("ticket_person_reserve_amount")]
            [Validation(Required=false)]
            public double? TicketPersonReserveAmount { get; set; }

            [NameInMap("trip_mode")]
            [Validation(Required=false)]
            public int? TripMode { get; set; }

            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

            [NameInMap("user_affiliate_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleUserAffiliateList> UserAffiliateList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateList : TeaModel {
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListCostCenter CostCenter { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListCostCenter : TeaModel {
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

                [NameInMap("department")]
                [Validation(Required=false)]
                public FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListDepartment Department { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListDepartment : TeaModel {
                    [NameInMap("depart_id")]
                    [Validation(Required=false)]
                    public string DepartId { get; set; }

                    [NameInMap("depart_name")]
                    [Validation(Required=false)]
                    public string DepartName { get; set; }

                }

                [NameInMap("invoice")]
                [Validation(Required=false)]
                public FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListInvoice Invoice { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListInvoice : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("project")]
                [Validation(Required=false)]
                public FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListProject Project { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListProject : TeaModel {
                    [NameInMap("project_id")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    [NameInMap("project_title")]
                    [Validation(Required=false)]
                    public string ProjectTitle { get; set; }

                    [NameInMap("thirdpart_project_id")]
                    [Validation(Required=false)]
                    public string ThirdpartProjectId { get; set; }

                }

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

        [NameInMap("pageInfo")]
        [Validation(Required=false)]
        public FlightOrderListQueryV2ResponseBodyPageInfo PageInfo { get; set; }
        public class FlightOrderListQueryV2ResponseBodyPageInfo : TeaModel {
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            [NameInMap("scroll_id")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

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
