// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineAgentDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The agent service data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotlineAgentDetailResponseBodyData Data { get; set; }
        public class GetHotlineAgentDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2235****</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>The agent status. Valid values: <b>1</b> to <b>6</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public int? AgentStatus { get; set; }

            /// <summary>
            /// <para>The agent status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AgentCheckout</b>: off duty</description></item>
            /// <item><description><b>AgentReady</b>: idle</description></item>
            /// <item><description><b>AgentBreak</b>: on break</description></item>
            /// <item><description><b>AgentAcw</b>: in after-call work</description></item>
            /// <item><description><b>AgentBusyForCall</b>: on a call</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AgentCheckout</para>
            /// </summary>
            [NameInMap("AgentStatusCode")]
            [Validation(Required=false)]
            public string AgentStatusCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the agent is assigned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: not assigned (no active calls)</description></item>
            /// <item><description><b>true</b>: assigned (active calls)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Assigned")]
            [Validation(Required=false)]
            public bool? Assigned { get; set; }

            /// <summary>
            /// <para>The break type. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: break</description></item>
            /// <item><description><b>2</b>: meal</description></item>
            /// <item><description><b>3</b>: meeting</description></item>
            /// <item><description><b>4</b>: coaching</description></item>
            /// <item><description><b>5</b>: training</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RestType")]
            [Validation(Required=false)]
            public int? RestType { get; set; }

            /// <summary>
            /// <para>The ID of the tenant to which the agent belongs. This ID corresponds to the instance ID in the request parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>205282</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The heartbeat signature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dnthF_oinHg7JMJDmKqex3Ux****</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: successful</description></item>
        /// <item><description><b>false</b>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
