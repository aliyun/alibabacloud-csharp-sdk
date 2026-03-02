// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateLoginProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>The logon information for the console.</para>
        /// </summary>
        [NameInMap("LoginProfile")]
        [Validation(Required=false)]
        public CreateLoginProfileResponseBodyLoginProfile LoginProfile { get; set; }
        public class CreateLoginProfileResponseBodyLoginProfile : TeaModel {
            /// <summary>
            /// <para>Indicates whether the RAM user is required to enable MFA.</para>
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
            /// <para>The status of the initial password. This password is set when a logon configuration is created or when console logon is re-enabled.</para>
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
            /// <para>Indicates whether password-based logon for the console is enabled or disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the logon configuration was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T03:47:51Z</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29CB303C-1F05-43A6-A6BC-EBC5A797F8DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
