// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchSetDcdnDomainCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-te**.com</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The type of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>upload</b>: a custom certificate that you upload.</description></item>
        /// <item><description><b>cas</b>: a certificate that is acquired through Certificate Management Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cas</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The accelerated domain name for which you want to configure the HTTPS certificate. The accelerated domain must have HTTPS acceleration enabled. You can specify multiple domain names and separate them with commas (,).</para>
        /// <remarks>
        /// <para>You can configure up to 10 domain names in each request.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b>example</b>.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The private key. This parameter is required only if you enable the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>y****</para>
        /// </summary>
        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the HTTPS certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the HTTPS certificate.</description></item>
        /// <item><description><b>off</b>: does not enable the HTTPS certificate.</description></item>
        /// </list>
        /// <para>This is the default value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SSLProtocol")]
        [Validation(Required=false)]
        public string SSLProtocol { get; set; }

        /// <summary>
        /// <para>The content of the certificate. This parameter is required only if you enable the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x****</para>
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
