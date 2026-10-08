// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveSingleTaskForCreatingOrderActivateRequest : TeaModel {
        /// <summary>
        /// <para>The detailed address in English.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>chao yang qu</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>Specifies whether to use Alibaba Cloud DNS servers. Valid values: <b>true</b> and <b>false</b>. Default value: <b>true</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to <b>true</b>, you do not need to specify the <b>Dns1</b> and <b>Dns2</b> parameters. Otherwise, the specified <b>Dns1</b> and <b>Dns2</b> parameters do not take effect.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to <b>false</b>, you must specify the <b>Dns1</b> and <b>Dns2</b> parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AliyunDns")]
        [Validation(Required=false)]
        public bool? AliyunDns { get; set; }

        /// <summary>
        /// <para>The city name in English.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bei jing shi</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The country code, such as <b>CN</b>.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The ID of the voucher. Default value: a string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The first custom DNS server.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available and required only when the <b>AliyunDns</b> parameter is set to <b>false</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Make sure that the custom DNS server is correct. Otherwise, the registration may fail.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ns1.aliyun.com</para>
        /// </summary>
        [NameInMap("Dns1")]
        [Validation(Required=false)]
        public string Dns1 { get; set; }

        /// <summary>
        /// <para>The second custom DNS server.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available and required only when the <b>AliyunDns</b> parameter is set to <b>false</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Make sure that the custom DNS server is correct. Otherwise, the registration may fail.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ns2.aliyun.com</para>
        /// </summary>
        [NameInMap("Dns2")]
        [Validation(Required=false)]
        public string Dns2 { get; set; }

        /// <summary>
        /// <para>The domain name that you want to register.</para>
        /// <remarks>
        /// <para>When you register a domain name, you must specify the registrant information. If you do not specify the registrant information, the domain name registration fails. You can specify the RegistrantProfileId parameter to use a registrant profile that defines the registrant information.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The email address.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the domain name privacy protection service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable.</description></item>
        /// <item><description><b>false</b>: Do not enable.</description></item>
        /// </list>
        /// <para>Default value: <b>true</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDomainProxy")]
        [Validation(Required=false)]
        public bool? EnableDomainProxy { get; set; }

        /// <summary>
        /// <para>The domain name in Punycode format. This parameter can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xn--fiqs8s.com</para>
        /// </summary>
        [NameInMap("ExpectedPunycode")]
        [Validation(Required=false)]
        public string ExpectedPunycode { get; set; }

        /// <summary>
        /// <para>The language of the error message returned by the API operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the registration of premium domain names. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Not allowed.</description></item>
        /// <item><description><b>true</b>: Allowed.</description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PermitPremiumActivation")]
        [Validation(Required=false)]
        public bool? PermitPremiumActivation { get; set; }

        /// <summary>
        /// <para>The postal code.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("PostalCode")]
        [Validation(Required=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// <para>The ID of the coupon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("PromotionNo")]
        [Validation(Required=false)]
        public string PromotionNo { get; set; }

        /// <summary>
        /// <para>The province name in English.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bei jing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The name of the domain name contact in English.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <para>The name of the domain name registrant in English.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <para>The ID of the domain name registrant profile. The profile contains information such as the registrant name, contact name, phone number, and email address. You can use only a real-name verified registrant profile to register a domain name. If you have created a registrant profile, you can call the <a href="~~QueryRegistrantProfiles~~">QueryRegistrantProfiles</a> operation to query the profile ID.</para>
        /// <remarks>
        /// <para>After you specify this parameter, you do not need to specify the <b>RegistrantType</b>, <b>ZhRegistrantOrganization</b>, <b>ZhRegistrantName</b>, <b>ZhProvince</b>, <b>ZhCity</b>, <b>ZhAddress</b>, <b>RegistrantOrganization</b>, <b>RegistrantName</b>, <b>Province</b>, <b>City</b>, <b>Address</b>, <b>PostalCode</b>, <b>Country</b>, <b>TelArea</b>, <b>Telephone</b>, <b>TelExt</b>, or <b>Email</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <para>The type of the domain name registrant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Individual.</description></item>
        /// <item><description><b>2</b>: Enterprise or organization.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        /// <summary>
        /// <para>None.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-XX</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The subscription duration. Unit: <b>year</b>. Default value: <b>1 year</b>. Maximum value: <b>10 years</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SubscriptionDuration")]
        [Validation(Required=false)]
        public int? SubscriptionDuration { get; set; }

        /// <summary>
        /// <para>The country code for the phone number, such as <b>86</b> for China.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("TelArea")]
        [Validation(Required=false)]
        public string TelArea { get; set; }

        /// <summary>
        /// <para>The extension number.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TelExt")]
        [Validation(Required=false)]
        public string TelExt { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the registration of trademark domain names. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Not allowed.</description></item>
        /// <item><description><b>true</b>: Allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TrademarkDomainActivation")]
        [Validation(Required=false)]
        public bool? TrademarkDomainActivation { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a voucher. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Use.</description></item>
        /// <item><description><b>false</b>: Do not use.</description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseCoupon")]
        [Validation(Required=false)]
        public bool? UseCoupon { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Not allowed.</description></item>
        /// <item><description><b>true</b>: Allowed.</description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UsePromotion")]
        [Validation(Required=false)]
        public bool? UsePromotion { get; set; }

        /// <summary>
        /// <para>The IP address of the client. You can set this parameter to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The detailed address in Chinese.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>朝阳区</para>
        /// </summary>
        [NameInMap("ZhAddress")]
        [Validation(Required=false)]
        public string ZhAddress { get; set; }

        /// <summary>
        /// <para>The city name in Chinese.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>北京市</para>
        /// </summary>
        [NameInMap("ZhCity")]
        [Validation(Required=false)]
        public string ZhCity { get; set; }

        /// <summary>
        /// <para>The province name in Chinese.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>北京</para>
        /// </summary>
        [NameInMap("ZhProvince")]
        [Validation(Required=false)]
        public string ZhProvince { get; set; }

        /// <summary>
        /// <para>The name of the domain name contact in Chinese.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        /// <summary>
        /// <para>The name of the domain name registrant in Chinese.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not specified. If you do not specify this parameter, the domain name registration fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
