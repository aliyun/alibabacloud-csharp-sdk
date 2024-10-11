// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListSkillGroupStatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSkillGroupStatesResponseBodyData Data { get; set; }
        public class ListSkillGroupStatesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListSkillGroupStatesResponseBodyDataList> List { get; set; }
            public class ListSkillGroupStatesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AverageWaitingTime")]
                [Validation(Required=false)]
                public long? AverageWaitingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BreakingAgents")]
                [Validation(Required=false)]
                public long? BreakingAgents { get; set; }

                [NameInMap("InboundTalkingAgents")]
                [Validation(Required=false)]
                public long? InboundTalkingAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LoggedInAgents")]
                [Validation(Required=false)]
                public long? LoggedInAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LongestCall")]
                [Validation(Required=false)]
                public long? LongestCall { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OutboundScenarioReadyAgents")]
                [Validation(Required=false)]
                public long? OutboundScenarioReadyAgents { get; set; }

                [NameInMap("OutboundTalkingAgents")]
                [Validation(Required=false)]
                public long? OutboundTalkingAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReadyAgents")]
                [Validation(Required=false)]
                public long? ReadyAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>skillgroup1@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

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
                [NameInMap("WaitingCallsLevel10")]
                [Validation(Required=false)]
                public long? WaitingCallsLevel10 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WaitingCallsLevel20")]
                [Validation(Required=false)]
                public long? WaitingCallsLevel20 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WaitingCallsLevel30")]
                [Validation(Required=false)]
                public long? WaitingCallsLevel30 { get; set; }

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
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
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
        /// <para>1F69EBB0-63E9-5DDE-887F-9FC040ADF309</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
