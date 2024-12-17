// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>test1234</para>
                /// </summary>
                [NameInMap("approve_id")]
                [Validation(Required=false)]
                public long? ApproveId { get; set; }

                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1233544</para>
                /// </summary>
                [NameInMap("exceed_approve_id")]
                [Validation(Required=false)]
                public string ExceedApproveId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100231431</para>
                /// </summary>
                [NameInMap("thirdpart_approve_id")]
                [Validation(Required=false)]
                public string ThirdpartApproveId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>V</para>
                    /// </summary>
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Y</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("cabin_class_name")]
                    [Validation(Required=false)]
                    public string CabinClassName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA8572</para>
                    /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2022-07-20T10:40Z</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        [NameInMap("cabin_class_name")]
                        [Validation(Required=false)]
                        public string CabinClassName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2022-07-20T10:40Z</para>
                        /// </summary>
                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>HU7052</para>
                        /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CZ</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PKX</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_mile")]
                    [Validation(Required=false)]
                    public int? FlightMile { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU5619</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>232213</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public string RefundApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024122312</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("refund_reason_code")]
                [Validation(Required=false)]
                public string RefundReasonCode { get; set; }

                [NameInMap("refund_total_amount")]
                [Validation(Required=false)]
                public double? RefundTotalAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>232218</para>
                /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2022-07-20T10:40Z</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        [NameInMap("cabin_class_name")]
                        [Validation(Required=false)]
                        public string CabinClassName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2022-07-20T10:40Z</para>
                        /// </summary>
                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MU1398</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>alitrip123</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("flight_reshop_segment_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopSegmentList> FlightReshopSegmentList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopSegmentList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PEX</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_mile")]
                    [Validation(Required=false)]
                    public int? FlightMile { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA3358</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>alitrip123</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100231231</para>
                /// </summary>
                [NameInMap("relate_reshop_apply_id")]
                [Validation(Required=false)]
                public long? RelateReshopApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123232323</para>
                /// </summary>
                [NameInMap("reshop_apply_id")]
                [Validation(Required=false)]
                public long? ReshopApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>122312</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1002</para>
                /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>CZ</para>
                /// </summary>
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                [NameInMap("arr_apt")]
                [Validation(Required=false)]
                public string ArrApt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PEK</para>
                /// </summary>
                [NameInMap("arr_apt_code")]
                [Validation(Required=false)]
                public string ArrAptCode { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>T1</para>
                /// </summary>
                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("dep_apt")]
                [Validation(Required=false)]
                public string DepApt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_apt_code")]
                [Validation(Required=false)]
                public string DepAptCode { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>T1</para>
                /// </summary>
                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("flight_mile")]
                [Validation(Required=false)]
                public int? FlightMile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CZ2891</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public List<string> StopCity { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200042</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("insure_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleInsureInfoList> InsureInfoList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleInsureInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1002308231</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("mix_pay")]
            [Validation(Required=false)]
            public bool? MixPay { get; set; }

            [NameInMap("order_reserve_amount")]
            [Validation(Required=false)]
            public double? OrderReserveAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("passenger_count")]
            [Validation(Required=false)]
            public int? PassengerCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>175549295</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f98236773</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("supplier")]
            [Validation(Required=false)]
            public string Supplier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cs9897766</para>
            /// </summary>
            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public List<string> ThirdpartItineraryId { get; set; }

            [NameInMap("ticket_corp_reserve_amount")]
            [Validation(Required=false)]
            public double? TicketCorpReserveAmount { get; set; }

            [NameInMap("ticket_person_reserve_amount")]
            [Validation(Required=false)]
            public double? TicketPersonReserveAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("trip_mode")]
            [Validation(Required=false)]
            public int? TripMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>alitrip</para>
                    /// </summary>
                    [NameInMap("corp_id")]
                    [Validation(Required=false)]
                    public string CorpId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>alitripTest</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_cost_center</para>
                    /// </summary>
                    [NameInMap("number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                }

                [NameInMap("department")]
                [Validation(Required=false)]
                public FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListDepartment Department { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListDepartment : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>alitrip</para>
                    /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test1233</para>
                    /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_project_id</para>
                    /// </summary>
                    [NameInMap("project_id")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    [NameInMap("project_title")]
                    [Validation(Required=false)]
                    public string ProjectTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_third_part_project_id</para>
                    /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>CAESBgoEIgIIABgAIhkKFwMSAAAAMUw4ZGViODFlYmM3MYzM4</para>
            /// </summary>
            [NameInMap("scroll_id")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-<b><b>-</b></b>-****-D77369043A5F</para>
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
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
