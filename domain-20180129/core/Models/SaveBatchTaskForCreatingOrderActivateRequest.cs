// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForCreatingOrderActivateRequest : TeaModel {
        /// <summary>
        /// <para>The voucher ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

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
        /// <para>The list of task details.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderActivateParam")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForCreatingOrderActivateRequestOrderActivateParam> OrderActivateParam { get; set; }
        public class SaveBatchTaskForCreatingOrderActivateRequestOrderActivateParam : TeaModel {
            /// <summary>
            /// <para>The mailing address in English.</para>
            /// <remarks>
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>chao yan qu *** dasha *** hao</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>Specifies whether to use Alibaba Cloud DNS. Valid values: <b>true</b> and <b>false</b>. Default value: <b>true</b>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If this parameter is set to <b>true</b>, you do not need to specify the <b>OrderActivateParam.N.Dns1</b> and <b>OrderActivateParam.N.Dns2</b> parameters. Otherwise, the specified <b>OrderActivateParam.N.Dns1</b> and <b>OrderActivateParam.N.Dns2</b> parameters do not take effect.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If this parameter is set to <b>false</b>, you must also specify the <b>OrderActivateParam.N.Dns1</b> and <b>OrderActivateParam.N.Dns2</b> parameters.</description></item>
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
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>bei jing shi</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The country code. For example, <b>CN</b> represents China, and <b>US</b> represents the United States.</para>
            /// <remarks>
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The custom DNS server 1.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is available and required only when the <b>OrderActivateParam.N.AliyunDns</b> parameter is set to <b>false</b>.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Make sure that the custom DNS server is correct. Otherwise, the registration may fail.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ns2.aliyun.com</para>
            /// </summary>
            [NameInMap("Dns1")]
            [Validation(Required=false)]
            public string Dns1 { get; set; }

            /// <summary>
            /// <para>The custom DNS server 2.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is available and required only when the <b>OrderActivateParam.N.AliyunDns</b> parameter is set to <b>false</b>.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Make sure that the custom DNS server is correct. Otherwise, the registration may fail.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ns1.aliyun.com</para>
            /// </summary>
            [NameInMap("Dns2")]
            [Validation(Required=false)]
            public string Dns2 { get; set; }

            /// <summary>
            /// <para>The domain name to be registered.</para>
            /// <remarks>
            /// <para>When you register a domain name, you must specify the domain name registrant information. Otherwise, the domain name registration fails. You can specify the domain name registrant information by using the OrderActivateParam.N.RegistrantProfileId parameter to associate a domain name registrant profile.</para>
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
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the domain name privacy protection service. Default value: <b>true</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>Specifies whether to allow the registration of premium domain names. Default value: <b>false</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PermitPremiumActivation")]
            [Validation(Required=false)]
            public bool? PermitPremiumActivation { get; set; }

            /// <summary>
            /// <para>The postal code.</para>
            /// <remarks>
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>102629</para>
            /// </summary>
            [NameInMap("PostalCode")]
            [Validation(Required=false)]
            public string PostalCode { get; set; }

            /// <summary>
            /// <para>The province name in English.</para>
            /// <remarks>
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>bei jing</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The domain name contact in English.</para>
            /// <remarks>
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>zhang san</para>
            /// </summary>
            [NameInMap("RegistrantName")]
            [Validation(Required=false)]
            public string RegistrantName { get; set; }

            /// <summary>
            /// <para>The name of the domain name registrant in English.</para>
            /// <remarks>
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>zhang san</para>
            /// </summary>
            [NameInMap("RegistrantOrganization")]
            [Validation(Required=false)]
            public string RegistrantOrganization { get; set; }

            /// <summary>
            /// <para>The ID of the domain name registrant profile. The profile contains information such as the name of the domain name registrant, the domain name contact, the phone number, and the email address. You can only use the ID of a real-name verified domain name registrant profile to register a domain name. If you have created a domain name registrant profile, you can call the <a href="https://help.aliyun.com/document_detail/67701.html">QueryRegistrantProfiles</a> operation to query the profile ID.</para>
            /// <remarks>
            /// <para>After you specify this parameter, you do not need to specify the <b>OrderActivateParam.N.RegistrantType</b>, <b>OrderActivateParam.N.ZhRegistrantOrganization</b>, <b>OrderActivateParam.N.ZhRegistrantName</b>, <b>OrderActivateParam.N.ZhProvince</b>, <b>OrderActivateParam.N.ZhCity</b>, <b>OrderActivateParam.N.ZhAddress</b>, <b>OrderActivateParam.N.RegistrantOrganization</b>, <b>OrderActivateParam.N.RegistrantName</b>, <b>OrderActivateParam.N.Province</b>, <b>OrderActivateParam.N.City</b>, <b>OrderActivateParam.N.Address</b>, <b>OrderActivateParam.N.PostalCode</b>, <b>OrderActivateParam.N.Country</b>, <b>OrderActivateParam.N.TelArea</b>, <b>OrderActivateParam.N.Telephone</b>, <b>OrderActivateParam.N.TelExt</b>, and <b>OrderActivateParam.N.Email</b> parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>000000</para>
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
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RegistrantType")]
            [Validation(Required=false)]
            public string RegistrantType { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// <remarks>
            /// <para>If this parameter is not specified or the specified resource group ID does not exist, the default resource group ID is used.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rg-XX</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The subscription duration. Unit: <b>year</b>. Default value: <b>1</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubscriptionDuration")]
            [Validation(Required=false)]
            public int? SubscriptionDuration { get; set; }

            /// <summary>
            /// <para>The country code for the phone number. For example, the country code for China is <b>86</b>.</para>
            /// <remarks>
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
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
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
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
            /// <para>This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1820000****</para>
            /// </summary>
            [NameInMap("Telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow the registration of trademark terms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TrademarkDomainActivation")]
            [Validation(Required=false)]
            public bool? TrademarkDomainActivation { get; set; }

            /// <summary>
            /// <para>The mailing address in Chinese.</para>
            /// <remarks>
            /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>朝阳区<em><b>大厦</b></em>号</para>
            /// </summary>
            [NameInMap("ZhAddress")]
            [Validation(Required=false)]
            public string ZhAddress { get; set; }

            /// <summary>
            /// <para>The city name in Chinese.</para>
            /// <remarks>
            /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
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
            /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("ZhProvince")]
            [Validation(Required=false)]
            public string ZhProvince { get; set; }

            /// <summary>
            /// <para>The domain name contact in Chinese.</para>
            /// <remarks>
            /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("ZhRegistrantName")]
            [Validation(Required=false)]
            public string ZhRegistrantName { get; set; }

            /// <summary>
            /// <para>The name of the domain name registrant in Chinese.</para>
            /// <remarks>
            /// <para>This parameter is applicable only to the China site. This parameter is available and required only when the <b>OrderActivateParam.N.RegistrantProfileId</b> parameter is not specified. If this parameter is not specified, the domain name registration fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("ZhRegistrantOrganization")]
            [Validation(Required=false)]
            public string ZhRegistrantOrganization { get; set; }

        }

        /// <summary>
        /// <para>The coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123124</para>
        /// </summary>
        [NameInMap("PromotionNo")]
        [Validation(Required=false)]
        public string PromotionNo { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a voucher.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseCoupon")]
        [Validation(Required=false)]
        public bool? UseCoupon { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UsePromotion")]
        [Validation(Required=false)]
        public bool? UsePromotion { get; set; }

        /// <summary>
        /// <para>The IP address of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
