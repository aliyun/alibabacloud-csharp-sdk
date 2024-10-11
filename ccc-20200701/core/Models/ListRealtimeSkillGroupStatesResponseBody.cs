// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRealtimeSkillGroupStatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRealtimeSkillGroupStatesResponseBodyData Data { get; set; }
        public class ListRealtimeSkillGroupStatesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListRealtimeSkillGroupStatesResponseBodyDataList> List { get; set; }
            public class ListRealtimeSkillGroupStatesResponseBodyDataList : TeaModel {
                [NameInMap("BreakCodeDetailList")]
                [Validation(Required=false)]
                public List<ListRealtimeSkillGroupStatesResponseBodyDataListBreakCodeDetailList> BreakCodeDetailList { get; set; }
                public class ListRealtimeSkillGroupStatesResponseBodyDataListBreakCodeDetailList : TeaModel {
                    [NameInMap("BreakCode")]
                    [Validation(Required=false)]
                    public string BreakCode { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BreakingAgents")]
                [Validation(Required=false)]
                public long? BreakingAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LoggedInAgents")]
                [Validation(Required=false)]
                public long? LoggedInAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LongestWaitingTime")]
                [Validation(Required=false)]
                public long? LongestWaitingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OutboundScenarioReadyAgents")]
                [Validation(Required=false)]
                public long? OutboundScenarioReadyAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ReadyAgents")]
                [Validation(Required=false)]
                public long? ReadyAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>skillgroup</para>
                /// </summary>
                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TalkingAgents")]
                [Validation(Required=false)]
                public long? TalkingAgents { get; set; }

                [NameInMap("TotalAgents")]
                [Validation(Required=false)]
                public long? TotalAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WaitingCalls")]
                [Validation(Required=false)]
                public long? WaitingCalls { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WorkingAgents")]
                [Validation(Required=false)]
                public long? WorkingAgents { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26A34338-5CD9-4C95-A7A6-5BDCE76C6B94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
