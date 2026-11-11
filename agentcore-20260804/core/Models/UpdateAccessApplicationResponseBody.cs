// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateAccessApplicationResponseBody : TeaModel {
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
        /// <para>The details of the access application.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateAccessApplicationResponseBodyData Data { get; set; }
        public class UpdateAccessApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The access application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-1234567890</para>
            /// </summary>
            [NameInMap("applicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The name of the access application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-access-application</para>
            /// </summary>
            [NameInMap("applicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The OAuth client ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client-1234567890</para>
            /// </summary>
            [NameInMap("clientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

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
            /// <para>The metadata URL of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/.well-known/openid-configuration">https://example.com/.well-known/openid-configuration</a></para>
            /// </summary>
            [NameInMap("metadataUrl")]
            [Validation(Required=false)]
            public string MetadataUrl { get; set; }

            /// <summary>
            /// <para>The list of redirect URIs.</para>
            /// </summary>
            [NameInMap("redirectUris")]
            [Validation(Required=false)]
            public List<string> RedirectUris { get; set; }

            /// <summary>
            /// <para>The update time in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The user source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LOCAL</para>
            /// </summary>
            [NameInMap("userSource")]
            [Validation(Required=false)]
            public string UserSource { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-1234567890</para>
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
        /// <para>The message indicating the request processing result.</para>
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
