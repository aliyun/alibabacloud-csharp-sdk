// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetAgenticAgentByInstallTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The agent information associated with the install token after redemption. This parameter is empty if the token has not been redeemed, or if the associated credential or agent does not exist.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgenticAgentByInstallTokenResponseBodyData Data { get; set; }
        public class GetAgenticAgentByInstallTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The prefix list of visible access tokens that are neither revoked nor expired under the agent. This parameter is empty if no access tokens are returned or no access tokens meet the conditional criteria. The prefix is used only to identify the credential and does not contain the complete secret.</para>
            /// </summary>
            [NameInMap("ActiveApiKeyPrefixes")]
            [Validation(Required=false)]
            public List<string> ActiveApiKeyPrefixes { get; set; }

            /// <summary>
            /// <para>The unique identifier of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-7f3c9a2b</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-data-agent</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The permission type of the agent. Valid values: HUMAN_BOUND (inherits user permissions), PERMISSION_NARROW (narrowed down from user permissions), and STANDALONE (independent permissions). The agent generated through the install token redemption process is of the HUMAN_BOUND type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HUMAN_BOUND</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The creation time of the agent, in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-13 10:30:00</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The creation method of the agent. A value of auto indicates automatic creation by the system, and a value of manual indicates manual creation by a user. The agent generated through the install token redemption process is auto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto</para>
            /// </summary>
            [NameInMap("CreationType")]
            [Validation(Required=false)]
            public string CreationType { get; set; }

            /// <summary>
            /// <para>The description of the agent. This parameter is empty if it is not set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent for data analytics</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the user to whom the agent belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27400000000000001</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The status of the agent. A value of active indicates that the agent is enabled, and a value of disabled indicates that the agent is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request fails. Programs use this code to determine the failure type. This parameter is empty when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTALL_TOKEN_INVALID</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails. This message helps with manual troubleshooting. This parameter is empty when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>install_token not found</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, used for troubleshooting and log correlation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6C-2C4DD51BD5E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of true indicates that the query succeeded. A value of false indicates that the query failed. In this case, you can use ErrorCode and ErrorMessage to identify the cause.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
