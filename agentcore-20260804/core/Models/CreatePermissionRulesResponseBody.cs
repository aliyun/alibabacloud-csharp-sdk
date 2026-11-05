// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreatePermissionRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The creation result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreatePermissionRulesResponseBodyData Data { get; set; }
        public class CreatePermissionRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of created permission rules.</para>
            /// </summary>
            [NameInMap("rules")]
            [Validation(Required=false)]
            public List<CreatePermissionRulesResponseBodyDataRules> Rules { get; set; }
            public class CreatePermissionRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The creation time in RFC 3339 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The authorization effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PERMIT</para>
                /// </summary>
                [NameInMap("effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The rule enforcement mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENFORCE</para>
                /// </summary>
                [NameInMap("enforcementMode")]
                [Validation(Required=false)]
                public string EnforcementMode { get; set; }

                /// <summary>
                /// <para>The permission rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pr-1234567890</para>
                /// </summary>
                [NameInMap("permissionRuleId")]
                [Validation(Required=false)]
                public string PermissionRuleId { get; set; }

                /// <summary>
                /// <para>The principal ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890123456</para>
                /// </summary>
                [NameInMap("principalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                /// <summary>
                /// <para>The principal name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-user</para>
                /// </summary>
                [NameInMap("principalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                /// <summary>
                /// <para>The principal type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("principalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-1234567890</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The rule source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AgentCore</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The rule source details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EXPLICIT</para>
                /// </summary>
                [NameInMap("sourceDetail")]
                [Validation(Required=false)]
                public string SourceDetail { get; set; }

                /// <summary>
                /// <para>The target scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SPECIFIED</para>
                /// </summary>
                [NameInMap("targetScope")]
                [Validation(Required=false)]
                public string TargetScope { get; set; }

                /// <summary>
                /// <para>The list of targets for the rule.</para>
                /// </summary>
                [NameInMap("targets")]
                [Validation(Required=false)]
                public List<string> Targets { get; set; }

                /// <summary>
                /// <para>The update time in RFC 3339 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

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
        /// <para>The request processing result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a2b3c4d-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
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
