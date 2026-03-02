// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateLoginProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>The console logon information.</para>
        /// </summary>
        [NameInMap("LoginProfile")]
        [Validation(Required=false)]
        public UpdateLoginProfileResponseBodyLoginProfile LoginProfile { get; set; }
        public class UpdateLoginProfileResponseBodyLoginProfile : TeaModel {
            /// <summary>
            /// <para>Indicates whether to automatically disable console logon for an inactive account. This feature is enabled by default and cannot be disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoDisableLoginStatus")]
            [Validation(Required=false)]
            public string AutoDisableLoginStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether MFA is enforced for the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MFABindRequired")]
            [Validation(Required=false)]
            public bool? MFABindRequired { get; set; }

            /// <summary>
            /// <para>Indicates whether the RAM user must reset the password at the next logon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordResetRequired")]
            [Validation(Required=false)]
            public bool? PasswordResetRequired { get; set; }

            /// <summary>
            /// <para>The status of the initial password. An initial password is the one set when a logon profile is created or console logon is re-enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>&quot;NotInitial&quot;: Not an initial password.</para>
            /// </description></item>
            /// <item><description><para>&quot;InitialValid&quot;: The initial password is valid.</para>
            /// </description></item>
            /// <item><description><para>&quot;InitialExpired&quot;: The initial password has expired.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NotInitial</para>
            /// </summary>
            [NameInMap("PasswordStatus")]
            [Validation(Required=false)]
            public string PasswordStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether password logon to the console is enabled or disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the logon profile was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T07:48:41Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            /// <summary>
            /// <para>The logon name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@example11.onaliyun.com">test@example11.onaliyun.com</a></para>
            /// </summary>
            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCDB6A7F-2199-41D9-B577-4FA536A5ADE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
