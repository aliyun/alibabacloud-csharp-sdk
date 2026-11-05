// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListPermissionRulesResponseBody : TeaModel {
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of permission rules.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListPermissionRulesResponseBodyItems> Items { get; set; }
        public class ListPermissionRulesResponseBodyItems : TeaModel {
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
            /// <para>The list of targets to which the rule applies.</para>
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

        /// <summary>
        /// <para>The maximum number of entries returned in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message about the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-example</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// <para>The total number of rules that meet the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
