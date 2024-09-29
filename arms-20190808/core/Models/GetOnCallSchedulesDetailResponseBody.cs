// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetOnCallSchedulesDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the scheduling policy.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOnCallSchedulesDetailResponseBodyData Data { get; set; }
        public class GetOnCallSchedulesDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL of the DingTalk chatbot, which is used to receive notifications about shift changes.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=69d4e009547e11069c6513309414937b7bf0482fb9284125b5">https://oapi.dingtalk.com/robot/send?access_token=69d4e009547e11069c6513309414937b7bf0482fb9284125b5</a>******</para>
            /// </summary>
            [NameInMap("AlertRobotId")]
            [Validation(Required=false)]
            public long? AlertRobotId { get; set; }

            /// <summary>
            /// <para>The description of the scheduling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the scheduling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the scheduling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduling policy test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The information about the final user on duty.</para>
            /// </summary>
            [NameInMap("RenderedFinnalEntries")]
            [Validation(Required=false)]
            public List<GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntries> RenderedFinnalEntries { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntries : TeaModel {
                /// <summary>
                /// <para>The date on which the user completed shift work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-30</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>The information about the user on duty.</para>
                /// </summary>
                [NameInMap("SimpleContact")]
                [Validation(Required=false)]
                public GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntriesSimpleContact SimpleContact { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataRenderedFinnalEntriesSimpleContact : TeaModel {
                    /// <summary>
                    /// <para>The ID of the user on duty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the user on duty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Employee 1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The date from which the user started shift work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-01</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <para>The scheduled users on duty within a time range.</para>
            /// </summary>
            [NameInMap("RenderedLayerEntries")]
            [Validation(Required=false)]
            public List<List<GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntries>> RenderedLayerEntries { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntries : TeaModel {
                /// <summary>
                /// <para>The date from which the scheduled user was supposed to start shift work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-01</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

                /// <summary>
                /// <para>The date on which the scheduled user was supposed to complete shift work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-30</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>The information about the scheduled user.</para>
                /// </summary>
                [NameInMap("SimpleContact")]
                [Validation(Required=false)]
                public GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntriesSimpleContact SimpleContact { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataRenderedLayerEntriesSimpleContact : TeaModel {
                    /// <summary>
                    /// <para>The ID of the scheduled user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the scheduled user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Employee 1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the substitutes within a time range.</para>
            /// </summary>
            [NameInMap("RenderedSubstitudeEntries")]
            [Validation(Required=false)]
            public List<GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntries> RenderedSubstitudeEntries { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntries : TeaModel {
                /// <summary>
                /// <para>The date on which the substitute was supposed to complete shift work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-30</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>The information about the substitute.</para>
                /// </summary>
                [NameInMap("SimpleContact")]
                [Validation(Required=false)]
                public GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntriesSimpleContact SimpleContact { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataRenderedSubstitudeEntriesSimpleContact : TeaModel {
                    /// <summary>
                    /// <para>The ID of the substitute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>234</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the substitute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Employee 2</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The date from which the substitute was supposed to start shift work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-01</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <para>The information about the shift.</para>
            /// </summary>
            [NameInMap("ScheduleLayers")]
            [Validation(Required=false)]
            public List<GetOnCallSchedulesDetailResponseBodyDataScheduleLayers> ScheduleLayers { get; set; }
            public class GetOnCallSchedulesDetailResponseBodyDataScheduleLayers : TeaModel {
                /// <summary>
                /// <para>The ID list of users on duty.</para>
                /// </summary>
                [NameInMap("ContactIds")]
                [Validation(Required=false)]
                public List<long?> ContactIds { get; set; }

                /// <summary>
                /// <para>The limit on the time of the shift.</para>
                /// </summary>
                [NameInMap("Restrictions")]
                [Validation(Required=false)]
                public List<GetOnCallSchedulesDetailResponseBodyDataScheduleLayersRestrictions> Restrictions { get; set; }
                public class GetOnCallSchedulesDetailResponseBodyDataScheduleLayersRestrictions : TeaModel {
                    /// <summary>
                    /// <para>The end time of the shift per day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18:00</para>
                    /// </summary>
                    [NameInMap("EndTimeOfDay")]
                    [Validation(Required=false)]
                    public string EndTimeOfDay { get; set; }

                    /// <summary>
                    /// <para>The type of the limit. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>daily_restriction</description></item>
                    /// <item><description>weekly_restriction</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>daily_restriction</para>
                    /// </summary>
                    [NameInMap("RestrictionType")]
                    [Validation(Required=false)]
                    public string RestrictionType { get; set; }

                    /// <summary>
                    /// <para>The start time of the shift per day.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>09:00</para>
                    /// </summary>
                    [NameInMap("StartTimeOfDay")]
                    [Validation(Required=false)]
                    public string StartTimeOfDay { get; set; }

                }

                /// <summary>
                /// <para>The type of the shift. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DAY</description></item>
                /// <item><description>WEEK</description></item>
                /// <item><description>CUSTOM</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DAY</para>
                /// </summary>
                [NameInMap("RotationType")]
                [Validation(Required=false)]
                public string RotationType { get; set; }

                /// <summary>
                /// <para>The shift cycle. Unit: hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("ShiftLength")]
                [Validation(Required=false)]
                public long? ShiftLength { get; set; }

                /// <summary>
                /// <para>The date on which the shift change took effect.</para>
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
