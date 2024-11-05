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
        /// <para>The users returned.</para>
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
            /// <para>The end time of the validity period of the user. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672502400</para>
            /// </summary>
            [NameInMap("EffectiveEndTime")]
            [Validation(Required=false)]
            public long? EffectiveEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the validity period of the user. The value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <para>This parameter is required if LanguageStatus is set to Custom. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>zh-cn</b>: simplified Chinese.</description></item>
            /// <item><description><b>en</b>: English.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>Indicates whether notifications are sent in the language specified in the global settings or a custom language.</para>
            /// <list type="bullet">
            /// <item><description><b>Global</b></description></item>
            /// <item><description><b>Custom</b></description></item>
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
            /// <para>The location where the mobile phone number of the user is registered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CN</b>: the Chinese mainland, whose international dialing code is +86.</description></item>
            /// <item><description><b>HK</b>: Hong Kong (China), whose international dialing code is +852.</description></item>
            /// <item><description><b>MO</b>: Macao (China), whose international dialing code is +853.</description></item>
            /// <item><description><b>TW</b>: Taiwan (China), whose international dialing code is +886.</description></item>
            /// <item><description><b>RU</b>: Russia, whose international dialing code is +7.</description></item>
            /// <item><description><b>SG</b>: Singapore, whose international dialing code is +65.</description></item>
            /// <item><description><b>MY</b>: Malaysia, whose international dialing code is +60.</description></item>
            /// <item><description><b>ID</b>: Indonesia, whose international dialing code is +62.</description></item>
            /// <item><description><b>DE</b>: Germany, whose international dialing code is +49.</description></item>
            /// <item><description><b>AU</b>: Australia, whose international dialing code is +61.</description></item>
            /// <item><description><b>US</b>: US, whose international dialing code is +1.</description></item>
            /// <item><description><b>AE</b>: United Arab Emirates, whose international dialing code is +971.</description></item>
            /// <item><description><b>JP:</b> Japan, whose international dialing code is +81.</description></item>
            /// <item><description><b>GB</b>: UK, whose international dialing code is +44.</description></item>
            /// <item><description><b>IN</b>: India, whose international dialing code is +91.</description></item>
            /// <item><description><b>KR</b>: Republic of Korea, whose international dialing code is +82.</description></item>
            /// <item><description><b>PH</b>: Philippines, whose international dialing code is +63.</description></item>
            /// <item><description><b>CH</b>: Switzerland, whose international dialing code is +41.</description></item>
            /// <item><description><b>SE</b>: Sweden, whose international dialing code is +46.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("MobileCountryCode")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            /// <summary>
            /// <para>Indicates whether password reset is required upon the next logon. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedResetPassword")]
            [Validation(Required=false)]
            public bool? NeedResetPassword { get; set; }

            /// <summary>
            /// <para>The type of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Local</b>: a local user.</description></item>
            /// <item><description><b>Ram</b>: a RAM user.</description></item>
            /// <item><description><b>AD</b>: an AD-authenticated user.</description></item>
            /// <item><description><b>LDAP</b>: an LDAP-authenticated user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Local</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The unique ID of the user.</para>
            /// <remarks>
            /// <para> This parameter uniquely identifies a RAM user of the bastion host. A value is returned for this parameter if <b>Source</b> is set to <b>Ram</b>. No value is returned for this parameter if <b>Source</b> is set to <b>Local</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>122748924538****</para>
            /// </summary>
            [NameInMap("SourceUserId")]
            [Validation(Required=false)]
            public string SourceUserId { get; set; }

            /// <summary>
            /// <para>An array of the enabled two-factor authentication methods.</para>
            /// </summary>
            [NameInMap("TwoFactorMethods")]
            [Validation(Required=false)]
            public List<string> TwoFactorMethods { get; set; }

            /// <summary>
            /// <para>Indicates whether two-factor authentication is enabled for the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Global</b>: The global setting applies.</description></item>
            /// <item><description><b>Disable</b>: Two-factor authentication is disabled.</description></item>
            /// <item><description><b>Enable</b>: Two-factor authentication is enabled. The user-specific setting for the authentication method applies.</description></item>
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
            /// <para>An array that lists the states of users.</para>
            /// </summary>
            [NameInMap("UserState")]
            [Validation(Required=false)]
            public List<string> UserState { get; set; }

        }

    }

}
