// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopConsultResponseBody : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightReShopConsultResponseBodyModule Module { get; set; }
        public class IntlFlightReShopConsultResponseBodyModule : TeaModel {
            [NameInMap("passenger_journey_group_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoList> PassengerJourneyGroupInfoList { get; set; }
            public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoList : TeaModel {
                [NameInMap("passenger_journey_group_key")]
                [Validation(Required=false)]
                public string PassengerJourneyGroupKey { get; set; }

                [NameInMap("passenger_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerList> PassengerList { get; set; }
                public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerList : TeaModel {
                    [NameInMap("full_name")]
                    [Validation(Required=false)]
                    public string FullName { get; set; }

                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public long? PassengerId { get; set; }

                }

                [NameInMap("passenger_segment_status_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerSegmentStatusInfoList> PassengerSegmentStatusInfoList { get; set; }
                public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListPassengerSegmentStatusInfoList : TeaModel {
                    [NameInMap("can_re_shop")]
                    [Validation(Required=false)]
                    public bool? CanReShop { get; set; }

                    [NameInMap("passenger_id")]
                    [Validation(Required=false)]
                    public long? PassengerId { get; set; }

                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                    [NameInMap("un_re_shop_reason")]
                    [Validation(Required=false)]
                    public string UnReShopReason { get; set; }

                    [NameInMap("un_re_shop_reason_code")]
                    [Validation(Required=false)]
                    public string UnReShopReasonCode { get; set; }

                }

                [NameInMap("re_shop_reason_info_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListReShopReasonInfoList> ReShopReasonInfoList { get; set; }
                public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListReShopReasonInfoList : TeaModel {
                    [NameInMap("reason_code")]
                    [Validation(Required=false)]
                    public string ReasonCode { get; set; }

                    [NameInMap("reason_desc")]
                    [Validation(Required=false)]
                    public string ReasonDesc { get; set; }

                    [NameInMap("voluntary")]
                    [Validation(Required=false)]
                    public bool? Voluntary { get; set; }

                }

                [NameInMap("segment_list")]
                [Validation(Required=false)]
                public List<IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListSegmentList> SegmentList { get; set; }
                public class IntlFlightReShopConsultResponseBodyModulePassengerJourneyGroupInfoListSegmentList : TeaModel {
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                    [NameInMap("journey_index")]
                    [Validation(Required=false)]
                    public int? JourneyIndex { get; set; }

                    [NameInMap("segment_index")]
                    [Validation(Required=false)]
                    public int? SegmentIndex { get; set; }

                    [NameInMap("segment_key")]
                    [Validation(Required=false)]
                    public string SegmentKey { get; set; }

                }

            }

        }

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
