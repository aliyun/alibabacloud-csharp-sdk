// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of users returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of users returned.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersResponseBodyUsers> Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The remarks of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The display name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bob</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The end time of the validity period of the user, in seconds (UNIX timestamp format).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672502400</para>
            /// </summary>
            [NameInMap("EffectiveEndTime")]
            [Validation(Required=false)]
            public long? EffectiveEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the validity period of the user, in seconds (UNIX timestamp format).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669630029</para>
            /// </summary>
            [NameInMap("EffectiveStartTime")]
            [Validation(Required=false)]
            public long? EffectiveStartTime { get; set; }

            /// <summary>
            /// <para>The email address of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1099**@qq.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The language for message notifications. This parameter is required when LanguageStatus is set to Custom. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh-cn</b>: Simplified Chinese</description></item>
            /// <item><description><b>en</b>: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The language setting for message notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Global</b>: follows the global settings</description></item>
            /// <item><description><b>Custom</b>: custom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("LanguageStatus")]
            [Validation(Required=false)]
            public string LanguageStatus { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1359999****</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>The country code of the mobile phone number of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CN</b>: the Chinese mainland (+86)</description></item>
            /// <item><description><b>HK</b>: Hong Kong (China) (+852)</description></item>
            /// <item><description><b>MO</b>: Macao (China) (+853)</description></item>
            /// <item><description><b>TW</b>: Taiwan (China) (+886)</description></item>
            /// <item><description><b>RU</b>: Russia (+7)</description></item>
            /// <item><description><b>SG</b>: Singapore (+65)</description></item>
            /// <item><description><b>MY</b>: Malaysia (+60)</description></item>
            /// <item><description><b>ID</b>: Indonesia (+62)</description></item>
            /// <item><description><b>DE</b>: Germany (+49)</description></item>
            /// <item><description><b>AU</b>: Australia (+61)</description></item>
            /// <item><description><b>US</b>: United States (+1)</description></item>
            /// <item><description><b>AE</b>: Dubai (+971)</description></item>
            /// <item><description><b>JP</b>: Japan (+81)</description></item>
            /// <item><description><b>GB</b>: United Kingdom (+44)</description></item>
            /// <item><description><b>IN</b>: India (+91)</description></item>
            /// <item><description><b>KR</b>: South Korea (+82)</description></item>
            /// <item><description><b>PH</b>: Philippines (+63)</description></item>
            /// <item><description><b>CH</b>: Switzerland (+41)</description></item>
            /// <item><description><b>SE</b>: Sweden (+46)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("MobileCountryCode")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the password must be reset upon next logon. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The password must be reset.</description></item>
            /// <item><description><b>false</b>: The password does not need to be reset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedResetPassword")]
            [Validation(Required=false)]
            public bool? NeedResetPassword { get; set; }

            /// <summary>
            /// <para>The source of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Local</b>: local user</description></item>
            /// <item><description><b>Ram</b>: Resource Access Management (RAM) user</description></item>
            /// <item><description><b>AD</b>: AD user</description></item>
            /// <item><description><b>LDAP</b>: LDAP user</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The unique identity of the user.</para>
            /// <remarks>
            /// <para>This parameter is the unique identity of the Resource Access Management (RAM) user that corresponds to the bastion host user. This parameter is returned when the user source is a RAM user (that is, <b>Source</b> is set to <b>Ram</b>). If the user source is a local user (that is, <b>Source</b> is set to <b>Local</b>), this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>122748924538****</para>
            /// </summary>
            [NameInMap("SourceUserId")]
            [Validation(Required=false)]
            public string SourceUserId { get; set; }

            /// <summary>
            /// <para>The array of enabled two-factor authentication methods.</para>
            /// </summary>
            [NameInMap("TwoFactorMethods")]
            [Validation(Required=false)]
            public List<string> TwoFactorMethods { get; set; }

            /// <summary>
            /// <para>The two-factor authentication status of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Global</b>: follows the global settings</description></item>
            /// <item><description><b>Disable</b>: two-factor authentication disabled</description></item>
            /// <item><description><b>Enable</b>: two-factor authentication enabled, follows individual user settings</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("TwoFactorStatus")]
            [Validation(Required=false)]
            public string TwoFactorStatus { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The logon name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc_def</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The user status array.</para>
            /// </summary>
            [NameInMap("UserState")]
            [Validation(Required=false)]
            public List<string> UserState { get; set; }

        }

    }

}
