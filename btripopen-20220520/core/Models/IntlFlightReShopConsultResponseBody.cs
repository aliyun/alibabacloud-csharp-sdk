// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopConsultResponseBody : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightReShopConsultResponseBodyModule Module { get; set; }
        public class IntlFlightReShopConsultResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of passenger journey group information.</para>
            /// <remarks>
            /// <para>Notes for submitting a rebooking request:</para>
            /// <list type="bullet">
            /// <item><description>Groups from different categories cannot be submitted together for rebooking.</description></item>
            /// <item><description>Within the same group, the segments submitted for rebooking must have a rebookable status.</description></item>
            /// <item><description>Within the same group, if different passengers have the same segment status, they can be submitted together for rebooking. If the statuses differ, submit them separately.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("passenger_journey_group_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoList> PassengerJourneyGroupInfoList { get; set; }
            public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoList : TeaModel {
                /// <summary>
                /// <para>The unique key of the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edcac4f4c79d40ccb141ddb6da567e65</para>
                /// </summary>
                [NameInMap("passenger_journey_group_key")]
                [Validation(Required=false)]
                public string PassengerJourneyGroupKey { get; set; }

                /// <summary>
                /// <para>The list of passengers.</para>
                /// </summary>
                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerList> PassengerList { get; set; }
                public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerList : TeaModel {
                    /// <summary>
                    /// <para>The full name of the passenger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ZHANG/SAN</para>
                    /// </summary>
                    [NameInMap("full_name")]
                    [Validation(Required=false)]
                    public string FullName { get; set; }

                    /// <summary>
                    /// <para>The passenger ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000001</para>
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public long? PassengerId { get; set; }

                }

                /// <summary>
                /// <para>The list of status information for passenger segments.</para>
                /// </summary>
                [NameInMap("passenger_segment_status_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerSegmentStatusInfoList> PassengerSegmentStatusInfoList { get; set; }
                public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerSegmentStatusInfoList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether rebooking is allowed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Rebookable.</description></item>
                    /// <item><description>false: Not rebookable.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("can_re_shop")]
                    [Validation(Required=false)]
                    public bool? CanReShop { get; set; }

                    /// <summary>
                    /// <para>The passenger ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000001</para>
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public long? PassengerId { get; set; }

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
                    /// <para>The reason description for why rebooking is not allowed. This field has no value if rebooking is allowed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>客票已使用，不可改签</para>
                    /// </summary>
                    [NameInMap("un_re_shop_reason")]
                    [Validation(Required=false)]
                    public string UnReShopReason { get; set; }

                    /// <summary>
                    /// <para>The reason code for why rebooking is not allowed. This field has no value if rebooking is allowed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: Ticket has been refunded.</description></item>
                    /// <item><description>2: Refund in progress.</description></item>
                    /// <item><description>3: Ticket has been used.</description></item>
                    /// <item><description>4: Ticket has been voided.</description></item>
                    /// <item><description>5: Ticket number does not exist.</description></item>
                    /// <item><description>6: Already checked in.</description></item>
                    /// <item><description>7: Already rebooked.</description></item>
                    /// <item><description>8: Suspended.</description></item>
                    /// <item><description>9: Rebooking in progress.</description></item>
                    /// <item><description>10: Unavailable.</description></item>
                    /// <item><description>11: Boarding pass already printed.</description></item>
                    /// <item><description>12: Airport control.</description></item>
                    /// <item><description>14: No ticket control authority.</description></item>
                    /// <item><description>99: Ticket status does not allow rebooking submission.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("un_re_shop_reason_code")]
                    [Validation(Required=false)]
                    public string UnReShopReasonCode { get; set; }

                }

                /// <summary>
                /// <para>The list of available rebooking reason information.</para>
                /// </summary>
                [NameInMap("re_shop_reason_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListReShopReasonInfoList> ReShopReasonInfoList { get; set; }
                public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListReShopReasonInfoList : TeaModel {
                    /// <summary>
                    /// <para>The reason code. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: Flight change required due to passenger\&quot;s own reasons.</description></item>
                    /// <item><description>1: Flight delayed or canceled due to airline, airport, or weather reasons.</description></item>
                    /// <item><description>-1: Unknown.</description></item>
                    /// </list>
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
                    /// <para>因乘客自身原因需变更航班</para>
                    /// </summary>
                    [NameInMap("reason_desc")]
                    [Validation(Required=false)]
                    public string ReasonDesc { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the rebooking is voluntary.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("voluntary")]
                    [Validation(Required=false)]
                    public bool? Voluntary { get; set; }

                }

                /// <summary>
                /// <para>The list of segments.</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListSegmentList> SegmentList { get; set; }
                public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListSegmentList : TeaModel {
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
                    /// <para>The three-letter code of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure time. Format: yyyy-MM-dd HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-06-16 19:20</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The marketing flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CZ5009</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    /// <summary>
                    /// <para>The journey index, starting from 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

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

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>The global trace identifier for the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
