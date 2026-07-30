// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightRefundDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightRefundDetailResponseBodyModule Module { get; set; }
        public class IntlFlightRefundDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of passenger refund fee details. This field has a value after the fee is confirmed.</para>
            /// </summary>
            [NameInMap("passenge_refund_fee_detail_list")]
            [Validation(Required=false)]
            public List<IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailList> PassengeRefundFeeDetailList { get; set; }
            public class IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailList : TeaModel {
                /// <summary>
                /// <para>The passenger ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                /// <summary>
                /// <para>The refund fee details. This field has a value when the status is &quot;Refund approved&quot;, &quot;Refund in progress&quot;, or &quot;Refund successful&quot;.</para>
                /// <remarks>
                /// <para>Notice: Supplementary refund orders do not have refund fee details.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("refund_fee_detail")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListRefundFeeDetail RefundFeeDetail { get; set; }
                public class IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListRefundFeeDetail : TeaModel {
                    /// <summary>
                    /// <para>The total price of used tickets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12400</para>
                    /// </summary>
                    [NameInMap("already_used_total_amount")]
                    [Validation(Required=false)]
                    public long? AlreadyUsedTotalAmount { get; set; }

                    /// <summary>
                    /// <para>The non-refundable rebooking handling fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>21000</para>
                    /// </summary>
                    [NameInMap("non_refundable_re_shop_handling_fee")]
                    [Validation(Required=false)]
                    public long? NonRefundableReShopHandlingFee { get; set; }

                    /// <summary>
                    /// <para>The non-refundable upgrade handling fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("non_refundable_re_shop_upgrade_fee")]
                    [Validation(Required=false)]
                    public long? NonRefundableReShopUpgradeFee { get; set; }

                    /// <summary>
                    /// <para>The non-refundable tax difference.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("non_refundable_tax_diff_fee")]
                    [Validation(Required=false)]
                    public long? NonRefundableTaxDiffFee { get; set; }

                    /// <summary>
                    /// <para>The rebooking refund amount, which equals the rebooking service fee refund amount + rebooking upgrade fee refund amount + tax difference refund amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14000</para>
                    /// </summary>
                    [NameInMap("re_shop_refund_amount")]
                    [Validation(Required=false)]
                    public long? ReShopRefundAmount { get; set; }

                    /// <summary>
                    /// <para>The rebooking service fee refund amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14000</para>
                    /// </summary>
                    [NameInMap("re_shop_service_refund_amount")]
                    [Validation(Required=false)]
                    public long? ReShopServiceRefundAmount { get; set; }

                    /// <summary>
                    /// <para>The rebooking upgrade fee refund amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("re_shop_upgrade_refund_amount")]
                    [Validation(Required=false)]
                    public long? ReShopUpgradeRefundAmount { get; set; }

                    /// <summary>
                    /// <para>The list of rebooking refund fee details. This field has a value when a ticket is refunded after rebooking.</para>
                    /// </summary>
                    [NameInMap("refund_re_shop_fee_detail_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListRefundFeeDetailRefundReShopFeeDetailList> RefundReShopFeeDetailList { get; set; }
                    public class IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListRefundFeeDetailRefundReShopFeeDetailList : TeaModel {
                        /// <summary>
                        /// <para>The non-refundable rebooking handling fee.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21000</para>
                        /// </summary>
                        [NameInMap("non_refundable_re_shop_handling_fee")]
                        [Validation(Required=false)]
                        public long? NonRefundableReShopHandlingFee { get; set; }

                        /// <summary>
                        /// <para>The non-refundable upgrade handling fee.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("non_refundable_re_shop_upgrade_fee")]
                        [Validation(Required=false)]
                        public long? NonRefundableReShopUpgradeFee { get; set; }

                        /// <summary>
                        /// <para>The non-refundable tax difference.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("non_refundable_tax_diff_fee")]
                        [Validation(Required=false)]
                        public long? NonRefundableTaxDiffFee { get; set; }

                        /// <summary>
                        /// <para>The rebooking order ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10002340021</para>
                        /// </summary>
                        [NameInMap("re_shop_apply_id")]
                        [Validation(Required=false)]
                        public string ReShopApplyId { get; set; }

                        /// <summary>
                        /// <para>The rebooking refund amount, which equals the rebooking service fee refund amount + rebooking upgrade fee refund amount + tax difference refund amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>14000</para>
                        /// </summary>
                        [NameInMap("re_shop_refund_amount")]
                        [Validation(Required=false)]
                        public long? ReShopRefundAmount { get; set; }

                        /// <summary>
                        /// <para>The rebooking service fee refund amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>14000</para>
                        /// </summary>
                        [NameInMap("re_shop_service_refund_amount")]
                        [Validation(Required=false)]
                        public long? ReShopServiceRefundAmount { get; set; }

                        /// <summary>
                        /// <para>The rebooking upgrade fee refund amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("re_shop_upgrade_refund_amount")]
                        [Validation(Required=false)]
                        public long? ReShopUpgradeRefundAmount { get; set; }

                        /// <summary>
                        /// <para>The tax difference refund amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("refund_tax_diff_amount")]
                        [Validation(Required=false)]
                        public long? RefundTaxDiffAmount { get; set; }

                    }

                    /// <summary>
                    /// <para>The tax difference refund amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("refund_tax_diff_amount")]
                    [Validation(Required=false)]
                    public long? RefundTaxDiffAmount { get; set; }

                    /// <summary>
                    /// <para>The non-refundable tax amount, which is the tax refund handling fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>45000</para>
                    /// </summary>
                    [NameInMap("refund_tax_fee")]
                    [Validation(Required=false)]
                    public long? RefundTaxFee { get; set; }

                    /// <summary>
                    /// <para>The non-refundable ticket amount, which is the refund handling fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("refund_ticket_fee")]
                    [Validation(Required=false)]
                    public long? RefundTicketFee { get; set; }

                    /// <summary>
                    /// <para>The tax refund amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("tax_refund_amount")]
                    [Validation(Required=false)]
                    public long? TaxRefundAmount { get; set; }

                    /// <summary>
                    /// <para>The refund amount for original tickets (excluding rebooking tickets).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("ticket_refund_amount")]
                    [Validation(Required=false)]
                    public long? TicketRefundAmount { get; set; }

                    /// <summary>
                    /// <para>The total actual refund amount = total forward (ticket + tax) refund amount + rebooking refund amount.
                    /// [_single.resp.200.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("total_refund_amount")]
                    [Validation(Required=false)]
                    public long? TotalRefundAmount { get; set; }

                }

                /// <summary>
                /// <para>The list of refunded ticket information.</para>
                /// </summary>
                [NameInMap("ticket_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListTicketList> TicketList { get; set; }
                public class IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListTicketList : TeaModel {
                    /// <summary>
                    /// <para>The list of ticket segment keys.</para>
                    /// </summary>
                    [NameInMap("segment_key_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentKeyList { get; set; }

                    /// <summary>
                    /// <para>The ticket number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>784-3553845201</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of passengers.</para>
            /// </summary>
            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<IntlFlightRefundDetailResponseBodyModulePassengerList> PassengerList { get; set; }
            public class IntlFlightRefundDetailResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <para>The date of birth. Format: yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1996-09-13</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <para>The passenger name. This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG/SAN</para>
                /// </summary>
                [NameInMap("full_name")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                /// <summary>
                /// <para>The gender. Valid values: 0 (male), 1 (female).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <para>The employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001101</para>
                /// </summary>
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                /// <summary>
                /// <para>The nationality name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国大陆</para>
                /// </summary>
                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <para>The two-letter nationality code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("nationality_code")]
                [Validation(Required=false)]
                public string NationalityCode { get; set; }

                /// <summary>
                /// <para>The passenger ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8432002</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                /// <summary>
                /// <para>The passenger type. Valid values: ADT(0, &quot;Adult&quot;), CHD(1, &quot;Child&quot;).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The unique ID of the business travel user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>btrip8432002</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The employee type. Valid values: 0 (internal employee), 1 (external employee).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            /// <summary>
            /// <para>The basic information of the refund order.</para>
            /// </summary>
            [NameInMap("refund_order_info")]
            [Validation(Required=false)]
            public IntlFlightRefundDetailResponseBodyModuleRefundOrderInfo RefundOrderInfo { get; set; }
            public class IntlFlightRefundDetailResponseBodyModuleRefundOrderInfo : TeaModel {
                /// <summary>
                /// <para>The refund application time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-16 19:20:00</para>
                /// </summary>
                [NameInMap("apply_time")]
                [Validation(Required=false)]
                public string ApplyTime { get; set; }

                /// <summary>
                /// <para>The reason for closing the refund order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>该航司暂不支持病退，旅客因病退票均按照自愿退票规定办理，请提交自愿退票</para>
                /// </summary>
                [NameInMap("close_reason")]
                [Validation(Required=false)]
                public string CloseReason { get; set; }

                /// <summary>
                /// <para>The refund handling fee. This field has a value after the fee is confirmed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("handing_amount")]
                [Validation(Required=false)]
                public long? HandingAmount { get; set; }

                /// <summary>
                /// <para>The external refund application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025011317110900006</para>
                /// </summary>
                [NameInMap("out_refund_apply_id")]
                [Validation(Required=false)]
                public string OutRefundApplyId { get; set; }

                /// <summary>
                /// <para>The reason code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("reason_code")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

                /// <summary>
                /// <para>The reason description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>因个人原因取消行程计划（退票费由个人承担）</para>
                /// </summary>
                [NameInMap("reason_desc")]
                [Validation(Required=false)]
                public string ReasonDesc { get; set; }

                /// <summary>
                /// <para>The refund amount. This field has a value after the fee is confirmed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10200</para>
                /// </summary>
                [NameInMap("refund_amount")]
                [Validation(Required=false)]
                public long? RefundAmount { get; set; }

                /// <summary>
                /// <para>The business travel refund application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000003437017</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public string RefundApplyId { get; set; }

                /// <summary>
                /// <para>The primary refund order ID associated with the supplementary refund. A non-empty value indicates this is a supplementary refund order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000003437020</para>
                /// </summary>
                [NameInMap("relation_refund_apply_id")]
                [Validation(Required=false)]
                public long? RelationRefundApplyId { get; set; }

                /// <summary>
                /// <para>The refund application status. Valid values:
                /// DELETE(-1, &quot;Deleted&quot;), INIT(0, &quot;Initialized&quot;), WAIT_OFFER(1, &quot;Pending seller processing&quot;), ACCEPTED(5, &quot;Refund approved&quot;), CLOSED(2, &quot;Refund order closed&quot;), REFUND_PAYING(8, &quot;Refund in progress&quot;), REFUND_SUCCESS(9, &quot;Refund successful&quot;)</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The refund success time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-16 20:20:00</para>
                /// </summary>
                [NameInMap("success_time")]
                [Validation(Required=false)]
                public string SuccessTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the refund is voluntary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("voluntary")]
                [Validation(Required=false)]
                public bool? Voluntary { get; set; }

            }

            /// <summary>
            /// <para>The list of refund segments.</para>
            /// </summary>
            [NameInMap("segment_list")]
            [Validation(Required=false)]
            public List<IntlFlightRefundDetailResponseBodyModuleSegmentList> SegmentList { get; set; }
            public class IntlFlightRefundDetailResponseBodyModuleSegmentList : TeaModel {
                /// <summary>
                /// <para>The marketing airline information.</para>
                /// </summary>
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListAirlineInfo AirlineInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListAirlineInfo : TeaModel {
                    /// <summary>
                    /// <para>The airline code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国东方航空</para>
                    /// </summary>
                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    /// <summary>
                    /// <para>The airline short name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>东航</para>
                    /// </summary>
                    [NameInMap("short_name")]
                    [Validation(Required=false)]
                    public string ShortName { get; set; }

                }

                /// <summary>
                /// <para>The arrival airport information.</para>
                /// </summary>
                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListArrAirportInfo ArrAirportInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListArrAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>香港国际机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The airport short name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>香港</para>
                    /// </summary>
                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T3</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HKG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The name of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>香港</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The arrival time. Format: yyyy-MM-dd HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-13 09:25</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The departure airport information.</para>
                /// </summary>
                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListDepAirportInfo DepAirportInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListDepAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PEK</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>首都国际机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The airport short name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>首都</para>
                    /// </summary>
                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>370100</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The name of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The departure time. Format: yyyy-MM-dd HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-13 07:25</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The total duration of the segment in minutes. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NS8210</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The codeshare flight information.</para>
                /// </summary>
                [NameInMap("flight_share_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListFlightShareInfo FlightShareInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListFlightShareInfo : TeaModel {
                    /// <summary>
                    /// <para>The operating airline information.</para>
                    /// </summary>
                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightRefundDetailResponseBodyModuleSegmentListFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class IntlFlightRefundDetailResponseBodyModuleSegmentListFlightShareInfoOperatingAirlineInfo : TeaModel {
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
                        /// <para>中国国航</para>
                        /// </summary>
                        [NameInMap("airline_name")]
                        [Validation(Required=false)]
                        public string AirlineName { get; set; }

                        /// <summary>
                        /// <para>The airline short name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>国航</para>
                        /// </summary>
                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    /// <summary>
                    /// <para>The operating flight number. This field has a value for codeshare flights.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA0001</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                }

                /// <summary>
                /// <para>The aircraft type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中型机</para>
                /// </summary>
                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                /// <summary>
                /// <para>The list of flight stopovers.</para>
                /// </summary>
                [NameInMap("flight_stop_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundDetailResponseBodyModuleSegmentListFlightStopInfoList> FlightStopInfoList { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListFlightStopInfoList : TeaModel {
                    /// <summary>
                    /// <para>The stopover airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("stop_airport")]
                    [Validation(Required=false)]
                    public string StopAirport { get; set; }

                    /// <summary>
                    /// <para>The name of the stopover airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山国际机场</para>
                    /// </summary>
                    [NameInMap("stop_airport_name")]
                    [Validation(Required=false)]
                    public string StopAirportName { get; set; }

                    /// <summary>
                    /// <para>The arrival terminal at the stopover.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("stop_arr_term")]
                    [Validation(Required=false)]
                    public string StopArrTerm { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover. Format: yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-08-13 07:25</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The name of the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("stop_city_name")]
                    [Validation(Required=false)]
                    public string StopCityName { get; set; }

                    /// <summary>
                    /// <para>The departure terminal at the stopover.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("stop_dep_term")]
                    [Validation(Required=false)]
                    public string StopDepTerm { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover. Format: yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-08-13 07:45</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                    /// <summary>
                    /// <para>The stopover duration. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("stop_time")]
                    [Validation(Required=false)]
                    public string StopTime { get; set; }

                }

                /// <summary>
                /// <para>The aircraft type code, such as 738.</para>
                /// 
                /// <b>Example:</b>
                /// <para>787</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

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
                /// <para>The luggage through-check information for the current segment.</para>
                /// </summary>
                [NameInMap("luggage_direct_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListLuggageDirectInfo LuggageDirectInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListLuggageDirectInfo : TeaModel {
                    /// <summary>
                    /// <para>The luggage through-check status. Valid values: 0 (re-check required), 1 (through-checked), null (unknown).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("dep_city_luggage_direct")]
                    [Validation(Required=false)]
                    public int? DepCityLuggageDirect { get; set; }

                    /// <summary>
                    /// <para>The luggage through-check status. Valid values: 0 (re-check required), 1 (through-checked), null (unknown).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("stop_city_luggage_direct")]
                    [Validation(Required=false)]
                    public int? StopCityLuggageDirect { get; set; }

                }

                /// <summary>
                /// <para>The manufacturer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>波音</para>
                /// </summary>
                [NameInMap("manufacturer")]
                [Validation(Required=false)]
                public string Manufacturer { get; set; }

                /// <summary>
                /// <para>The meal description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>小食</para>
                /// </summary>
                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <para>The number of days crossed. For example, 1 means the flight crosses 1 day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("one_more")]
                [Validation(Required=false)]
                public int? OneMore { get; set; }

                /// <summary>
                /// <para>The display text for day-crossing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>+1天</para>
                /// </summary>
                [NameInMap("one_more_show")]
                [Validation(Required=false)]
                public string OneMoreShow { get; set; }

                /// <summary>
                /// <para>The segment index, starting from 0 within the same journey.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <para>The unique key of the segment. Format: flight number + departure airport + arrival airport + departure date (MMdd).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CZ5009PKXHKG0616</para>
                /// </summary>
                [NameInMap("segment_key")]
                [Validation(Required=false)]
                public string SegmentKey { get; set; }

                /// <summary>
                /// <para>The transit visa information for the current segment.</para>
                /// </summary>
                [NameInMap("segment_visa_remark")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListSegmentVisaRemark SegmentVisaRemark { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListSegmentVisaRemark : TeaModel {
                    /// <summary>
                    /// <para>The transit visa information for the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>首尔--签证提示:中国大陆籍旅客需持有护照及中转国签证，请确认证件无误后再购票。</para>
                    /// </summary>
                    [NameInMap("dep_city_visa_remark")]
                    [Validation(Required=false)]
                    public string DepCityVisaRemark { get; set; }

                    /// <summary>
                    /// <para>The transit visa type for the departure city. Valid values: NO_TRANSIT_VISA(0, &quot;No transit visa required&quot;), NEED_TRANSIT_VISA(1, &quot;Transit visa required&quot;).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("dep_city_visa_type")]
                    [Validation(Required=false)]
                    public int? DepCityVisaType { get; set; }

                    /// <summary>
                    /// <para>The transit visa information for stopover cities. One entry per stopover city.</para>
                    /// </summary>
                    [NameInMap("stop_city_visa_remarks")]
                    [Validation(Required=false)]
                    public List<string> StopCityVisaRemarks { get; set; }

                    /// <summary>
                    /// <para>The transit visa types for stopover cities. One entry per stopover city.</para>
                    /// </summary>
                    [NameInMap("stop_city_visa_types")]
                    [Validation(Required=false)]
                    public List<int?> StopCityVisaTypes { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the flight is a codeshare flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("share")]
                [Validation(Required=false)]
                public bool? Share { get; set; }

                /// <summary>
                /// <para>The aircraft type abbreviation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中</para>
                /// </summary>
                [NameInMap("short_flight_size")]
                [Validation(Required=false)]
                public string ShortFlightSize { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight has a stopover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                /// <summary>
                /// <para>The total duration of the segment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2小时</para>
                /// </summary>
                [NameInMap("total_time")]
                [Validation(Required=false)]
                public string TotalTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global identifier for tracing the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
