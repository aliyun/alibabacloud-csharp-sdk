// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyUserRequest : TeaModel {
        /// <summary>
        /// <para>The new remarks of the user. The remarks can be up to 500 characters in length.</para>
        /// <remarks>
        /// <para> Leave this parameter empty if you do not want to change the remarks of the user.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The new display name of the user. The display name can be up to 128 characters in length.</para>
        /// <remarks>
        /// <para> Leave this parameter empty if you do not want to change the display name of the user.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Bob</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The end time of the validity period of the user. Specify a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para> Leave this parameter empty if you do not want to change the end time of the validity period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1672502400</para>
        /// </summary>
        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public long? EffectiveEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the validity period of the user. Specify a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para> Leave this parameter empty if you do not want to change the start time of the validity period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1669630029</para>
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public long? EffectiveStartTime { get; set; }

        /// <summary>
        /// <para>The new email address of the user.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if TwoFactorStatus is set to Enable and TwoFactorMethods is set to email, or if TwoFactorStatus is set to Global and TwoFactorMethods is set to email in the global two-factor authentication settings.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/462968.html">GetInstanceTwoFactor</a> operation to query the global two-factor authentication settings.</para>
        /// </description></item>
        /// <item><description><para>Leave this parameter empty if you do not want to change the email address of the user.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host on which you want to modify the information about the user.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required if LanguageStatus is set to Custom.</para>
        /// <list type="bullet">
        /// <item><description><b>zh-cn</b>: simplified Chinese</description></item>
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
        /// <para>Specifies whether to send notifications in the language specified in the global settings or a custom language.</para>
        /// <list type="bullet">
        /// <item><description><b>Global</b></description></item>
        /// <item><description><b>Custom</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> Leave this parameter empty if you do not want to change the natural language used to notify the user.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("LanguageStatus")]
        [Validation(Required=false)]
        public string LanguageStatus { get; set; }

        /// <summary>
        /// <para>The new mobile phone number of the user.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if TwoFactorStatus is set to Enable and TwoFactorMethods is set to sms or dingtalk, or if TwoFactorStatus is set to Global and TwoFactorMethods is set to sms or dingtalk in the global two-factor authentication settings.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/462968.html">GetInstanceTwoFactor</a> operation to query the global two-factor authentication settings.</para>
        /// </description></item>
        /// <item><description><para>Leave this parameter empty if you do not want to change the mobile phone number of the user.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1358888****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The country where the new mobile number of the user is registered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CN:</b> the Chinese mainland, whose country calling code is +86</description></item>
        /// <item><description><b>HK:</b> Hong Kong (China), whose country calling code is +852</description></item>
        /// <item><description><b>MO:</b> Macao (China), whose country calling code is +853</description></item>
        /// <item><description><b>TW:</b> Taiwan (China), whose country calling code is +886</description></item>
        /// <item><description><b>RU:</b> Russia, whose country calling code is +7</description></item>
        /// <item><description><b>SG:</b> Singapore, whose country calling code is +65</description></item>
        /// <item><description><b>MY:</b> Malaysia, whose country calling code is +60</description></item>
        /// <item><description><b>ID:</b> Indonesia, whose country calling code is +62</description></item>
        /// <item><description><b>DE:</b> Germany, whose country calling code is +49</description></item>
        /// <item><description><b>AU:</b> Australia, whose country calling code is +61</description></item>
        /// <item><description><b>US:</b> US, whose country calling code is +1</description></item>
        /// <item><description><b>AE:</b> United Arab Emirates, whose country calling code is +971</description></item>
        /// <item><description><b>JP:</b> Japan, whose country calling code is +81</description></item>
        /// <item><description><b>GB:</b> UK, whose country calling code is +44</description></item>
        /// <item><description><b>IN:</b> India, whose country calling code is +91</description></item>
        /// <item><description><b>KR:</b> Republic of Korea, whose country calling code is +82</description></item>
        /// <item><description><b>PH:</b> Philippines, whose country calling code is +63</description></item>
        /// <item><description><b>CH:</b> Switzerland, whose country calling code is +41</description></item>
        /// <item><description><b>SE:</b> Sweden, whose country calling code is +46</description></item>
        /// <item><description><b>SA:</b> Saudi Arabia, whose country calling code is +966</description></item>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> Leave this parameter empty if you do not want to change the password reset settings for the user.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedResetPassword")]
        [Validation(Required=false)]
        public bool? NeedResetPassword { get; set; }

        /// <summary>
        /// <para>The new password of the user. The password must be 8 to 128 characters in length. It must contain uppercase letters, lowercase letters, digits, and special characters.</para>
        /// <remarks>
        /// <para>Leave this parameter empty if you do not want to change the password of the user.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>321****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host on which you want to modify the information about the user.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The two-factor authentication method. You can select only one method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sms</b>: text message-based two-factor authentication.</description></item>
        /// <item><description><b>email</b>: email-based two-factor authentication.</description></item>
        /// <item><description><b>dingtalk</b>: DingTalk-based two-factor authentication.</description></item>
        /// <item><description><b>totp OTP:</b> one-time password (OTP) token-based two-factor authentication.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If TwoFactorStatus is set to Enable, you must specify one of the valid values as TwoFactorMethods.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sms</para>
        /// </summary>
        [NameInMap("TwoFactorMethods")]
        [Validation(Required=false)]
        public string TwoFactorMethods { get; set; }

        /// <summary>
        /// <para>Specifies whether two-factor authentication is enabled for the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Global</b>: The global settings apply.</description></item>
        /// <item><description><b>Disable</b>: Two-factor authentication is disabled.</description></item>
        /// <item><description><b>Enable</b>: Two-factor authentication is enabled and user-specific settings apply.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Leave this parameter empty if you do not want to change the two-factory authentication settings for the user.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("TwoFactorStatus")]
        [Validation(Required=false)]
        public string TwoFactorStatus { get; set; }

        /// <summary>
        /// <para>The ID of the user whose information you want to modify.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/204522.html">ListUsers</a> operation to query the user ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
