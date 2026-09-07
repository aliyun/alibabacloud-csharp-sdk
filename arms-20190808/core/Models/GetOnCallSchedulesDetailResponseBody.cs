// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetOnCallSchedulesDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the on-call schedule.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOnCallSchedulesDetailResponseBodyData Data { get; set; }
        public class GetOnCallSchedulesDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The webhook URL of the DingTalk bot for rotation notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=69d4e009547e11069c6513309414937b7bf0482fb9284125b5">https://oapi.dingtalk.com/robot/send?access_token=69d4e009547e11069c6513309414937b7bf0482fb9284125b5</a>******</para>
            /// </summary>
            [NameInMap("AlertRobotId")]
            [Validation(Required=false)]
            public long? AlertRobotId { get; set; }

            /// <summary>
            /// <para>The description of the on-call schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the on-call schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the on-call schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>排班策略测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The final list of on-call contacts, after accounting for all rotations and substitutions.</para>
            /// </summary>
            [NameInMap("RenderedFinnalEntries")]
            [Validation(Required=false)]
            public List<GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntries> RenderedFinnalEntries { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntries : TeaModel {
                /// <summary>
                /// <para>The end time of the on-call duty for the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-30</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>Details of the final on-call contact.</para>
                /// </summary>
                [NameInMap("SimpleContact")]
                [Validation(Required=false)]
                public GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntriesSimpleContact SimpleContact { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntriesSimpleContact : TeaModel {
                    /// <summary>
                    /// <para>The contact ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The contact name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>员工1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The start time of the on-call duty for the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-01</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <para>A list of contacts on duty within the specified time range, as defined by the schedule layers.</para>
            /// </summary>
            [NameInMap("RenderedLayerEntries")]
            [Validation(Required=false)]
            public List<List<GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntries>> RenderedLayerEntries { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntries : TeaModel {
                /// <summary>
                /// <para>The start time of the on-call duty for the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-01</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

                /// <summary>
                /// <para>The end time of the on-call duty for the contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-30</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>Details of the on-duty contact.</para>
                /// </summary>
                [NameInMap("SimpleContact")]
                [Validation(Required=false)]
                public GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntriesSimpleContact SimpleContact { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntriesSimpleContact : TeaModel {
                    /// <summary>
                    /// <para>The contact ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The contact name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>员工1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>A list of substitutes scheduled within the specified time range.</para>
            /// </summary>
            [NameInMap("RenderedSubstitudeEntries")]
            [Validation(Required=false)]
            public List<GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntries> RenderedSubstitudeEntries { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntries : TeaModel {
                /// <summary>
                /// <para>The end time of the on-call duty for the substitute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-30</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>Details of the substitute.</para>
                /// </summary>
                [NameInMap("SimpleContact")]
                [Validation(Required=false)]
                public GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntriesSimpleContact SimpleContact { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntriesSimpleContact : TeaModel {
                    /// <summary>
                    /// <para>The substitute ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>234</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The substitute name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>员工2</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The start time of the on-call duty for the substitute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-01</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <para>A list of schedule layers.</para>
            /// </summary>
            [NameInMap("ScheduleLayers")]
            [Validation(Required=false)]
            public List<GetOnCallSchedulesDetailResponseBodyDataScheduleLayers> ScheduleLayers { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataScheduleLayers : TeaModel {
                /// <summary>
                /// <para>A list of contact IDs for the schedule layer.</para>
                /// </summary>
                [NameInMap("ContactIds")]
                [Validation(Required=false)]
                public List<long?> ContactIds { get; set; }

                /// <summary>
                /// <para>A list of restrictions for the schedule layer.</para>
                /// </summary>
                [NameInMap("Restrictions")]
                [Validation(Required=false)]
                public List<GetOnCallSchedulesDetailResponseBodyDataScheduleLayersRestrictions> Restrictions { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataScheduleLayersRestrictions : TeaModel {
                    /// <summary>
                    /// <para>The end time for on-call duty each day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18:00</para>
                    /// </summary>
                    [NameInMap("EndTimeOfDay")]
                    [Validation(Required=false)]
                    public string EndTimeOfDay { get; set; }

                    /// <summary>
                    /// <para>The type of restriction. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>daily_restriction</c>: A daily time-based restriction.</para>
                    /// </description></item>
                    /// <item><description><para><c>weekly_restriction</c>: A weekly time-based restriction.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>daily_restriction</para>
                    /// </summary>
                    [NameInMap("RestrictionType")]
                    [Validation(Required=false)]
                    public string RestrictionType { get; set; }

                    /// <summary>
                    /// <para>The start time for on-call duty each day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>09:00</para>
                    /// </summary>
                    [NameInMap("StartTimeOfDay")]
                    [Validation(Required=false)]
                    public string StartTimeOfDay { get; set; }

                }

                /// <summary>
                /// <para>The rotation type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>DAY</c>: Rotates every day.</para>
                /// </description></item>
                /// <item><description><para><c>WEEK</c>: Rotates every week.</para>
                /// </description></item>
                /// <item><description><para><c>CUSTOM</c>: Rotates based on a custom schedule.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DAY</para>
                /// </summary>
                [NameInMap("RotationType")]
                [Validation(Required=false)]
                public string RotationType { get; set; }

                /// <summary>
                /// <para>The shift length for the rotation, in hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("ShiftLength")]
                [Validation(Required=false)]
                public long? ShiftLength { get; set; }

                /// <summary>
                /// <para>The start time for the rotation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-01</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21E85B16-75A6-429A-9F65-8AAC9A54****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
