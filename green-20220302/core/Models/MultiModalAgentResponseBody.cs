// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result of the image content detection.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MultiModalAgentResponseBodyData Data { get; set; }
        public class MultiModalAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26769ada6e264e7ba9aa048241e12be9</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The structure of the label item.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<MultiModalAgentResponseBodyDataResult> Result { get; set; }
            public class MultiModalAgentResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The description of the label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>未检测出风险</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The risk label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>A description of the result when the session is terminated.</para>
                /// <list type="bullet">
                /// <item><description><para><b>SESSION_KILLED</b>: The session was successfully terminated.</para>
                /// </description></item>
                /// <item><description><para><b>SESSION_EXPIRED</b>: The session has expired.</para>
                /// </description></item>
                /// <item><description><para><b>SESSION_NO_PERMISSION</b>: The account used to terminate the session does not have sufficient permissions.</para>
                /// </description></item>
                /// <item><description><para><b>SESSION_ACCOUNT_ERROR</b>: The account or password used to terminate the session is incorrect.</para>
                /// </description></item>
                /// <item><description><para><b>SESSION_IGNORED_USER</b>: The session of an account that does not need to be terminated.</para>
                /// </description></item>
                /// <item><description><para><b>SESSION_INTERNAL_USER_OR_COMMAND</b>: The session or command of an Alibaba Cloud operations account.</para>
                /// </description></item>
                /// <item><description><para><b>SESSION_KILL_TASK_TIMEOUT</b>: A timeout occurred when terminating the session.</para>
                /// </description></item>
                /// <item><description><para><b>SESSION_OTHER_ERROR</b>: Other errors.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TRACER_SLB_ALL_DEST_WEIGHT_0</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The risk level. The value is returned based on the configured high and low risk scores. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>high: High risk</para>
            /// </description></item>
            /// <item><description><para>medium: Medium risk</para>
            /// </description></item>
            /// <item><description><para>low: Low risk</para>
            /// </description></item>
            /// <item><description><para>none: No risk detected</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>Token usage.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public MultiModalAgentResponseBodyDataUsage Usage { get; set; }
            public class MultiModalAgentResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <para>Agent details.</para>
                /// </summary>
                [NameInMap("AgentDetail")]
                [Validation(Required=false)]
                public Dictionary<string, object> AgentDetail { get; set; }

                /// <summary>
                /// <para>The length of the content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ContentLength")]
                [Validation(Required=false)]
                public long? ContentLength { get; set; }

                /// <summary>
                /// <para>The length of the prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PromptLength")]
                [Validation(Required=false)]
                public long? PromptLength { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
