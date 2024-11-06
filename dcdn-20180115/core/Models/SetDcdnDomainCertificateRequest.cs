// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnDomainCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourCertName</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The certificate type.</para>
        /// <list type="bullet">
        /// <item><description><b>upload</b>: a user-uploaded SSL certificate.</description></item>
        /// <item><description><b>cas</b>: a certificate that is acquired through Certificate Management Service.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value of the CertType parameter is <b>cas</b>, the <b>SSLPri</b> parameter is not required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cas</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name.</para>
        /// <para>HTTPS acceleration must be enabled for the accelerated domain name.</para>
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
        /// <para>The region. Default value: ch-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The private key. This parameter is required only if you enable the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSLPri</para>
        /// </summary>
        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the SSL certificate.</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
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
        /// <para>The certificate content. This parameter is required only if you enable the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSLPub</para>
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
