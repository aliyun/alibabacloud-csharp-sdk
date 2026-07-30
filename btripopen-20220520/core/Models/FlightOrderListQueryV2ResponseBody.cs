// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<FlightOrderListQueryV2ResponseBodyModule> Module { get; set; }
        public class FlightOrderListQueryV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The approval information.</para>
            /// </summary>
            [NameInMap("approve")]
            [Validation(Required=false)]
            public FlightOrderListQueryV2ResponseBodyModuleApprove Approve { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleApprove : TeaModel {
                /// <summary>
                /// <para>The business travel approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1234</para>
                /// </summary>
                [NameInMap("approve_id")]
                [Validation(Required=false)]
                public long? ApproveId { get; set; }

                /// <summary>
                /// <para>The travel approval name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business Trip.</para>
                /// </summary>
                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                /// <summary>
                /// <para>The business travel excess approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1233544</para>
                /// </summary>
                [NameInMap("exceed_approve_id")]
                [Validation(Required=false)]
                public string ExceedApproveId { get; set; }

                /// <summary>
                /// <para>The third-party travel approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100231431</para>
                /// </summary>
                [NameInMap("thirdpart_approve_id")]
                [Validation(Required=false)]
                public string ThirdpartApproveId { get; set; }

                /// <summary>
                /// <para>The third-party excess approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("thirdpart_exceed_approve_id")]
                [Validation(Required=false)]
                public string ThirdpartExceedApproveId { get; set; }

            }

            /// <summary>
            /// <para>The business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BusinessTravelEnterpriseID.</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The enterprise name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba.</para>
            /// </summary>
            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>The department ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UserDepartmentID.</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            /// <summary>
            /// <para>The department name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Business Travel Technology Department.</para>
            /// </summary>
            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>The list of flight ticket information.&gt;Notice: Has a value only after successful ticketing. Check for null values.</notice></para>
            /// </summary>
            [NameInMap("flight_order_ticket_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightOrderTicketList> FlightOrderTicketList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightOrderTicketList : TeaModel {
                /// <summary>
                /// <para>The flight information.</para>
                /// </summary>
                [NameInMap("flight_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightOrderTicketListFlightList> FlightList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightOrderTicketListFlightList : TeaModel {
                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// <remarks>
                    /// <para>Warning: Not yet assigned a value. Do not use directly.</warning></para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The cabin code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V</para>
                    /// </summary>
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    /// <summary>
                    /// <para>The cabin class.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Y</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>The cabin class description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Economy Class.</para>
                    /// </summary>
                    [NameInMap("cabin_class_name")]
                    [Validation(Required=false)]
                    public string CabinClassName { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
                    /// <remarks>
                    /// <para>Warning: Not yet assigned a value. Do not use directly.</warning></para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA8572</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                }

                /// <summary>
                /// <para>The list of ticket numbers.</para>
                /// </summary>
                [NameInMap("ticket_no_list")]
                [Validation(Required=false)]
                public List<string> TicketNoList { get; set; }

                /// <summary>
                /// <para>The third-party user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ThirdPartyUserID.</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The list of flight fee information.&gt;Notice: Returned after successful ticketing. Check for null values.</notice></para>
            /// </summary>
            [NameInMap("flight_order_user_fee_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightOrderUserFeeList> FlightOrderUserFeeList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightOrderUserFeeList : TeaModel {
                /// <summary>
                /// <para>The airport construction fee. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70, unit: CNY.</para>
                /// </summary>
                [NameInMap("build_fee")]
                [Validation(Required=false)]
                public double? BuildFee { get; set; }

                /// <summary>
                /// <para>The enterprise payment amount (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>500, unit: CNY
                /// [_single.resp.200.props.module.items.</para>
                /// </summary>
                [NameInMap("corp_pay_amount")]
                [Validation(Required=false)]
                public double? CorpPayAmount { get; set; }

                /// <summary>
                /// <para>The fuel surcharge. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50, unit: CNY.</para>
                /// </summary>
                [NameInMap("oil_fee")]
                [Validation(Required=false)]
                public double? OilFee { get; set; }

                /// <summary>
                /// <para>The personal payment amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100, unit: CNY.</para>
                /// </summary>
                [NameInMap("person_pay_amount")]
                [Validation(Required=false)]
                public double? PersonPayAmount { get; set; }

                /// <summary>
                /// <para>The ticket price. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500, unit: CNY
                /// [_single.resp.200.props.module.items.</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                /// <summary>
                /// <para>The user ID of the passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ThirdPartyUserID.</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The flight refund order information list.<notice>This field has a value only when a refund order exists. Check for null values.</notice></para>
            /// </summary>
            [NameInMap("flight_refund_apply_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyList> FlightRefundApplyList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyList : TeaModel {
                /// <summary>
                /// <para>The flight refund ticket information list.<notice>This field has a value only after the refund is successful. An empty array [] is returned by default. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("flight_refund_apply_ticket_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundApplyTicketList> FlightRefundApplyTicketList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundApplyTicketList : TeaModel {
                    /// <summary>
                    /// <para>The brief flight information.</para>
                    /// </summary>
                    [NameInMap("flight_list")]
                    [Validation(Required=false)]
                    public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundApplyTicketListFlightList> FlightList { get; set; }
                    public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundApplyTicketListFlightList : TeaModel {
                        /// <summary>
                        /// <para>The arrival time.</para>
                        /// <remarks>
                        /// <para>Warning: Not yet assigned a value. Do not use directly.</warning></para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-07-20T10:40Z</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        /// <summary>
                        /// <para>The cabin code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <para>The cabin class.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>The cabin class description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Economy Class.</para>
                        /// </summary>
                        [NameInMap("cabin_class_name")]
                        [Validation(Required=false)]
                        public string CabinClassName { get; set; }

                        /// <summary>
                        /// <para>The departure time.</para>
                        /// <remarks>
                        /// <para>Warning: Not yet assigned a value. Do not use directly.</warning></para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-07-20T10:40Z</para>
                        /// </summary>
                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        /// <summary>
                        /// <para>The flight number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HU7052</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of ticket numbers.</para>
                    /// </summary>
                    [NameInMap("ticket_no_list")]
                    [Validation(Required=false)]
                    public List<string> TicketNoList { get; set; }

                    /// <summary>
                    /// <para>The third-party user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ThirdPartyUserID.</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The refund segment information list.</para>
                /// </summary>
                [NameInMap("flight_refund_segment_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundSegmentList> FlightRefundSegmentList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundSegmentList : TeaModel {
                    /// <summary>
                    /// <para>The airline code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CZ</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>China Southern Airlines.</para>
                    /// </summary>
                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    /// <summary>
                    /// <para>The arrival airport.
                    /// [responses.200.schema.properties.module.items</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京大兴国际机场</para>
                    /// </summary>
                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PKX</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Beijing.</para>
                    /// </summary>
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>到达航站楼</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// <remarks>
                    /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hangzhou Xiaoshan International Airport.</para>
                    /// </summary>
                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    /// <summary>
                    /// <para>The departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hangzhou.</para>
                    /// </summary>
                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>出发航站楼</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <para>出发时间</para>
                    /// <remarks>
                    /// <para>Notice: 时间格式 yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>里程</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1200，单位:km</para>
                    /// </summary>
                    [NameInMap("flight_mile")]
                    [Validation(Required=false)]
                    public int? FlightMile { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU5619</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The journey index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>The segment index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <para>The stopover city.</para>
                    /// </summary>
                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public List<string> StopCity { get; set; }

                }

                /// <summary>
                /// <para>The per-person flight refund fee information list.<notice>This field is returned after the refund is successful. An empty array [] is returned by default. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("flight_refund_user_fee_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundUserFeeList> FlightRefundUserFeeList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightRefundApplyListFlightRefundUserFeeList : TeaModel {
                    /// <summary>
                    /// <para>The already used amount. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("already_use_amount")]
                    [Validation(Required=false)]
                    public double? AlreadyUseAmount { get; set; }

                    /// <summary>
                    /// <para>The non-refundable change fee. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("non_refundable_reshop_change_amount")]
                    [Validation(Required=false)]
                    public double? NonRefundableReshopChangeAmount { get; set; }

                    /// <summary>
                    /// <para>The non-refundable rebooking upgrade amount. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("non_refundable_reshop_upgrade_amount")]
                    [Validation(Required=false)]
                    public double? NonRefundableReshopUpgradeAmount { get; set; }

                    /// <summary>
                    /// <para>The refund amount. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500, unit: CNY
                    /// [_single.resp.200.props.module.items.</para>
                    /// </summary>
                    [NameInMap("refund_amount")]
                    [Validation(Required=false)]
                    public double? RefundAmount { get; set; }

                    /// <summary>
                    /// <para>The corporate refund amount. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("refund_corp_amount")]
                    [Validation(Required=false)]
                    public double? RefundCorpAmount { get; set; }

                    /// <summary>
                    /// <para>The refund handling fee. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("refund_hand_fee")]
                    [Validation(Required=false)]
                    public double? RefundHandFee { get; set; }

                    /// <summary>
                    /// <para>The personal refund amount. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("refund_person_amount")]
                    [Validation(Required=false)]
                    public double? RefundPersonAmount { get; set; }

                    /// <summary>
                    /// <para>The third-party user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ThirdPartyUserID.</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The refund application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>232213</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public string RefundApplyId { get; set; }

                /// <summary>
                /// <para>The refund approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024122312</para>
                /// </summary>
                [NameInMap("refund_approve_id")]
                [Validation(Required=false)]
                public string RefundApproveId { get; set; }

                /// <summary>
                /// <para>The corporate refund amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100, unit: CNY.</para>
                /// </summary>
                [NameInMap("refund_corp_total_amount")]
                [Validation(Required=false)]
                public double? RefundCorpTotalAmount { get; set; }

                /// <summary>
                /// <para>The refund handling fee. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100, unit: CNY.</para>
                /// </summary>
                [NameInMap("refund_hand_fee")]
                [Validation(Required=false)]
                public double? RefundHandFee { get; set; }

                /// <summary>
                /// <para>The personal refund amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100, unit: CNY.</para>
                /// </summary>
                [NameInMap("refund_person_total_amount")]
                [Validation(Required=false)]
                public double? RefundPersonTotalAmount { get; set; }

                /// <summary>
                /// <para>The refund reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Personal refund.</para>
                /// </summary>
                [NameInMap("refund_reason")]
                [Validation(Required=false)]
                public string RefundReason { get; set; }

                /// <summary>
                /// <para>The refund reason code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("refund_reason_code")]
                [Validation(Required=false)]
                public string RefundReasonCode { get; set; }

                /// <summary>
                /// <para>The total refund amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200, unit: CNY.</para>
                /// </summary>
                [NameInMap("refund_total_amount")]
                [Validation(Required=false)]
                public double? RefundTotalAmount { get; set; }

                /// <summary>
                /// <para>The related refund order ID. </para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>In supplementary refund scenarios, this is the related refund order ID.</description></item>
                /// </list>
                /// </remarks>
                /// <remarks>
                /// <para>Warning: This field is not yet assigned a value. Do not use it directly.</warning></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>232218</para>
                /// </summary>
                [NameInMap("relate_refund_apply_id")]
                [Validation(Required=false)]
                public string RelateRefundApplyId { get; set; }

                /// <summary>
                /// <para>The list of third-party user IDs.<notice>This field may not have a value. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("user_id_list")]
                [Validation(Required=false)]
                public List<string> UserIdList { get; set; }

            }

            /// <summary>
            /// <para>The flight rebooking order information.<notice>This field has a value only when a rebooking order exists. null is returned by default.</notice></para>
            /// </summary>
            [NameInMap("flight_reshop_apply_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyList> FlightReshopApplyList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyList : TeaModel {
                /// <summary>
                /// <para>The flight rebooking ticket information.<notice>This field has a value only after the rebooking ticket is successfully issued. An empty array [] is returned by default. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("flight_reshop_apply_ticket_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopApplyTicketList> FlightReshopApplyTicketList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopApplyTicketList : TeaModel {
                    /// <summary>
                    /// <para>The flight number, used as the unique identifier of the segment.</para>
                    /// </summary>
                    [NameInMap("flight_list")]
                    [Validation(Required=false)]
                    public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopApplyTicketListFlightList> FlightList { get; set; }
                    public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopApplyTicketListFlightList : TeaModel {
                        /// <summary>
                        /// <para>The arrival time.</para>
                        /// <remarks>
                        /// <para>Warning: Not yet assigned a value. Do not use directly.</warning></para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-07-20T10:40Z</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        /// <summary>
                        /// <para>The cabin code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>V</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        /// <summary>
                        /// <para>The cabin class.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>The cabin class description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Economy Class.</para>
                        /// </summary>
                        [NameInMap("cabin_class_name")]
                        [Validation(Required=false)]
                        public string CabinClassName { get; set; }

                        /// <summary>
                        /// <para>The departure time.</para>
                        /// <remarks>
                        /// <para>Warning: Not yet assigned a value. Do not use directly.</warning></para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-07-20T10:40Z</para>
                        /// </summary>
                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        /// <summary>
                        /// <para>The flight number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MU1398</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of ticket numbers before rebooking.</para>
                    /// </summary>
                    [NameInMap("relate_ticket_no_list")]
                    [Validation(Required=false)]
                    public List<string> RelateTicketNoList { get; set; }

                    /// <summary>
                    /// <para>The list of rebooking ticket numbers.</para>
                    /// </summary>
                    [NameInMap("ticket_no_list")]
                    [Validation(Required=false)]
                    public List<string> TicketNoList { get; set; }

                    /// <summary>
                    /// <para>The third-party user ID of the passenger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alitrip123</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The rebooking segments.<notice>This field has a value only after the rebooking ticket is successfully issued. An empty array [] is returned by default. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("flight_reshop_segment_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopSegmentList> FlightReshopSegmentList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopSegmentList : TeaModel {
                    /// <summary>
                    /// <para>The airline code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>China Southern Airlines.</para>
                    /// </summary>
                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    /// <summary>
                    /// <para>The arrival airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Beijing Daxing Airport.</para>
                    /// </summary>
                    [NameInMap("arr_apt")]
                    [Validation(Required=false)]
                    public string ArrApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PEX</para>
                    /// </summary>
                    [NameInMap("arr_apt_code")]
                    [Validation(Required=false)]
                    public string ArrAptCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Beijing.</para>
                    /// </summary>
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival terminal. This field may be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("arr_terminal")]
                    [Validation(Required=false)]
                    public string ArrTerminal { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// <remarks>
                    /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The departure airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hangzhou Xiaoshan Airport.</para>
                    /// </summary>
                    [NameInMap("dep_apt")]
                    [Validation(Required=false)]
                    public string DepApt { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_apt_code")]
                    [Validation(Required=false)]
                    public string DepAptCode { get; set; }

                    /// <summary>
                    /// <para>The departure city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hangzhou.</para>
                    /// </summary>
                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure terminal. This field may be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("dep_terminal")]
                    [Validation(Required=false)]
                    public string DepTerminal { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
                    /// <remarks>
                    /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-07-20T10:40Z</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The mileage. This field may be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1200, unit: km.</para>
                    /// </summary>
                    [NameInMap("flight_mile")]
                    [Validation(Required=false)]
                    public int? FlightMile { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA3358</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The journey index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    /// <summary>
                    /// <para>The segment index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    /// <summary>
                    /// <para>The stopover city.</para>
                    /// </summary>
                    [NameInMap("stop_city")]
                    [Validation(Required=false)]
                    public List<string> StopCity { get; set; }

                }

                /// <summary>
                /// <para>The rebooking fees.<notice>This field has a value only after the rebooking ticket is successfully issued. An empty array [] is returned by default. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("flight_reshop_user_fee_list")]
                [Validation(Required=false)]
                public List<FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopUserFeeList> FlightReshopUserFeeList { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleFlightReshopApplyListFlightReshopUserFeeList : TeaModel {
                    /// <summary>
                    /// <para>The change fee. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("change_fee")]
                    [Validation(Required=false)]
                    public double? ChangeFee { get; set; }

                    /// <summary>
                    /// <para>The rebooking corporate payment amount. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("reshop_corp_amount")]
                    [Validation(Required=false)]
                    public double? ReshopCorpAmount { get; set; }

                    /// <summary>
                    /// <para>The rebooking personal payment amount. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("reshop_person_amount")]
                    [Validation(Required=false)]
                    public double? ReshopPersonAmount { get; set; }

                    /// <summary>
                    /// <para>The cabin upgrade fee. Unit: CNY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50, unit: CNY.</para>
                    /// </summary>
                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public double? UpgradeFee { get; set; }

                    /// <summary>
                    /// <para>The third-party user ID of the passenger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alitrip123</para>
                    /// </summary>
                    [NameInMap("user_id")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The related rebooking order ID.</para>
                /// <remarks>
                /// <para>Warning: This field is not yet assigned a value. Do not use it directly.</warning></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100231231</para>
                /// </summary>
                [NameInMap("relate_reshop_apply_id")]
                [Validation(Required=false)]
                public long? RelateReshopApplyId { get; set; }

                /// <summary>
                /// <para>The rebooking application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123232323</para>
                /// </summary>
                [NameInMap("reshop_apply_id")]
                [Validation(Required=false)]
                public long? ReshopApplyId { get; set; }

                /// <summary>
                /// <para>The rebooking approval ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122312</para>
                /// </summary>
                [NameInMap("reshop_approve_id")]
                [Validation(Required=false)]
                public string ReshopApproveId { get; set; }

                /// <summary>
                /// <para>The total corporate payment amount for rebooking. Unit: CNY.<notice>This field has a value only when the rebooking quote is successful. 0 is returned by default.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>500, unit: CNY
                /// [_single.resp.200.props.module.items.</para>
                /// </summary>
                [NameInMap("reshop_corp_total_amount")]
                [Validation(Required=false)]
                public double? ReshopCorpTotalAmount { get; set; }

                /// <summary>
                /// <para>The total personal payment amount for rebooking. Unit: CNY.<notice>This field has a value only when the rebooking quote is successful. 0 is returned by default.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>50, unit: CNY.</para>
                /// </summary>
                [NameInMap("reshop_person_total_amount")]
                [Validation(Required=false)]
                public double? ReshopPersonTotalAmount { get; set; }

                /// <summary>
                /// <para>The rebooking reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Rebooking due to work reasons.</para>
                /// </summary>
                [NameInMap("reshop_reason")]
                [Validation(Required=false)]
                public string ReshopReason { get; set; }

                /// <summary>
                /// <para>The rebooking reason code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1002</para>
                /// </summary>
                [NameInMap("reshop_reason_code")]
                [Validation(Required=false)]
                public string ReshopReasonCode { get; set; }

                /// <summary>
                /// <para>The total rebooking amount. Unit: CNY.<notice>This field has a value only when the rebooking quote is successful.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>500, unit: CNY
                /// [_single.resp.200.props.module.items.</para>
                /// </summary>
                [NameInMap("reshop_total_amount")]
                [Validation(Required=false)]
                public double? ReshopTotalAmount { get; set; }

                /// <summary>
                /// <para>The rebooking user IDs.<notice>This field has a value only when the rebooking confirmation has a quote. An empty array [] is returned by default. Check for null values.</notice></para>
                /// </summary>
                [NameInMap("user_id_list")]
                [Validation(Required=false)]
                public List<string> UserIdList { get; set; }

            }

            /// <summary>
            /// <para>机票正向航段信息列表</para>
            /// </summary>
            [NameInMap("flight_segment_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleFlightSegmentList> FlightSegmentList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleFlightSegmentList : TeaModel {
                /// <summary>
                /// <para>The airline code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CZ</para>
                /// </summary>
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                /// <summary>
                /// <para>The airline name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国南方航空公司</para>
                /// </summary>
                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                /// <summary>
                /// <para>The arrival airport.
                /// [responses.200.schema.properties.module.items</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京大兴国际机场</para>
                /// </summary>
                [NameInMap("arr_apt")]
                [Validation(Required=false)]
                public string ArrApt { get; set; }

                /// <summary>
                /// <para>The three-letter code of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PEK</para>
                /// </summary>
                [NameInMap("arr_apt_code")]
                [Validation(Required=false)]
                public string ArrAptCode { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing.</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>到达航站楼（可能为空）</para>
                /// 
                /// <b>Example:</b>
                /// <para>T1</para>
                /// </summary>
                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou Xiaoshan International Airport.</para>
                /// </summary>
                [NameInMap("dep_apt")]
                [Validation(Required=false)]
                public string DepApt { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_apt_code")]
                [Validation(Required=false)]
                public string DepAptCode { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou.</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure terminal. This field may be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T1</para>
                /// </summary>
                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</notice></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The mileage. This field may be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200，单位:km</para>
                /// </summary>
                [NameInMap("flight_mile")]
                [Validation(Required=false)]
                public int? FlightMile { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CZ2891</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The journey index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <para>The segment index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <para>The stopover city.</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public List<string> StopCity { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200042</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The list of insurance information (has a value only when insurance exists, otherwise returns []).</para>
            /// </summary>
            [NameInMap("insure_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleInsureInfoList> InsureInfoList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleInsureInfoList : TeaModel {
                /// <summary>
                /// <para>The insurance order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1002308231</para>
                /// </summary>
                [NameInMap("insure_id")]
                [Validation(Required=false)]
                public string InsureId { get; set; }

                /// <summary>
                /// <para>The insurance order amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50, unit: CNY.</para>
                /// </summary>
                [NameInMap("insure_order_amount")]
                [Validation(Required=false)]
                public double? InsureOrderAmount { get; set; }

                /// <summary>
                /// <para>The insurance unit price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10, unit: CNY.</para>
                /// </summary>
                [NameInMap("insure_price")]
                [Validation(Required=false)]
                public double? InsurePrice { get; set; }

                /// <summary>
                /// <para>The insurance type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Aviation Accident Insurance.</para>
                /// </summary>
                [NameInMap("insure_type")]
                [Validation(Required=false)]
                public string InsureType { get; set; }

                /// <summary>
                /// <para>The list of insured persons.</para>
                /// </summary>
                [NameInMap("name_list")]
                [Validation(Required=false)]
                public List<string> NameList { get; set; }

                /// <summary>
                /// <para>The number of insurance policies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                /// <summary>
                /// <para>The insurance order status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether mixed payment is used.</para>
            /// <list type="bullet">
            /// <item><description>true: The order is paid by both enterprise and personal payment.</description></item>
            /// <item><description>false: The order is paid by either enterprise or personal payment only.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("mix_pay")]
            [Validation(Required=false)]
            public bool? MixPay { get; set; }

            /// <summary>
            /// <para>The total order booking amount (unit: CNY).</para>
            /// 
            /// <b>Example:</b>
            /// <para>500, unit: CNY.</para>
            /// </summary>
            [NameInMap("order_reserve_amount")]
            [Validation(Required=false)]
            public double? OrderReserveAmount { get; set; }

            /// <summary>
            /// <para>The number of passengers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("passenger_count")]
            [Validation(Required=false)]
            public int? PassengerCount { get; set; }

            /// <summary>
            /// <para>The order payment time.&gt;Notice: This field has a value only when payment is successful. Check for null values.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <para>The list of price information.&gt;Notice: Returned after successful payment. Returns [] by default. Check for null values.</notice></para>
            /// </summary>
            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModulePriceInfoList : TeaModel {
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
                /// <para>The transaction category type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_type")]
                [Validation(Required=false)]
                public int? CategoryType { get; set; }

                /// <summary>
                /// <para>The transaction creation time.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Format: yyyy-MM-dd HH:mm:ss</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The settlement method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <para>The price (unit: CNY).</para>
                /// 
                /// <b>Example:</b>
                /// <para>100, unit: CNY.</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <para>The sub-order ID.</para>
                /// <remarks>
                /// <para>Change order ID, refund order ID, insurance order ID, or booking order ID.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>175549295</para>
                /// </summary>
                [NameInMap("sub_order_id")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

                /// <summary>
                /// <para>The transaction ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f98236773</para>
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

            /// <summary>
            /// <para>The order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The supplier name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Business Travel.</para>
            /// </summary>
            [NameInMap("supplier")]
            [Validation(Required=false)]
            public string Supplier { get; set; }

            /// <summary>
            /// <para>The list of third-party itinerary IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs9897766</para>
            /// </summary>
            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public List<string> ThirdpartItineraryId { get; set; }

            /// <summary>
            /// <para>The enterprise ticket booking amount (unit: CNY).</para>
            /// 
            /// <b>Example:</b>
            /// <para>400, unit: CNY.</para>
            /// </summary>
            [NameInMap("ticket_corp_reserve_amount")]
            [Validation(Required=false)]
            public double? TicketCorpReserveAmount { get; set; }

            /// <summary>
            /// <para>The personal ticket booking amount (unit: CNY).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100, unit: CNY.</para>
            /// </summary>
            [NameInMap("ticket_person_reserve_amount")]
            [Validation(Required=false)]
            public double? TicketPersonReserveAmount { get; set; }

            /// <summary>
            /// <para>The trip mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("trip_mode")]
            [Validation(Required=false)]
            public int? TripMode { get; set; }

            /// <summary>
            /// <para>The trip type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("trip_type")]
            [Validation(Required=false)]
            public int? TripType { get; set; }

            /// <summary>
            /// <para>The list of traveler information.</para>
            /// </summary>
            [NameInMap("user_affiliate_list")]
            [Validation(Required=false)]
            public List<FlightOrderListQueryV2ResponseBodyModuleUserAffiliateList> UserAffiliateList { get; set; }
            public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateList : TeaModel {
                /// <summary>
                /// <para>The cost center information.</para>
                /// </summary>
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListCostCenter CostCenter { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListCostCenter : TeaModel {
                    /// <summary>
                    /// <para>The enterprise ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alitrip</para>
                    /// </summary>
                    [NameInMap("corp_id")]
                    [Validation(Required=false)]
                    public string CorpId { get; set; }

                    /// <summary>
                    /// <para>The business travel cost center ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alitripTest</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The cost center name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test Cost Center.</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The cost center number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_cost_center</para>
                    /// </summary>
                    [NameInMap("number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                }

                /// <summary>
                /// <para>The department information.</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListDepartment Department { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListDepartment : TeaModel {
                    /// <summary>
                    /// <para>The department ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alitrip</para>
                    /// </summary>
                    [NameInMap("depart_id")]
                    [Validation(Required=false)]
                    public string DepartId { get; set; }

                    /// <summary>
                    /// <para>The department name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alibaba Business Travel.</para>
                    /// </summary>
                    [NameInMap("depart_name")]
                    [Validation(Required=false)]
                    public string DepartName { get; set; }

                }

                /// <summary>
                /// <para>The invoice information.</para>
                /// </summary>
                [NameInMap("invoice")]
                [Validation(Required=false)]
                public FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListInvoice Invoice { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListInvoice : TeaModel {
                    /// <summary>
                    /// <para>The invoice ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test1233</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The invoice title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alibaba Business Travel Invoice Test.</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The project information.</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListProject Project { get; set; }
                public class FlightOrderListQueryV2ResponseBodyModuleUserAffiliateListProject : TeaModel {
                    /// <summary>
                    /// <para>The project ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_project_id</para>
                    /// </summary>
                    [NameInMap("project_id")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    /// <summary>
                    /// <para>The project name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test Project.</para>
                    /// </summary>
                    [NameInMap("project_title")]
                    [Validation(Required=false)]
                    public string ProjectTitle { get; set; }

                    /// <summary>
                    /// <para>The third-party project ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_third_part_project_id</para>
                    /// </summary>
                    [NameInMap("thirdpart_project_id")]
                    [Validation(Required=false)]
                    public string ThirdpartProjectId { get; set; }

                }

                /// <summary>
                /// <para>The traveler ID (third-party user ID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>ThirdPartyUserID.</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John.</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The third-party user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ThirdPartyUserID.</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John.</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>页面信息</para>
        /// </summary>
        [NameInMap("pageInfo")]
        [Validation(Required=false)]
        public FlightOrderListQueryV2ResponseBodyPageInfo PageInfo { get; set; }
        public class FlightOrderListQueryV2ResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>当前返回数据数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>100，最多100条数据</para>
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The scroll ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESBgoEIgIIABgAIhkKFwMSAAAAMUw4ZGViODFlYmM3MYzM4</para>
            /// </summary>
            [NameInMap("scroll_id")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <para>总记录数</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_number")]
            [Validation(Required=false)]
            public int? TotalNumber { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-<b><b>-</b></b>-****-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace identifier of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
