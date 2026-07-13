// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteAtiRegistrantResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DeleteAtiRegistrantResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DeleteAtiRegistrantResponseBodyAccessDeniedDetail : TeaModel {
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
            /// <para>The ID of the authorization principal owner.</para>
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
            /// <para>The encoded diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQFohtp4aIbaeEXXXXQxNjFDLUIzMzgtNTXXXX05NkFCLUI2RkY5XXXXzAzQQ==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The reason for the authentication failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ExplicitDeny: explicit denial.</description></item>
            /// <item><description>ImplicitDeny: implicit denial.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>853805EA-3D47-47D5-9A1A-A45C24313ABD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation to delete the domain instance configuration was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
