// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ClaimChatResponseBody : TeaModel {
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
        public ClaimChatResponseBodyData Data { get; set; }
        public class ClaimChatResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Session context.</para>
            /// </summary>
            [NameInMap("ChatContexts")]
            [Validation(Required=false)]
            public List<ClaimChatResponseBodyDataChatContexts> ChatContexts { get; set; }
            public class ClaimChatResponseBodyDataChatContexts : TeaModel {
                /// <summary>
                /// <para>Network service channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>226****-cbb6-****-8fea-1e71baf7bfa7</para>
                /// </summary>
                [NameInMap("AccessChannelId")]
                [Validation(Required=false)]
                public string AccessChannelId { get; set; }

                /// <summary>
                /// <para>Network service channel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试渠道</para>
                /// </summary>
                [NameInMap("AccessChannelName")]
                [Validation(Required=false)]
                public string AccessChannelName { get; set; }

                /// <summary>
                /// <para>Network service channel type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Web</para>
                /// </summary>
                [NameInMap("AccessChannelType")]
                [Validation(Required=false)]
                public string AccessChannelType { get; set; }

                /// <summary>
                /// <para>Whether the session has been assigned to an agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BeingAssigned")]
                [Validation(Required=false)]
                public bool? BeingAssigned { get; set; }

                /// <summary>
                /// <para>Call variables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("CallVariables")]
                [Validation(Required=false)]
                public string CallVariables { get; set; }

                /// <summary>
                /// <para>Session type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INBOUND</para>
                /// </summary>
                [NameInMap("ChatType")]
                [Validation(Required=false)]
                public string ChatType { get; set; }

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
                /// <para>Job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chat-65382141036853491</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            /// <summary>
            /// <para>System auto-increment ID. Customers do not need to be concerned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public long? ContextId { get; set; }

            /// <summary>
            /// <para>Agent context.</para>
            /// </summary>
            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public ClaimChatResponseBodyDataUserContext UserContext { get; set; }
            public class ClaimChatResponseBodyDataUserContext : TeaModel {
                /// <summary>
                /// <para>Break status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Warm-up</para>
                /// </summary>
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                /// <summary>
                /// <para>Device ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CCC-169.254.165.2-browser125.0.0-bs48b41903450e6c8</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <para>Device state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("DeviceState")]
                [Validation(Required=false)]
                public string DeviceState { get; set; }

                /// <summary>
                /// <para>Agent extension number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8032****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>Time of the agent\&quot;s last heartbeat, in Unix timestamp format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1609136956378</para>
                /// </summary>
                [NameInMap("Heartbeat")]
                [Validation(Required=false)]
                public long? Heartbeat { get; set; }

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
                /// <para>Job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chat-65382141036853491</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>Agent\&quot;s personal phone number. Not applicable for chat scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18******102</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>Outbound call scenario only. Not applicable for chat services.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                /// <summary>
                /// <para>Time when the agent was last reserved, in Unix timestamp format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                /// <summary>
                /// <para>List of skill group IDs the agent is signed into.</para>
                /// </summary>
                [NameInMap("SignedSkillGroupIdList")]
                [Validation(Required=false)]
                public List<string> SignedSkillGroupIdList { get; set; }

                /// <summary>
                /// <para>Agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userId@ccc-test</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Agent state.</para>
                /// <para>Enumerated values:</para>
                /// <list type="bullet">
                /// <item><description><para>READY: Idle.</para>
                /// </description></item>
                /// <item><description><para>WORKING: Post-call processing.</para>
                /// </description></item>
                /// <item><description><para>BREAK: Break.</para>
                /// </description></item>
                /// <item><description><para>OFFLINE: Offline.</para>
                /// </description></item>
                /// <item><description><para>TALKING: Chatting.</para>
                /// </description></item>
                /// <item><description><para>RINGING: Incoming chat.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TALKING</para>
                /// </summary>
                [NameInMap("UserState")]
                [Validation(Required=false)]
                public string UserState { get; set; }

                /// <summary>
                /// <para>Work mode. Not applicable for chat scenarios.</para>
                /// <para>Enumerated values:</para>
                /// <list type="bullet">
                /// <item><description><para>ON_SITE: On-site mode.</para>
                /// </description></item>
                /// <item><description><para>OFF_SITE: Off-site mode.</para>
                /// </description></item>
                /// <item><description><para>OFFICE_PHONE: Office phone mode.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ON_SITE</para>
                /// </summary>
                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

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
        /// <para>List of response parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC976D32-AC4C-4E0F-8AA9-F4BC6C4E2B3E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
