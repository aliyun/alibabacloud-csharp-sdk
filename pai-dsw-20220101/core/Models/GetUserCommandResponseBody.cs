// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetUserCommandResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ValidationError</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("OnStart")]
        [Validation(Required=false)]
        public GetUserCommandResponseBodyOnStart OnStart { get; set; }
        public class GetUserCommandResponseBodyOnStart : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>apt update</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEBDF2EE-642E-5992-8907-D2011A7ACEFE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1900</para>
        /// </summary>
        [NameInMap("UserCommandId")]
        [Validation(Required=false)]
        public string UserCommandId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;AccessDeniedDetail&quot;: {
        ///     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;AQIBIAAAA....bwhg==&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,
        ///     &quot;AuthAction&quot;: &quot;ram:GetUserCommand&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> AccessDeniedDetail { get; set; }

    }

}
