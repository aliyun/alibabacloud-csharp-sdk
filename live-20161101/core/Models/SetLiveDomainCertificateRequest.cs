// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveDomainCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cert-****</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The certificate type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>upload</b>: a custom certificate</description></item>
        /// <item><description><b>cas</b>: a certificate that is purchased from Certificate Management Service</description></item>
        /// <item><description><b>free</b>: a free certificate (for testing)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>free</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The domain name that is secured by the certificate. The domain name uses <c>HTTPS</c>-based acceleration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>developer.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the certificate name for duplicates. A value of 1 indicates that the system does not perform the check and overwrites the information about the certificate that has the same name. Set the value to <b>1</b>.</para>
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
        /// <para>The private key.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set the SSLProtocol parameter to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the HTTPS certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>. If you set this parameter to <b>on</b>, you must also specify the SSLPub and SSLPri parameters.</description></item>
        /// <item><description><b>off</b>. This is the default value.</description></item>
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
        /// <para>The public key.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set the SSLProtocol parameter to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
