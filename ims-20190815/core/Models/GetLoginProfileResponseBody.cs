// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetLoginProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>The console logon configurations.</para>
        /// </summary>
        [NameInMap("LoginProfile")]
        [Validation(Required=false)]
        public GetLoginProfileResponseBodyLoginProfile LoginProfile { get; set; }
        public class GetLoginProfileResponseBodyLoginProfile : TeaModel {
            /// <summary>
            /// <para>The time of the most recent logon. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T07:25:25Z</para>
            /// </summary>
            [NameInMap("LastLoginTime")]
            [Validation(Required=false)]
            public string LastLoginTime { get; set; }

            /// <summary>
            /// <para>Indicates whether multi-factor authentication (MFA) must be enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false</description></item>
            /// <item><description>true</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MFABindRequired")]
            [Validation(Required=false)]
            public bool? MFABindRequired { get; set; }

            /// <summary>
            /// <para>Indicates whether the RAM user is required to reset the password upon the next logon. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false</description></item>
            /// <item><description>true</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordResetRequired")]
            [Validation(Required=false)]
            public bool? PasswordResetRequired { get; set; }

            /// <summary>
            /// <para>Indicates whether console logon is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: enabled.</description></item>
            /// <item><description>Inactive: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The modification time. The time is displayed in UTC.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E517F18B-632C-48FC-93F1-CDCBCC6F8444</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
