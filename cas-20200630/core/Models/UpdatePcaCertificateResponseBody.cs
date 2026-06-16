// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class UpdatePcaCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The error details of the authorization.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public UpdatePcaCertificateResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class UpdatePcaCertificateResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that you attempted to perform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yundun-cert:XXX</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The identity that is used for authorization in the request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RAM user: UID of the RAM user</para>
            /// </description></item>
            /// <item><description><para>RAM role: RoleName:RoleSessionName</para>
            /// </description></item>
            /// <item><description><para>Federated user: ProviderType/ProviderName</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RoleSessionName</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the authorized principal belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>186XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The complete diagnostic information that is encrypted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaEjlETkzRkQ5QjVELTI3NTEtM0I2Ni1BM0E1LThBQUYzMkJBNEJCQg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The reason why the authorization failed. Valid values: ExplicitDeny: The authorization is explicitly denied. ImplicitDeny: The authorization is implicitly denied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The type of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09470F19-CEE8-5C63-BF2C-02B5E3F07A17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
