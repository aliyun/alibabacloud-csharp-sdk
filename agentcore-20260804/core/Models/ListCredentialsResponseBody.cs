// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListCredentialsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
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
        /// <para>The list of credentials.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListCredentialsResponseBodyItems> Items { get; set; }
        public class ListCredentialsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The number of agents bound to this credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("boundAgentsCounts")]
            [Validation(Required=false)]
            public int? BoundAgentsCounts { get; set; }

            /// <summary>
            /// <para>The creation time in UTC, formatted according to RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The credential ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cred-123456</para>
            /// </summary>
            [NameInMap("credentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// <para>The masked content of the credential. When credentialType is apiKey, the apiKey value is returned with equal-length asterisks (*).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;apiKey&quot;:&quot;****************&quot;}</para>
            /// </summary>
            [NameInMap("credentialMetadata")]
            [Validation(Required=false)]
            public string CredentialMetadata { get; set; }

            /// <summary>
            /// <para>The credential type. Currently, only apiKey is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiKey</para>
            /// </summary>
            [NameInMap("credentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            /// <summary>
            /// <para>The credential description. The description can be up to 256 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API Key used for calling model services in the production environment</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The credential name. The name must be unique within the workspace and can contain only letters, digits, periods (.), underscores (_), and hyphens (-). The name must be 3 to 128 characters in length and cannot use runtime reserved names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-api-key</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The time of the last modification in UTC, formatted according to RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-123456</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records per page that takes effect for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message. An error description is returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. This value is empty if no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of credentials that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
