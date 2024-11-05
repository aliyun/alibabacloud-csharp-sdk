// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed information about the queried user.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The description of the user.</para>
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
            /// <para>The end of the validity period of the user. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672502400</para>
            /// </summary>
            [NameInMap("EffectiveEndTime")]
            [Validation(Required=false)]
            public long? EffectiveEndTime { get; set; }

            /// <summary>
            /// <para>The beginning of the validity period of the user. The value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <para>This parameter is required if LanguageStatus is set to Custom.</para>
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
            /// <item><description><b>Global</b>: Global</description></item>
            /// <item><description><b>Custom</b>: Custom</description></item>
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
            /// <para>The location in which the mobile number of the user is registered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CN</b>: the Chinese mainland, whose country calling code is +86</description></item>
            /// <item><description><b>HK</b>: Hong Kong (China), whose country calling code is +852</description></item>
            /// <item><description><b>MO</b>: Macao (China), whose country calling code is +853</description></item>
            /// <item><description><b>TW</b>: Taiwan (China), whose country calling code is +886</description></item>
            /// <item><description><b>RU</b>: Russia, whose country calling code is +7</description></item>
            /// <item><description><b>SG</b>: Singapore, whose country calling code is +65</description></item>
            /// <item><description><b>MY</b>: Malaysia, whose country calling code is +60</description></item>
            /// <item><description><b>ID</b>: Indonesia, whose country calling code is +62</description></item>
            /// <item><description><b>DE</b>: Germany, whose country calling code is +49</description></item>
            /// <item><description><b>AU</b>: Australia, whose country calling code is +61</description></item>
            /// <item><description><b>US</b>: US, whose country calling code is +1</description></item>
            /// <item><description><b>AE</b>: United Arab Emirates, whose country calling code is +971</description></item>
            /// <item><description><b>JP:</b> Japan, whose country calling code is +81</description></item>
            /// <item><description><b>GB</b>: UK, whose country calling code is +44</description></item>
            /// <item><description><b>IN</b>: India, whose country calling code is +91</description></item>
            /// <item><description><b>KR</b>: Republic of Korea, whose country calling code is +82</description></item>
            /// <item><description><b>PH</b>: Philippines, whose country calling code is +63</description></item>
            /// <item><description><b>CH</b>: Switzerland, whose country calling code is +41</description></item>
            /// <item><description><b>SE</b>: Sweden, whose country calling code is +46</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("MobileCountryCode")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            /// <summary>
            /// <para>Specifies whether password reset is required upon the next logon. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
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
            /// <item><description><b>Local</b>: a local user</description></item>
            /// <item><description><b>Ram</b>: a RAM user</description></item>
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
            /// <para>This parameter uniquely identifies a RAM user of the bastion host. A value is returned for this parameter if the <b>Source</b> parameter is set to <b>Ram</b>. No value is returned for this parameter if the <b>Source</b> parameter is set to <b>Local</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>122748924538****</para>
            /// </summary>
            [NameInMap("SourceUserId")]
            [Validation(Required=false)]
            public string SourceUserId { get; set; }

            /// <summary>
            /// <para>An array that consists of the details of the two-factor authentication method.</para>
            /// </summary>
            [NameInMap("TwoFactorMethods")]
            [Validation(Required=false)]
            public List<string> TwoFactorMethods { get; set; }

            /// <summary>
            /// <para>The two-factor authentication status of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Global</b>: The global settings are used.</description></item>
            /// <item><description><b>Disable</b>: The two-factor authentication is disabled.</description></item>
            /// <item><description><b>Enable</b>: The two-factor authentication is enabled and the user-specific setting is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("TwoFactorStatus")]
            [Validation(Required=false)]
            public string TwoFactorStatus { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
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
            /// <para>abcabc_def</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>An array that consists of the details of the user status.</para>
            /// </summary>
            [NameInMap("UserState")]
            [Validation(Required=false)]
            public List<string> UserState { get; set; }

        }

    }

}
