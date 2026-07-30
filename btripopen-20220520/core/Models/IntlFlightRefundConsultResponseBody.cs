// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightRefundConsultResponseBody : TeaModel {
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightRefundConsultResponseBodyModule Module { get; set; }
        public class IntlFlightRefundConsultResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of passenger journey group information.</para>
            /// <remarks>
            /// <para>Notes for submitting a refund request:</para>
            /// <list type="bullet">
            /// <item><description>Segments from different groups cannot be submitted together for a refund.</description></item>
            /// <item><description>Within the same group, the status of the segments submitted for a refund must be refundable.</description></item>
            /// <item><description>Within the same group, if the segment statuses of different passengers are the same, you can submit a refund request together. Otherwise, submit separate requests.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("passenger_journey_group_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoList> PassengerJourneyGroupInfoList { get; set; }
            public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoList : TeaModel {
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
                public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerList> PassengerList { get; set; }
                public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerList : TeaModel {
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
                /// <para>The list of status information for each passenger segment.</para>
                /// </summary>
                [NameInMap("passenger_segment_status_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerSegmentStatusInfoList> PassengerSegmentStatusInfoList { get; set; }
                public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerSegmentStatusInfoList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the ticket is refundable. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Refundable.</description></item>
                    /// <item><description>false: Not refundable.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("can_refund")]
                    [Validation(Required=false)]
                    public bool? CanRefund { get; set; }

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
                    /// <para>The description of the reason why the ticket is not refundable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>客票已使用，不可退票</para>
                    /// </summary>
                    [NameInMap("un_refund_reason")]
                    [Validation(Required=false)]
                    public string UnRefundReason { get; set; }

                    /// <summary>
                    /// <para>The reason code for why the ticket is not refundable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("un_refund_reason_code")]
                    [Validation(Required=false)]
                    public string UnRefundReasonCode { get; set; }

                }

                /// <summary>
                /// <para>The list of available refund reasons.</para>
                /// </summary>
                [NameInMap("refund_reason_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListRefundReasonInfoList> RefundReasonInfoList { get; set; }
                public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListRefundReasonInfoList : TeaModel {
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
                    /// <para>The description of the refund reason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>因个人原因取消行程计划（退票费由个人承担）</para>
                    /// </summary>
                    [NameInMap("reason_desc")]
                    [Validation(Required=false)]
                    public string ReasonDesc { get; set; }

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
                /// <para>The list of flight segments.</para>
                /// </summary>
                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListSegmentList> SegmentList { get; set; }
                public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListSegmentList : TeaModel {
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
                    /// <para>The segment index within the same journey, starting from 0.</para>
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
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
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
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
