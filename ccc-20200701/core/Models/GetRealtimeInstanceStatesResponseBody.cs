// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetRealtimeInstanceStatesResponseBody : TeaModel {
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
        public GetRealtimeInstanceStatesResponseBodyData Data { get; set; }
        public class GetRealtimeInstanceStatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of distributions of break code counts.</para>
            /// </summary>
            [NameInMap("BreakCodeDetailList")]
            [Validation(Required=false)]
            public List<GetRealtimeInstanceStatesResponseBodyDataBreakCodeDetailList> BreakCodeDetailList { get; set; }
            public class GetRealtimeInstanceStatesResponseBodyDataBreakCodeDetailList : TeaModel {
                /// <summary>
                /// <para>Break code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>默认</para>
                /// </summary>
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                /// <summary>
                /// <para>Break count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

            }

            /// <summary>
            /// <para>Number of agents on break.</para>
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
            /// <para>Number of calls interacting within IVR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InteractiveCalls")]
            [Validation(Required=false)]
            public long? InteractiveCalls { get; set; }

            /// <summary>
            /// <para>Number of logged-in agents (including agents in ready, on break, on call, or other non-unpublished statuses).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LoggedInAgents")]
            [Validation(Required=false)]
            public long? LoggedInAgents { get; set; }

            /// <summary>
            /// <para>Maximum queue waiting time among currently queued incoming calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LongestWaitingTime")]
            [Validation(Required=false)]
            public long? LongestWaitingTime { get; set; }

            /// <summary>
            /// <para>Number of agents in ready status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReadyAgents")]
            [Validation(Required=false)]
            public long? ReadyAgents { get; set; }

            /// <summary>
            /// <para>Number of agents on calls.</para>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalAgents")]
            [Validation(Required=false)]
            public long? TotalAgents { get; set; }

            /// <summary>
            /// <para>Number of incoming calls currently queued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WaitingCalls")]
            [Validation(Required=false)]
            public long? WaitingCalls { get; set; }

            /// <summary>
            /// <para>Number of agents in post-processing status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WorkingAgents")]
            [Validation(Required=false)]
            public long? WorkingAgents { get; set; }

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
        /// <para>943D8EF3-3321-471F-A104-51C96FCA94D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
