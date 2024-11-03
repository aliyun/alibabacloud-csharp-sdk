// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetDomainServerCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the SSL certificate. You can specify only one name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myCert1</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The type of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>upload</b>: a user-uploaded SSL certificate.</description></item>
        /// <item><description><b>cas</b>: a certificate that is purchased from Alibaba Cloud SSL Certificates Service.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to <b>cas</b>, the <b>PrivateKey</b> parameter is optional.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cas</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The accelerated domain name for which you want to configure the SSL certificate. The type of request supported by the domain name must be HTTPS.</para>
        /// <para>You can specify one domain name in each call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the certificate name for duplicates. If you set the value to 1, the system does not perform the check and overwrites the information about the existing certificate that uses the same name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ForceSet")]
        [Validation(Required=false)]
        public string ForceSet { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The private key. Specify the private key only if you want to enable the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>----BEGIN RSA PRIVATE KEY-----QswCQ****----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The content of the SSL certificate. Specify the content of the SSL certificate only if you want to enable the SSL certificate. You can use one of the following methods to obtain the content of the SSL certificate:</para>
        /// <list type="bullet">
        /// <item><description>Method 1: Call the <a href="https://help.aliyun.com/document_detail/91182.html">DescribeDomainCertificateInfo</a> API operation to query the information about the SSL certificate corresponding to the accelerated domain name and obtain the public key of the ServerCertificate certificate from the returned data.</description></item>
        /// <item><description>Method 2: Call the <a href="https://help.aliyun.com/document_detail/91181.html">DescribeCdnCertificateList</a> API operation to query the SSL certificate list corresponding to the accelerated domain name, and obtain the value of CertName from the returned data. Then, Call the <a href="https://help.aliyun.com/document_detail/131905.html">DescribeCdnCertificateDetail</a> API operation with CertName as a parameter to obtain the details about the certificate, and obtain the public key of the Cert certificate from the returned data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>----BEGIN CERTIFICATE----- MIIFz****-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ServerCertificate")]
        [Validation(Required=false)]
        public string ServerCertificate { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the SSL certificate. Default value: off. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b> : enables the SSL certificate.</description></item>
        /// <item><description><b>off</b>: disables the SSL certificate.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("ServerCertificateStatus")]
        [Validation(Required=false)]
        public string ServerCertificateStatus { get; set; }

    }

}
