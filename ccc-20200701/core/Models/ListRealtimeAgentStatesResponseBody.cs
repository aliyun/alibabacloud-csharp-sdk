// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRealtimeAgentStatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRealtimeAgentStatesResponseBodyData Data { get; set; }
        public class ListRealtimeAgentStatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of real-time agent status data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListRealtimeAgentStatesResponseBodyDataList> List { get; set; }
            public class ListRealtimeAgentStatesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent1@ccc-test</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>Agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>坐席小王</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>Break code.</para>
                /// <para><b>Enumeration values:</b></para>
                /// <list type="bullet">
                /// <item><description><para>RingingTimeout: Break caused by agent ringing timeout.</para>
                /// </description></item>
                /// <item><description><para>RejectCall: Break caused by agent call rejection.</para>
                /// </description></item>
                /// <item><description><para>Warm-up: Temporary break state after the agent is published and before becoming idle.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Warm-up</para>
                /// </summary>
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                /// <summary>
                /// <para>Call type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Outbound</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>Used in specific three-party scenarios, primarily for listener, coaching, and consultation. In three-party scenarios, it represents the third party—for example, the agent being monitored or coached in a listener or coaching scenario, or the agent or external number to which a call is transferred in a consultation scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("CounterParty")]
                [Validation(Required=false)]
                public string CounterParty { get; set; }

                /// <summary>
                /// <para>Duration of the current status, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The agent\&quot;s extension number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80317391</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The agent\&quot;s personal phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1382114****</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>Whether the agent is in outbound-only mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                /// <summary>
                /// <para>List of skill group IDs that the agent has signed into.</para>
                /// </summary>
                [NameInMap("SkillGroupIdList")]
                [Validation(Required=false)]
                public List<string> SkillGroupIdList { get; set; }

                /// <summary>
                /// <para>List of skill group names that the agent has signed into.</para>
                /// </summary>
                [NameInMap("SkillGroupNameList")]
                [Validation(Required=false)]
                public List<string> SkillGroupNameList { get; set; }

                /// <summary>
                /// <para>Agent status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACW</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>Sub-status. In some scenarios, the agent\&quot;s status cannot be fully represented by the State field alone, so a sub-status is required for clarification. For example, when an agent is being monitored, State=Talking and StateCode=Monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Monitored</para>
                /// </summary>
                [NameInMap("StateCode")]
                [Validation(Required=false)]
                public string StateCode { get; set; }

                /// <summary>
                /// <para>Time when the status started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1696670640774</para>
                /// </summary>
                [NameInMap("StateTime")]
                [Validation(Required=false)]
                public long? StateTime { get; set; }

                /// <summary>
                /// <para>Work mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON_SITE</para>
                /// </summary>
                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

            /// <summary>
            /// <para>Page number, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
