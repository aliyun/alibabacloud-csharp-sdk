// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyMem0SecurityIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ModifyMem0SecurityIpsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ModifyMem0SecurityIpsResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The operation name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the identity used for authentication in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the authenticated principal belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the identity used for authentication in the request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SubUser: RAM user</description></item>
            /// <item><description>AssumedRoleUser: RAM role</description></item>
            /// <item><description>Federated: SSO federated identity.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encrypted complete diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaKPfwjY0MzMyODRGLUZCQkQtNTA1RS04MUUxLTc5NTkzODk2MUIzMg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The type of denial by the access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ImplicitDeny</b>: The resource owner has not configured a relevant permission policy for the current user. Unauthorized operations are denied by default.</description></item>
            /// <item><description><b>ExplicitDeny</b>: The RAM policy configured by the resource owner explicitly denies the current user access to the corresponding resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>PolicyType</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIORITY</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyMem0SecurityIpsResponseBodyData Data { get; set; }
        public class ModifyMem0SecurityIpsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2209883</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B87E2AB3-B7C9-4394-9160-7F639F732031</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
