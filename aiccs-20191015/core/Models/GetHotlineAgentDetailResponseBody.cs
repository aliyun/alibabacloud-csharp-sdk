// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineAgentDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Agent service data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotlineAgentDetailResponseBodyData Data { get; set; }
        public class GetHotlineAgentDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2235****</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// <para>Agent status. Valid values: <b>1~6</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public int? AgentStatus { get; set; }

            /// <summary>
            /// <para>Agent status code. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>AgentCheckout</b>: Agent logged off.  </description></item>
            /// <item><description><b>AgentReady</b>: Agent idle.  </description></item>
            /// <item><description><b>AgentBreak</b>: Agent on break.  </description></item>
            /// <item><description><b>AgentAcw</b>: Post-processing after a call.  </description></item>
            /// <item><description><b>AgentBusyForCall</b>: In a call.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AgentCheckout</para>
            /// </summary>
            [NameInMap("AgentStatusCode")]
            [Validation(Required=false)]
            public string AgentStatusCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the agent is assigned. Valid values:<br><b>false</b>: Not assigned (no call).<br><b>true</b>: Assigned (in a call).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Assigned")]
            [Validation(Required=false)]
            public bool? Assigned { get; set; }

            /// <summary>
            /// <para>Break type. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Short break.  </description></item>
            /// <item><description><b>2</b>: Meal break.  </description></item>
            /// <item><description><b>3</b>: Meeting.  </description></item>
            /// <item><description><b>4</b>: Coaching.  </description></item>
            /// <item><description><b>5</b>: Training.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RestType")]
            [Validation(Required=false)]
            public int? RestType { get; set; }

            /// <summary>
            /// <para>Tenant ID to which the agent belongs, corresponding to the instance ID in the input parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc_xp_pre-cn-***</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>Heartbeat signature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dnthF_oinHg7JMJDmKqex3Ux****</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
