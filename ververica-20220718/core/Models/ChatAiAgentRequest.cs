// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ChatAiAgentRequest : TeaModel {
        /// <summary>
        /// <para>The list of Human-in-the-Loop (HITL) approval decisions, used to resume a session interrupted by a hitlPending event.</para>
        /// </summary>
        [NameInMap("hitlDecisions")]
        [Validation(Required=false)]
        public List<ChatAiAgentRequestHitlDecisions> HitlDecisions { get; set; }
        public class ChatAiAgentRequestHitlDecisions : TeaModel {
            /// <summary>
            /// <para>The approval decision. Valid values: approve and deny.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approve</para>
            /// </summary>
            [NameInMap("decision")]
            [Validation(Required=false)]
            public string Decision { get; set; }

            /// <summary>
            /// <para>The approval item ID corresponding to the hitlPending event.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("hitlId")]
            [Validation(Required=false)]
            public string HitlId { get; set; }

        }

        /// <summary>
        /// <para>The resource references, including jobs and skill lists.</para>
        /// </summary>
        [NameInMap("refs")]
        [Validation(Required=false)]
        public ChatAiAgentRequestRefs Refs { get; set; }
        public class ChatAiAgentRequestRefs : TeaModel {
            /// <summary>
            /// <para>The list of job references.</para>
            /// </summary>
            [NameInMap("jobs")]
            [Validation(Required=false)]
            public List<ChatAiAgentRequestRefsJobs> Jobs { get; set; }
            public class ChatAiAgentRequestRefsJobs : TeaModel {
                /// <summary>
                /// <para>Deployment ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>2a63abb7-7ae7-4902-9970-fe5cff4bd7c1</para>
                /// </summary>
                [NameInMap("deploymentId")]
                [Validation(Required=false)]
                public string DeploymentId { get; set; }

                /// <summary>
                /// <para>Job ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccb853c3-1d5a-438d-bf98-346815ad875a</para>
                /// </summary>
                [NameInMap("jobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            /// <summary>
            /// <para>The list of skills to inject.</para>
            /// </summary>
            [NameInMap("skills")]
            [Validation(Required=false)]
            public List<string> Skills { get; set; }

        }

        /// <summary>
        /// <para>The session ID. If not specified, the server generates one. For multi-turn conversations, pass the same value across requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F8CC7-EAD3-5E06-B0BF-3A2A0638B3DD-deliverData-20260723102220-VM8X0A5VZQ</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The user natural language input. The value must be 1 to 64,000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("userMessage")]
        [Validation(Required=false)]
        public string UserMessage { get; set; }

    }

}
