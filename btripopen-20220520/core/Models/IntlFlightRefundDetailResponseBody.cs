// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightRefundDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightRefundDetailResponseBodyModule Module { get; set; }
        public class IntlFlightRefundDetailResponseBodyModule : TeaModel {
            [NameInMap("passenge_refund_fee_detail_list")]
            [Validation(Required=false)]
            public List<IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailList> PassengeRefundFeeDetailList { get; set; }
            public class IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                [NameInMap("refund_fee_detail")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListRefundFeeDetail RefundFeeDetail { get; set; }
                public class IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListRefundFeeDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12400</para>
                    /// </summary>
                    [NameInMap("already_used_total_amount")]
                    [Validation(Required=false)]
                    public long? AlreadyUsedTotalAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>21000</para>
                    /// </summary>
                    [NameInMap("non_refundable_re_shop_handling_fee")]
                    [Validation(Required=false)]
                    public long? NonRefundableReShopHandlingFee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("non_refundable_re_shop_upgrade_fee")]
                    [Validation(Required=false)]
                    public long? NonRefundableReShopUpgradeFee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("non_refundable_tax_diff_fee")]
                    [Validation(Required=false)]
                    public long? NonRefundableTaxDiffFee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>14000</para>
                    /// </summary>
                    [NameInMap("re_shop_refund_amount")]
                    [Validation(Required=false)]
                    public long? ReShopRefundAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>14000</para>
                    /// </summary>
                    [NameInMap("re_shop_service_refund_amount")]
                    [Validation(Required=false)]
                    public long? ReShopServiceRefundAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("re_shop_upgrade_refund_amount")]
                    [Validation(Required=false)]
                    public long? ReShopUpgradeRefundAmount { get; set; }

                    [NameInMap("refund_re_shop_fee_detail_list")]
                    [Validation(Required=false)]
                    public List<IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListRefundFeeDetailRefundReShopFeeDetailList> RefundReShopFeeDetailList { get; set; }
                    public class IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListRefundFeeDetailRefundReShopFeeDetailList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>21000</para>
                        /// </summary>
                        [NameInMap("non_refundable_re_shop_handling_fee")]
                        [Validation(Required=false)]
                        public long? NonRefundableReShopHandlingFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("non_refundable_re_shop_upgrade_fee")]
                        [Validation(Required=false)]
                        public long? NonRefundableReShopUpgradeFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("non_refundable_tax_diff_fee")]
                        [Validation(Required=false)]
                        public long? NonRefundableTaxDiffFee { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10002340021</para>
                        /// </summary>
                        [NameInMap("re_shop_apply_id")]
                        [Validation(Required=false)]
                        public string ReShopApplyId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>14000</para>
                        /// </summary>
                        [NameInMap("re_shop_refund_amount")]
                        [Validation(Required=false)]
                        public long? ReShopRefundAmount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>14000</para>
                        /// </summary>
                        [NameInMap("re_shop_service_refund_amount")]
                        [Validation(Required=false)]
                        public long? ReShopServiceRefundAmount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("re_shop_upgrade_refund_amount")]
                        [Validation(Required=false)]
                        public long? ReShopUpgradeRefundAmount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("refund_tax_diff_amount")]
                        [Validation(Required=false)]
                        public long? RefundTaxDiffAmount { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("refund_tax_diff_amount")]
                    [Validation(Required=false)]
                    public long? RefundTaxDiffAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>45000</para>
                    /// </summary>
                    [NameInMap("refund_tax_fee")]
                    [Validation(Required=false)]
                    public long? RefundTaxFee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("refund_ticket_fee")]
                    [Validation(Required=false)]
                    public long? RefundTicketFee { get; set; }

                    [NameInMap("tax_refund_amount")]
                    [Validation(Required=false)]
                    public long? TaxRefundAmount { get; set; }

                    [NameInMap("ticket_refund_amount")]
                    [Validation(Required=false)]
                    public long? TicketRefundAmount { get; set; }

                    [NameInMap("total_refund_amount")]
                    [Validation(Required=false)]
                    public long? TotalRefundAmount { get; set; }

                }

                [NameInMap("ticket_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListTicketList> TicketList { get; set; }
                public class IntlFlightRefundDetailResponseBodyModulePassengeRefundFeeDetailListTicketList : TeaModel {
                    [NameInMap("segment_key_list")]
                    [Validation(Required=false)]
                    public List<string> SegmentKeyList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>784-3553845201</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                }

            }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<IntlFlightRefundDetailResponseBodyModulePassengerList> PassengerList { get; set; }
            public class IntlFlightRefundDetailResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1996-09-13</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ZHANG/SAN</para>
                /// </summary>
                [NameInMap("full_name")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1001101</para>
                /// </summary>
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("nationality_code")]
                [Validation(Required=false)]
                public string NationalityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8432002</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public long? PassengerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>btrip8432002</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("refund_order_info")]
            [Validation(Required=false)]
            public IntlFlightRefundDetailResponseBodyModuleRefundOrderInfo RefundOrderInfo { get; set; }
            public class IntlFlightRefundDetailResponseBodyModuleRefundOrderInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-16 19:20:00</para>
                /// </summary>
                [NameInMap("apply_time")]
                [Validation(Required=false)]
                public string ApplyTime { get; set; }

                [NameInMap("close_reason")]
                [Validation(Required=false)]
                public string CloseReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("handing_amount")]
                [Validation(Required=false)]
                public long? HandingAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025011317110900006</para>
                /// </summary>
                [NameInMap("out_refund_apply_id")]
                [Validation(Required=false)]
                public string OutRefundApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("reason_code")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

                [NameInMap("reason_desc")]
                [Validation(Required=false)]
                public string ReasonDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10200</para>
                /// </summary>
                [NameInMap("refund_amount")]
                [Validation(Required=false)]
                public long? RefundAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000000003437017</para>
                /// </summary>
                [NameInMap("refund_apply_id")]
                [Validation(Required=false)]
                public string RefundApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000000003437020</para>
                /// </summary>
                [NameInMap("relation_refund_apply_id")]
                [Validation(Required=false)]
                public long? RelationRefundApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-16 20:20:00</para>
                /// </summary>
                [NameInMap("success_time")]
                [Validation(Required=false)]
                public string SuccessTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("voluntary")]
                [Validation(Required=false)]
                public bool? Voluntary { get; set; }

            }

            [NameInMap("segment_list")]
            [Validation(Required=false)]
            public List<IntlFlightRefundDetailResponseBodyModuleSegmentList> SegmentList { get; set; }
            public class IntlFlightRefundDetailResponseBodyModuleSegmentList : TeaModel {
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListAirlineInfo AirlineInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListAirlineInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MU</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("short_name")]
                    [Validation(Required=false)]
                    public string ShortName { get; set; }

                }

                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListArrAirportInfo ArrAirportInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListArrAirportInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T3</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HKG</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-08-13 09:25</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListDepAirportInfo DepAirportInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListDepAirportInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PEK</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>370100</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-08-13 07:25</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NS8210</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("flight_share_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListFlightShareInfo FlightShareInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListFlightShareInfo : TeaModel {
                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public IntlFlightRefundDetailResponseBodyModuleSegmentListFlightShareInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class IntlFlightRefundDetailResponseBodyModuleSegmentListFlightShareInfoOperatingAirlineInfo : TeaModel {
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

                        [NameInMap("short_name")]
                        [Validation(Required=false)]
                        public string ShortName { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA0001</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                }

                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                [NameInMap("flight_stop_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundDetailResponseBodyModuleSegmentListFlightStopInfoList> FlightStopInfoList { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListFlightStopInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("stop_airport")]
                    [Validation(Required=false)]
                    public string StopAirport { get; set; }

                    [NameInMap("stop_airport_name")]
                    [Validation(Required=false)]
                    public string StopAirportName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("stop_arr_term")]
                    [Validation(Required=false)]
                    public string StopArrTerm { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-08-13 07:25</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    [NameInMap("stop_city_name")]
                    [Validation(Required=false)]
                    public string StopCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>T1</para>
                    /// </summary>
                    [NameInMap("stop_dep_term")]
                    [Validation(Required=false)]
                    public string StopDepTerm { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-08-13 07:45</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("stop_time")]
                    [Validation(Required=false)]
                    public string StopTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>787</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                [NameInMap("luggage_direct_info")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListLuggageDirectInfo LuggageDirectInfo { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListLuggageDirectInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("dep_city_luggage_direct")]
                    [Validation(Required=false)]
                    public int? DepCityLuggageDirect { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("stop_city_luggage_direct")]
                    [Validation(Required=false)]
                    public int? StopCityLuggageDirect { get; set; }

                }

                [NameInMap("manufacturer")]
                [Validation(Required=false)]
                public string Manufacturer { get; set; }

                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("one_more")]
                [Validation(Required=false)]
                public int? OneMore { get; set; }

                [NameInMap("one_more_show")]
                [Validation(Required=false)]
                public string OneMoreShow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CZ5009PKXHKG0616</para>
                /// </summary>
                [NameInMap("segment_key")]
                [Validation(Required=false)]
                public string SegmentKey { get; set; }

                [NameInMap("segment_visa_remark")]
                [Validation(Required=false)]
                public IntlFlightRefundDetailResponseBodyModuleSegmentListSegmentVisaRemark SegmentVisaRemark { get; set; }
                public class IntlFlightRefundDetailResponseBodyModuleSegmentListSegmentVisaRemark : TeaModel {
                    [NameInMap("dep_city_visa_remark")]
                    [Validation(Required=false)]
                    public string DepCityVisaRemark { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("share")]
                [Validation(Required=false)]
                public bool? Share { get; set; }

                [NameInMap("short_flight_size")]
                [Validation(Required=false)]
                public string ShortFlightSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                [NameInMap("total_time")]
                [Validation(Required=false)]
                public string TotalTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
