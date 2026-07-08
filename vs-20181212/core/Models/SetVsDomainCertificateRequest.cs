// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class SetVsDomainCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cert-77****7</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The certificate type.</para>
        /// <list type="bullet">
        /// <item><description><para>upload: Upload certificate</para>
        /// </description></item>
        /// <item><description><para>cas: Alibaba Cloud Security certificate</para>
        /// </description></item>
        /// <item><description><para>free: Personal test certificate (Free Edition)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>free</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The accelerated domain name to which the certificate belongs.</para>
        /// <remarks>
        /// <para>The domain must use HTTPS acceleration.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Set to 1 to skip the certificate name duplication check and overwrite an existing certificate with the same name.</para>
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
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The private key content. Omit this parameter if you disable the certificate. Provide the private key content if you configure a certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxx</para>
        /// </summary>
        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        /// <summary>
        /// <para>Whether to enable the HTTPS certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>off</b> (default): Disable.</para>
        /// </description></item>
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
        /// <para>The public certificate content. Omit this parameter if you disable the certificate. Provide the certificate content if you configure a certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>328uiuii28****82dsada81</para>
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

    }

}
