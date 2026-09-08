// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRealtimeSkillGroupStatesResponseBody : TeaModel {
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
        public ListRealtimeSkillGroupStatesResponseBodyData Data { get; set; }
        public class ListRealtimeSkillGroupStatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of real-time skill group status data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListRealtimeSkillGroupStatesResponseBodyDataList> List { get; set; }
            public class ListRealtimeSkillGroupStatesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Break statistics.</para>
                /// </summary>
                [NameInMap("BreakCodeDetailList")]
                [Validation(Required=false)]
                public List<ListRealtimeSkillGroupStatesResponseBodyDataListBreakCodeDetailList> BreakCodeDetailList { get; set; }
                public class ListRealtimeSkillGroupStatesResponseBodyDataListBreakCodeDetailList : TeaModel {
                    /// <summary>
                    /// <para>Break status code</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>客户自定义参数，比如午餐、会议等</para>
                    /// </summary>
                    [NameInMap("BreakCode")]
                    [Validation(Required=false)]
                    public string BreakCode { get; set; }

                    /// <summary>
                    /// <para>The number of times the break status occurred</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

                /// <summary>
                /// <para>Number of agents currently on break.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BreakingAgents")]
                [Validation(Required=false)]
                public long? BreakingAgents { get; set; }

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
                /// <para>Number of agents currently logged in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LoggedInAgents")]
                [Validation(Required=false)]
                public long? LoggedInAgents { get; set; }

                /// <summary>
                /// <para>Current maximum queue waiting time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LongestWaitingTime")]
                [Validation(Required=false)]
                public long? LongestWaitingTime { get; set; }

                /// <summary>
                /// <para>Number of agents in outbound-only mode and in an idle status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OutboundScenarioReadyAgents")]
                [Validation(Required=false)]
                public long? OutboundScenarioReadyAgents { get; set; }

                /// <summary>
                /// <para>Number of agents currently idle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ReadyAgents")]
                [Validation(Required=false)]
                public long? ReadyAgents { get; set; }

                /// <summary>
                /// <para>Skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                /// <summary>
                /// <para>Skill group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup</para>
                /// </summary>
                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

                /// <summary>
                /// <para>Number of agents currently on a call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TalkingAgents")]
                [Validation(Required=false)]
                public long? TalkingAgents { get; set; }

                /// <summary>
                /// <para>Total number of agents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("TotalAgents")]
                [Validation(Required=false)]
                public long? TotalAgents { get; set; }

                /// <summary>
                /// <para>Number of calls currently in the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WaitingCalls")]
                [Validation(Required=false)]
                public long? WaitingCalls { get; set; }

                /// <summary>
                /// <para>Number of agents currently in post-processing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WorkingAgents")]
                [Validation(Required=false)]
                public long? WorkingAgents { get; set; }

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
            /// <para>2</para>
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
        /// <para>26A34338-5CD9-4C95-A7A6-5BDCE76C6B94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
