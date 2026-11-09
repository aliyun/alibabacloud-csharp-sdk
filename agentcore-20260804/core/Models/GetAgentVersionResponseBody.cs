// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetAgentVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value is SUCCESS if the request is successful, or an error code if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the fixed agent version. The configuration field contains the agent configuration at the time the version was saved.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAgentVersionResponseBodyData Data { get; set; }
        public class GetAgentVersionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the managed or custom agent that owns the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The system-generated version number that increments for each agent, such as v1 and v2. This is used when querying or deleting versions, and when referencing versions in service endpoints.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("agentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// <para>Indicates only whether the version template and artifact archiving are complete, and does not represent the deployment or running status. A value of READY indicates that the archiving is complete. A value of INVALID indicates that the archiving is missing or inconsistent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("artifactStatus")]
            [Validation(Required=false)]
            public string ArtifactStatus { get; set; }

            /// <summary>
            /// <para>For managed agents, the structure is consistent with the data structure of GetManagedAgent. For custom agents, the structure is consistent with the data structure of GetCustomAgent. The desensitization rules are the same.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;agentId&quot;:&quot;agent-0123456789abcdef0123456789abcdef&quot;,&quot;workspaceId&quot;:&quot;ws-0123456789abcdef01234&quot;,&quot;name&quot;:&quot;customer-service&quot;,&quot;description&quot;:&quot;Customer service agent&quot;,&quot;status&quot;:&quot;Running&quot;,&quot;latestSpecVersion&quot;:2,&quot;instruction&quot;:&quot;You are a customer service assistant.&quot;}</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public Dictionary<string, object> Configuration { get; set; }

            /// <summary>
            /// <para>The time when the version was saved, in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T01:02:03Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The UID of the Alibaba Cloud account of the caller who saved the version. If the API is called by a RAM user, this value is the UID of the Alibaba Cloud account to which the RAM user belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The version description provided when the version was saved. It can contain up to 1,024 characters. If no description was provided when the version was saved, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Stable version for the production environment</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The effective release serial number of the agent when the version was saved, which is the effectiveSpecVersion at that time. This value does not change after the version is saved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("targetSpecVersion")]
            [Validation(Required=false)]
            public long? TargetSpecVersion { get; set; }

            /// <summary>
            /// <para>The display name specified by the user when the version was saved. For earlier saved versions that did not record a name, the agentVersion is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Production stable version V1.0</para>
            /// </summary>
            [NameInMap("versionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <para>The ID of the AgentCore workspace where the agent that owns the version resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-0123456789abcdef01234</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message. The value is success if the request is successful, or an error message if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E8F3C2A-1B4D-4F6E-9A7C-0D2B8E6F4A1C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
