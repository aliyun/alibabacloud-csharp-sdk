// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest : TeaModel {
        /// <summary>
        /// <para>Specific address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chao yang qu</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>City.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bei jing shi</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Country code, such as <b>CN</b> or <b>US</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>List of domain names.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibabacloud.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public List<string> DomainName { get; set; }

        /// <summary>
        /// <para>Mailbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Base64-encoded image of the identity verification document. Image requirements:</para>
        /// <list type="bullet">
        /// <item><description>Format must be <b>jpg</b> or <b>bmp</b>.</description></item>
        /// <item><description>Original image size must be between <b>55 KB and 1 MB</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h6UPhXz/ADP/2Q==</para>
        /// </summary>
        [NameInMap("IdentityCredential")]
        [Validation(Required=false)]
        public string IdentityCredential { get; set; }

        /// <summary>
        /// <para>Certificate number used for identity verification, such as an ID card number or Unified Social Credit Code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5****************9</para>
        /// </summary>
        [NameInMap("IdentityCredentialNo")]
        [Validation(Required=false)]
        public string IdentityCredentialNo { get; set; }

        /// <summary>
        /// <para>Identity verification certificate type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SFZ</b>: Identity card.</description></item>
        /// <item><description><b>HZ</b>: Passport.</description></item>
        /// <item><description><b>YYZZ</b>: Business license.</description></item>
        /// <item><description><b>ORG</b>: Organization code certificate.</description></item>
        /// <item><description><b>XYDM</b>: Unified Social Credit Code certificate.</description></item>
        /// <item><description><b>TXZ</b>: Mainland Travel Permits for Hong Kong and Macao Residents.</description></item>
        /// </list>
        /// <para>If your certificate type is not listed above, see <a href="https://help.aliyun.com/document_detail/72209.html">Supported identity verification certificate types</a> for valid values of other certificate types.</para>
        /// <remarks>
        /// <para>You must select the certificate type that matches the document you are submitting.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SFZ</para>
        /// </summary>
        [NameInMap("IdentityCredentialType")]
        [Validation(Required=false)]
        public string IdentityCredentialType { get; set; }

        /// <summary>
        /// <para>Language of the error message returned by the API. Valid values:</para>
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
        /// <para>Postal code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("PostalCode")]
        [Validation(Required=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// <para>Province.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bei jing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>Contact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <para>Registrant organization name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce shi</para>
        /// </summary>
        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        /// <summary>
        /// <para>Domain registrant type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Individual.</description></item>
        /// <item><description><b>2</b>: Organization.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        /// <summary>
        /// <para>Telephone country code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("TelArea")]
        [Validation(Required=false)]
        public string TelArea { get; set; }

        /// <summary>
        /// <para>Telephone extension number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("TelExt")]
        [Validation(Required=false)]
        public string TelExt { get; set; }

        /// <summary>
        /// <para>Telephone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// <para>Whether to add a transfer-out prohibition restriction. This indicates whether modifying the registrant imposes a 60-day restriction on domain name transfer-out. Default value: <b>false</b>, which means transfer-out is not restricted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TransferOutProhibited")]
        [Validation(Required=false)]
        public bool? TransferOutProhibited { get; set; }

        /// <summary>
        /// <para>User IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>Chinese address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>朝阳区</para>
        /// </summary>
        [NameInMap("ZhAddress")]
        [Validation(Required=false)]
        public string ZhAddress { get; set; }

        /// <summary>
        /// <para>Chinese city name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京市</para>
        /// </summary>
        [NameInMap("ZhCity")]
        [Validation(Required=false)]
        public string ZhCity { get; set; }

        /// <summary>
        /// <para>Chinese province name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京</para>
        /// </summary>
        [NameInMap("ZhProvince")]
        [Validation(Required=false)]
        public string ZhProvince { get; set; }

        /// <summary>
        /// <para>Chinese contact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        /// <summary>
        /// <para>Chinese registrant organization name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
