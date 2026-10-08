// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveRegistrantProfileRealNameVerificationRequest : TeaModel {
        /// <summary>
        /// <para>Detailed address (in English).  </para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>chao yang qu</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>City (in English).  </para>
        /// <remarks>
        /// <para>This parameter is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. If this parameter is not provided, domain name registration will fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bei jing shi</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Country code, such as <b>CN</b>.</para>
        /// <remarks>
        /// <para>This parameter is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>Email address.  </para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Base64-encoded image of the identity verification document. Image requirements:  </para>
        /// <list type="bullet">
        /// <item><description>Format must be <b>jpg</b> or <b>bmp</b>.  </description></item>
        /// <item><description>Original image size must be between <b>55 KB and 1 MB</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dGVzdA==</para>
        /// </summary>
        [NameInMap("IdentityCredential")]
        [Validation(Required=false)]
        public string IdentityCredential { get; set; }

        /// <summary>
        /// <para>Certificate number for identity verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4111111111111110**</para>
        /// </summary>
        [NameInMap("IdentityCredentialNo")]
        [Validation(Required=false)]
        public string IdentityCredentialNo { get; set; }

        /// <summary>
        /// <para>Type of certificate used for identity verification. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>SFZ</b>: Identity card.  </description></item>
        /// <item><description><b>HZ</b>: Passport.  </description></item>
        /// <item><description><b>YYZZ</b>: Business license.  </description></item>
        /// <item><description><b>ORG</b>: Organization code certificate.  </description></item>
        /// <item><description><b>XYDM</b>: Unified Social Credit Code certificate.  </description></item>
        /// <item><description><b>TXZ</b>: Mainland Travel Permits for Hong Kong and Macao Residents.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more certificate types, see <a href="https://help.aliyun.com/document_detail/72209.html">Supported Certificate Types for Identity Verification</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SFZ</para>
        /// </summary>
        [NameInMap("IdentityCredentialType")]
        [Validation(Required=false)]
        public string IdentityCredentialType { get; set; }

        /// <summary>
        /// <para>Language of the error message returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese  </description></item>
        /// <item><description><b>en</b>: English</description></item>
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
        /// <para>Postal code.  </para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("PostalCode")]
        [Validation(Required=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// <para>Province (in English).  </para>
        /// <remarks>
        /// <para>This parameter is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. If this parameter is not provided, domain name registration will fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bei jing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>Domain name contact (in English).  </para>
        /// <remarks>
        /// <para>This parameter is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. If this parameter is not provided, domain name registration will fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <para>Registrant name (in English).</para>
        /// <remarks>
        /// <para>This parameter is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <para>ID of the registrant profile template to be saved.  </para>
        /// <para>The system automatically generates this ID after a registrant profile is successfully created. You can invoke the <a href="https://help.aliyun.com/document_detail/67701.html">QueryRegistrantProfiles</a> API to query the registrant profile ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <para>Templatetype. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: General template.  </description></item>
        /// <item><description><b>cnnic</b>: CNNIC template.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The CNNIC template is supported only on the Alibaba Cloud international site (alibabacloud.com). Domains under the CNNIC registry, such as &quot;.cn&quot; and &quot;.中国&quot;, registered on the Alibaba Cloud international site must use the CNNIC template. Other domains must use the general template.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("RegistrantProfileType")]
        [Validation(Required=false)]
        public string RegistrantProfileType { get; set; }

        /// <summary>
        /// <para>Type of the registrant. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Individual.  </description></item>
        /// <item><description><b>2</b>: Enterprise or organization.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        /// <summary>
        /// <para>Telephone country code.</para>
        /// <remarks>
        /// <para>For example, the telephone country code for China is <b>86</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("TelArea")]
        [Validation(Required=false)]
        public string TelArea { get; set; }

        /// <summary>
        /// <para>Extension number.</para>
        /// <remarks>
        /// <para>This parameter is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TelExt")]
        [Validation(Required=false)]
        public string TelExt { get; set; }

        /// <summary>
        /// <para>Telephone number.  </para>
        /// <remarks>
        /// <para>This parameter is available and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// <para>User IP address. You can set it to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>Full address (in Chinese).</para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com). It is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>朝阳区</para>
        /// </summary>
        [NameInMap("ZhAddress")]
        [Validation(Required=false)]
        public string ZhAddress { get; set; }

        /// <summary>
        /// <para>City (in Chinese).  </para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com). It is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. If this parameter is not provided, domain name registration will fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>北京市</para>
        /// </summary>
        [NameInMap("ZhCity")]
        [Validation(Required=false)]
        public string ZhCity { get; set; }

        /// <summary>
        /// <para>Province (in Chinese).  </para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com). It is available and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>北京</para>
        /// </summary>
        [NameInMap("ZhProvince")]
        [Validation(Required=false)]
        public string ZhProvince { get; set; }

        /// <summary>
        /// <para>Domain name contact (in Chinese).  </para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com). It is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. If this parameter is not provided, domain name registration will fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        /// <summary>
        /// <para>Registrant name (in Chinese).</para>
        /// <remarks>
        /// <para>This parameter applies only to the China site (aliyun.com). It is active and required only when the <b>RegistrantProfileId</b> parameter is not provided. Failure to provide it will cause domain registration to fail.</para>
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
