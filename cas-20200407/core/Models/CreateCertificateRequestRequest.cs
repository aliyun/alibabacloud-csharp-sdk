// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCertificateRequestRequest : TeaModel {
        /// <summary>
        /// <para>The domain name that you want to bind to the certificate. You can specify only one domain name.</para>
        /// <remarks>
        /// <para> The domain name must match the certificate specifications that you specify for the <b>ProductCode</b> parameter. If you apply for a single-domain certificate, you must specify a single domain name for this parameter. If you apply for a wildcard certificate, you must specify a wildcard domain name such as <c>*.aliyundoc.com</c> for this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The contact email address of the applicant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The phone number of the applicant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The specifications of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>digicert-free-1-free</b> (default): DigiCert single-domain DV certificate, which is free and valid for 3 months.</description></item>
        /// <item><description><b>symantec-free-1-free</b>: DigiCert single-domain DV certificate, which is free and valid for 1 year. This value is available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>symantec-dv-1-starter</b>: DigiCert wildcard DV certificate.</description></item>
        /// <item><description><b>geotrust-dv-1-starter</b>: GeoTrust single-domain DV certificate.</description></item>
        /// <item><description><b>geotrust-dv-w-starter</b>: GeoTrust wildcard DV certificate.</description></item>
        /// <item><description><b>globalsign-dv-1-personal</b>: GlobalSign single-domain DV certificate.</description></item>
        /// <item><description><b>globalsign-dv-w-advanced</b>: GlobalSign wildcard DV certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>symantec-free-1-free</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateCertificateRequestRequestTags> Tags { get; set; }
        public class CreateCertificateRequestRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. You cannot specify empty strings as tag keys.</para>
            /// <para>The key can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The key must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para> You must specify at least one of <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>acs:rm:rgId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value cannot exceed 128 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). The key must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the applicant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tom</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The method to verify the ownership of a domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DNS</b>: DNS verification. If you use this method, you must add a TXT record to the DNS records of the domain name in the management platform of the domain name. You must have operation permissions on domain name resolution to verify the ownership of the domain name.</description></item>
        /// <item><description><b>FILE</b>: file verification. If you use this method, you must create a specified file on the DNS server. You must have administrative rights on the DNS server to verify the ownership of the domain name.</description></item>
        /// </list>
        /// <para>For more information about the verification methods, see <a href="https://help.aliyun.com/document_detail/48016.html">Verify the ownership of a domain name</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DNS</para>
        /// </summary>
        [NameInMap("ValidateType")]
        [Validation(Required=false)]
        public string ValidateType { get; set; }

    }

}
