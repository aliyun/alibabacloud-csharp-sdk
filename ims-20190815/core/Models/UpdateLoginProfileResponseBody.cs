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
            /// <para>Indicates whether console logon is automatically disabled when the idle disable conditions are met. This feature is enabled by default and cannot be disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoDisableLoginStatus")]
            [Validation(Required=false)]
            public string AutoDisableLoginStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is required to enable multi-factor authentication (MFA).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MFABindRequired")]
            [Validation(Required=false)]
            public bool? MFABindRequired { get; set; }

            /// <summary>
            /// <para>Indicates whether the Resource Access Management (RAM) user is required to reset the password at the next logon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordResetRequired")]
            [Validation(Required=false)]
            public bool? PasswordResetRequired { get; set; }

            /// <summary>
            /// <para>The status of the initial password. The initial password refers to the password that is set when console logon is newly created or re-enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NotInitial: The password is not an initial password.</description></item>
            /// <item><description>InitialValid: The initial password is valid.</description></item>
            /// <item><description>InitialExpired: The initial password has expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NotInitial</para>
            /// </summary>
            [NameInMap("PasswordStatus")]
            [Validation(Required=false)]
            public string PasswordStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether console password logon is enabled or disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <para>Format: RFC 3339 (UTC). Example: 2020-10-14T07:48:41Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T07:48:41Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            /// <summary>
            /// <para>The logon name of the Resource Access Management (RAM) user.</para>
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
