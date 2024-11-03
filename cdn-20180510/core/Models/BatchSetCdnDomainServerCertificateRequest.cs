// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchSetCdnDomainServerCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourCertName</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The type of the SSL certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>upload</b>: a user-uploaded SSL certificate.</description></item>
        /// <item><description><b>cas</b>: a certificate that is issued by SSL Certificates Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cas</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The accelerated domain name to which the SSL certificate belongs. The type of request supported by the accelerated domain name must be HTTPS. You can specify multiple accelerated domain names and separate them with commas (,).</para>
        /// <remarks>
        /// <para> You can manage the SSL certificates of up to 50 accelerated domain names in each call.</para>
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
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your region</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The private key. Specify the private key only if you enable the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourSSLPri</para>
        /// </summary>
        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the SSL certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the SSL certificate.</description></item>
        /// <item><description><b>off</b>: disables the SSL certificate. This is the default value.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SSLProtocol")]
        [Validation(Required=false)]
        public string SSLProtocol { get; set; }

        /// <summary>
        /// <para>The content of the SSL certificate. Specify the content of the certificate only if you want to enable the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourSSLPub</para>
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
