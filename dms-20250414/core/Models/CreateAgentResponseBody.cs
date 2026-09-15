// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The agent information and the automatically issued API key returned after the agent is created.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAgentResponseBodyData Data { get; set; }
        public class CreateAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The globally unique ID of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agt-1a2b3c4d5e6f</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>order-analysis-agent</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The permission inheritance type of the agent. Valid values: HUMAN_BOUND (inherits user permissions), PERMISSION_NARROW (narrows permissions), STANDALONE (operates as an independent identity principal without inheriting permissions from other principals).</para>
            /// 
            /// <b>Example:</b>
            /// <para>HUMAN_BOUND</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The automatically issued API key for the new agent. The plaintext secret is returned only once in this response.</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public CreateAgentResponseBodyDataApiKey ApiKey { get; set; }
            public class CreateAgentResponseBodyDataApiKey : TeaModel {
                /// <summary>
                /// <para>The ID of the agent to which the API key belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agt-1a2b3c4d5e6f</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The name of the agent to which the API key belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>order-analysis-agent</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>The permission inheritance type of the agent to which the API key belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HUMAN_BOUND</para>
                /// </summary>
                [NameInMap("AgentType")]
                [Validation(Required=false)]
                public string AgentType { get; set; }

                /// <summary>
                /// <para>The time when the API key was created. The value is a time string in RFC 3339 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32Z</para>
                /// </summary>
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The user ID of the user who created the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usr-1a2b3c4d</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The name of the user who created the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The description of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Access Token automatically issued when the Agent is created</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The expiration time of the API key. The value is a time string in RFC 3339 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-12-11T14:04:32Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The primary key ID of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the API key has been revoked.</para>
                /// </summary>
                [NameInMap("IsRevoked")]
                [Validation(Required=false)]
                public bool? IsRevoked { get; set; }

                /// <summary>
                /// <para>The non-sensitive visible prefix of the API key plaintext, used to identify the credential. The plaintext secret is not returned again.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dms_sk_1a2b</para>
                /// </summary>
                [NameInMap("KeyPrefix")]
                [Validation(Required=false)]
                public string KeyPrefix { get; set; }

                /// <summary>
                /// <para>The time when the API key was last used. The value is a time string in RFC 3339 format. This parameter is empty if the API key has never been used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-12T09:30:00Z</para>
                /// </summary>
                [NameInMap("LastUsedTime")]
                [Validation(Required=false)]
                public string LastUsedTime { get; set; }

                /// <summary>
                /// <para>The name of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>order-analysis-agent-default</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The plaintext secret of the API key. This value is returned only once in this creation response. Store it securely. Subsequent API calls do not return the plaintext secret again.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dms_sk_1a2b3c4d****</para>
                /// </summary>
                [NameInMap("Secret")]
                [Validation(Required=false)]
                public string Secret { get; set; }

                /// <summary>
                /// <para>The credential source. Valid values: console (issued from the console), oauth (issued through the OAuth flow), install_token (issued through the install-and-authenticate flow). The API key automatically issued by this operation is always console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>console</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            /// <summary>
            /// <para>The time when the agent was created. The value is a time string in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The creation method of the agent. Valid values: manual (manually created in the console), auto (automatic creation by the system). Agents created by this operation are always manual.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("CreationType")]
            [Validation(Required=false)]
            public string CreationType { get; set; }

            /// <summary>
            /// <para>The description of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An agent for querying and analyzing order data</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The user ID of the agent owner, which is the current user who initiated the creation request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usr-1a2b3c4d</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The status of the agent. Valid values: active (enabled), disabled (disabled), deleted (deleted). A newly created agent is always active.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The status code of the request result. A value of success indicates success. A specific error code is returned upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails. This parameter is empty when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentName must not be blank</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID for troubleshooting and tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
