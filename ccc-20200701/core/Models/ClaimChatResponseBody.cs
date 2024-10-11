// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ClaimChatResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClaimChatResponseBodyData Data { get; set; }
        public class ClaimChatResponseBodyData : TeaModel {
            [NameInMap("ChatContexts")]
            [Validation(Required=false)]
            public List<ClaimChatResponseBodyDataChatContexts> ChatContexts { get; set; }
            public class ClaimChatResponseBodyDataChatContexts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>226****-cbb6-****-8fea-1e71baf7bfa7</para>
                /// </summary>
                [NameInMap("AccessChannelId")]
                [Validation(Required=false)]
                public string AccessChannelId { get; set; }

                [NameInMap("AccessChannelName")]
                [Validation(Required=false)]
                public string AccessChannelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Web</para>
                /// </summary>
                [NameInMap("AccessChannelType")]
                [Validation(Required=false)]
                public string AccessChannelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BeingAssigned")]
                [Validation(Required=false)]
                public bool? BeingAssigned { get; set; }

                [NameInMap("CallVariables")]
                [Validation(Required=false)]
                public string CallVariables { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INBOUND</para>
                /// </summary>
                [NameInMap("ChatType")]
                [Validation(Required=false)]
                public string ChatType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>chat-65382141036853491</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public long? ContextId { get; set; }

            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public ClaimChatResponseBodyDataUserContext UserContext { get; set; }
            public class ClaimChatResponseBodyDataUserContext : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Warm-up</para>
                /// </summary>
                [NameInMap("BreakCode")]
                [Validation(Required=false)]
                public string BreakCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CCC-169.254.165.2-browser125.0.0-bs48b41903450e6c8</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("DeviceState")]
                [Validation(Required=false)]
                public string DeviceState { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8032****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1609136956378</para>
                /// </summary>
                [NameInMap("Heartbeat")]
                [Validation(Required=false)]
                public long? Heartbeat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>chat-65382141036853491</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18******102</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                [NameInMap("SignedSkillGroupIdList")]
                [Validation(Required=false)]
                public List<string> SignedSkillGroupIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>userId@ccc-test</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TALKING</para>
                /// </summary>
                [NameInMap("UserState")]
                [Validation(Required=false)]
                public string UserState { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ON_SITE</para>
                /// </summary>
                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

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

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BC976D32-AC4C-4E0F-8AA9-F4BC6C4E2B3E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
