// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetLinkageAttributesTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;&quot;,
        ///     &quot;AuthAction&quot;: &quot;&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLinkageAttributesTemplateResponseBodyData Data { get; set; }
        public class GetLinkageAttributesTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SyntaxError</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[
            ///       {
            ///         &quot;label&quot;: &quot;ecs.c6.2xlarge (8c 16g)&quot;,
            ///         &quot;value&quot;: &quot;ecs.c6.2xlarge&quot;
            ///       },
            ///       {
            ///         &quot;label&quot;: &quot;ecs.c6.3xlarge (12c 24g)&quot;,
            ///         &quot;value&quot;: &quot;ecs.c6.3xlarge&quot;
            ///       }
            /// ]</para>
            /// </summary>
            [NameInMap("OptionalValues")]
            [Validation(Required=false)]
            public string OptionalValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A07FFDF2-78FA-1B48-9E38-88E833A93187</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
