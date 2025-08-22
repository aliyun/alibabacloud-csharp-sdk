// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnDomainSSLCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The certificate ID. This parameter is required and valid only when <b>CertType</b> is set to <b>cas</b>. If you specify this parameter, an existing certificate is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8089870</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

        /// <summary>
        /// <para>The name of the new certificate. You can specify only one certificate name. This parameter is optional and valid only when <b>CertType</b> is set to <b>upload</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourCertName</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The region of the SSL certificate. This parameter takes effect only when <b>CertType</b> is set to <b>cas</b>. Default value: <b>cn-hangzhou</b>. Valid values: <b>cn-hangzhou</b> and <b>ap-southeast-1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertRegion")]
        [Validation(Required=false)]
        public string CertRegion { get; set; }

        /// <summary>
        /// <para>The type of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>upload</b>: a user-uploaded SSL certificate.</description></item>
        /// <item><description><b>cas</b>: a certificate that is acquired through Certificate Management Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>upload</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The domain name that is secured by the SSL certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The private key. Specify the private key only if you want to enable the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>y****</para>
        /// </summary>
        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the SSL certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SSLProtocol")]
        [Validation(Required=false)]
        public string SSLProtocol { get; set; }

        /// <summary>
        /// <para>The content of the SSL certificate. Specify the content of the SSL certificate only if you want to enable the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
