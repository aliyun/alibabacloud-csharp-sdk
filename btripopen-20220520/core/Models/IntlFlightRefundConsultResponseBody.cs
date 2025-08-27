// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightRefundConsultResponseBody : TeaModel {
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
        public IntlFlightRefundConsultResponseBodyModule Module { get; set; }
        public class IntlFlightRefundConsultResponseBodyModule : TeaModel {
            [NameInMap("passenger_journey_group_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoList> PassengerJourneyGroupInfoList { get; set; }
            public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>edcac4f4c79d40ccb141ddb6da567e65</para>
                /// </summary>
                [NameInMap("passenger_journey_group_key")]
                [Validation(Required=false)]
                public string PassengerJourneyGroupKey { get; set; }

                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerList> PassengerList { get; set; }
                public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZHANG/SAN</para>
                    /// </summary>
                    [NameInMap("full_name")]
                    [Validation(Required=false)]
                    public string FullName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000001</para>
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public long? PassengerId { get; set; }

                }

                [NameInMap("passenger_segment_status_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerSegmentStatusInfoList> PassengerSegmentStatusInfoList { get; set; }
                public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerSegmentStatusInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("can_refund")]
                    [Validation(Required=false)]
                    public bool? CanRefund { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000001</para>
                    /// </summary>
                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public long? PassengerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CZ5009PKXHKG0616</para>
                    /// </summary>
                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    [NameInMap("un_refund_reason")]
                    [Validation(Required=false)]
                    public string UnRefundReason { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("un_refund_reason_code")]
                    [Validation(Required=false)]
                    public string UnRefundReasonCode { get; set; }

                }

                [NameInMap("refund_reason_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListRefundReasonInfoList> RefundReasonInfoList { get; set; }
                public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListRefundReasonInfoList : TeaModel {
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
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("voluntary")]
                    [Validation(Required=false)]
                    public bool? Voluntary { get; set; }

                }

                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListSegmentList> SegmentList { get; set; }
                public class IntlFlightRefundConsultResponseBodyModulePassengerJourneyGroupInfoListSegmentList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HKG</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-06-16 19:20</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CZ5009</para>
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

                    /// <summary>
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
