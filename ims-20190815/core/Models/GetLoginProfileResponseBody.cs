// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetLoginProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>The logon information for the console.</para>
        /// </summary>
        [NameInMap("LoginProfile")]
        [Validation(Required=false)]
        public GetLoginProfileResponseBodyLoginProfile LoginProfile { get; set; }
        public class GetLoginProfileResponseBodyLoginProfile : TeaModel {
            /// <summary>
            /// <para>Indicates whether console logon is automatically disabled if the user is inactive. This feature is enabled by default and cannot be disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoDisableLoginStatus")]
            [Validation(Required=false)]
            public string AutoDisableLoginStatus { get; set; }

            /// <summary>
            /// <para>The time when the RAM user last logged on to the console. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T07:25:25Z</para>
            /// </summary>
            [NameInMap("LastLoginTime")]
            [Validation(Required=false)]
            public string LastLoginTime { get; set; }

            /// <summary>
            /// <para>Indicates whether multi-factor authentication (MFA) is required for the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false: MFA is not required.</para>
            /// </description></item>
            /// <item><description><para>true: MFA is required.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MFABindRequired")]
            [Validation(Required=false)]
            public bool? MFABindRequired { get; set; }

            /// <summary>
            /// <para>Indicates whether the RAM user must reset the password at the next logon. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false: The RAM user is not required to reset the password.</para>
            /// </description></item>
            /// <item><description><para>true: The RAM user is required to reset the password.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordResetRequired")]
            [Validation(Required=false)]
            public bool? PasswordResetRequired { get; set; }

            /// <summary>
            /// <para>The status of the initial password. An initial password is the password that is configured when you create a logon profile or re-enable console logon.</para>
            /// <para>Valid values</para>
            /// <list type="bullet">
            /// <item><description><para>&quot;NotInitial&quot;: The password is not an initial password.</para>
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
            /// <para>The status of console logon. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Active: Console logon is enabled.</para>
            /// </description></item>
            /// <item><description><para>Inactive: Console logon is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the logon profile was last updated. The time is in Coordinated Universal Time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T06:56:45Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            /// <summary>
            /// <para>The logon name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
            /// </summary>
            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E517F18B-632C-48FC-93F1-CDCBCC6F8444</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
