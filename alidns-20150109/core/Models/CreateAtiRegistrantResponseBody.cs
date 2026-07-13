// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateAtiRegistrantResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public CreateAtiRegistrantResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class CreateAtiRegistrantResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreateUser</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authorization principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authorization principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10469733312XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The identity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encrypted complete diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaNIARXXXXUQwNjE0LUQzN0XXXXVEQy1BQzExLTMzXXXXNTkxRjk1Ng==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The reason for the authentication failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ExplicitDeny: Explicit deny.</description></item>
            /// <item><description>ImplicitDeny: Implicit deny.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The creation time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The name of the real-name verified registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张xx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the real-name verified registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2072277378616354816</para>
        /// </summary>
        [NameInMap("RegistrantId")]
        [Validation(Required=false)]
        public string RegistrantId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The real-name verification status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Approved.</description></item>
        /// <item><description>Under review.</description></item>
        /// <item><description>Rejected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>审核通过</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
