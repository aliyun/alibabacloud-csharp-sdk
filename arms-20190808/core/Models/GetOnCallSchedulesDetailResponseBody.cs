// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetOnCallSchedulesDetailResponseBody : TeaModel {
        /// <summary>
        /// The information about the scheduling policy.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOnCallSchedulesDetailResponseBodyData Data { get; set; }
        public class GetOnCallSchedulesDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The URL of the DingTalk chatbot, which is used to receive notifications about shift changes.
            /// </summary>
            [NameInMap("AlertRobotId")]
            [Validation(Required=false)]
            public long? AlertRobotId { get; set; }

            /// <summary>
            /// The description of the scheduling policy.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the scheduling policy.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the scheduling policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The information about the final user on duty.
            /// </summary>
            [NameInMap("RenderedFinnalEntries")]
            [Validation(Required=false)]
            public List<GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntries> RenderedFinnalEntries { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntries : TeaModel {
                /// <summary>
                /// The date on which the user completed shift work.
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// The information about the user on duty.
                /// </summary>
                [NameInMap("SimpleContact")]
                [Validation(Required=false)]
                public GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntriesSimpleContact SimpleContact { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntriesSimpleContact : TeaModel {
                    /// <summary>
                    /// The ID of the user on duty.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The name of the user on duty.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The date from which the user started shift work.
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// The scheduled users on duty within a time range.
            /// </summary>
            [NameInMap("RenderedLayerEntries")]
            [Validation(Required=false)]
            public List<List<GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntries>> RenderedLayerEntries { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntries : TeaModel {
                /// <summary>
                /// The date from which the scheduled user was supposed to start shift work.
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

                /// <summary>
                /// The date on which the scheduled user was supposed to complete shift work.
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// The information about the scheduled user.
                /// </summary>
                [NameInMap("SimpleContact")]
                [Validation(Required=false)]
                public GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntriesSimpleContact SimpleContact { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntriesSimpleContact : TeaModel {
                    /// <summary>
                    /// The ID of the scheduled user.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The name of the scheduled user.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// The information about the substitutes within a time range.
            /// </summary>
            [NameInMap("RenderedSubstitudeEntries")]
            [Validation(Required=false)]
            public List<GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntries> RenderedSubstitudeEntries { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntries : TeaModel {
                /// <summary>
                /// The date on which the substitute was supposed to complete shift work.
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// The information about the substitute.
                /// </summary>
                [NameInMap("SimpleContact")]
                [Validation(Required=false)]
                public GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntriesSimpleContact SimpleContact { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntriesSimpleContact : TeaModel {
                    /// <summary>
                    /// The ID of the substitute.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The name of the substitute.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The date from which the substitute was supposed to start shift work.
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// The information about the shift.
            /// </summary>
            [NameInMap("ScheduleLayers")]
            [Validation(Required=false)]
            public List<GetOnCallSchedulesDetailResponseBodyDataScheduleLayers> ScheduleLayers { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataScheduleLayers : TeaModel {
                /// <summary>
                /// The ID list of users on duty.
                /// </summary>
                [NameInMap("ContactIds")]
                [Validation(Required=false)]
                public List<long?> ContactIds { get; set; }

                /// <summary>
                /// The limit on the time of the shift.
                /// </summary>
                [NameInMap("Restrictions")]
                [Validation(Required=false)]
                public List<GetOnCallSchedulesDetailResponseBodyDataScheduleLayersRestrictions> Restrictions { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataScheduleLayersRestrictions : TeaModel {
                    /// <summary>
                    /// The end time of the shift per day.
                    /// </summary>
                    [NameInMap("EndTimeOfDay")]
                    [Validation(Required=false)]
                    public string EndTimeOfDay { get; set; }

                    /// <summary>
                    /// The type of the limit. Valid values:
                    /// 
                    /// *   daily_restriction
                    /// *   weekly_restriction
                    /// </summary>
                    [NameInMap("RestrictionType")]
                    [Validation(Required=false)]
                    public string RestrictionType { get; set; }

                    /// <summary>
                    /// The start time of the shift per day.
                    /// </summary>
                    [NameInMap("StartTimeOfDay")]
                    [Validation(Required=false)]
                    public string StartTimeOfDay { get; set; }

                }

                /// <summary>
                /// The type of the shift. Valid values:
                /// 
                /// *   DAY
                /// *   WEEK
                /// *   CUSTOM
                /// </summary>
                [NameInMap("RotationType")]
                [Validation(Required=false)]
                public string RotationType { get; set; }

                /// <summary>
                /// The shift cycle. Unit: hours.
                /// </summary>
                [NameInMap("ShiftLength")]
                [Validation(Required=false)]
                public long? ShiftLength { get; set; }

                /// <summary>
                /// The date on which the shift change took effect.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
