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
        /// <item><description><b>upload</b>: an uploaded certificate.</description></item>
        /// <item><description><b>cas</b>: a certificate from SSL Certificates Service.</description></item>
        /// <item><description><b>free</b>: a personal test certificate (Free Edition).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>free</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The accelerated domain name to which the certificate belongs. The domain name is of the <c>https</c> acceleration type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>developer.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without actually executing the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: sends a dry run request. If the request passes the check, the operation is not actually executed.</description></item>
        /// <item><description>false (default): sends a normal request. If the request passes the check, the operation is actually executed.</description></item>
        /// </list>
        /// <para>The dry run checks parameter validity, RAM permissions, and resource status. If the dry run fails, the corresponding error code is returned. If the dry run succeeds, the operation is not actually executed.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Ignores the check for duplicate certificate names and overwrites the existing certificate information with the same name. Fixed value: <b>1</b>.</para>
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
        /// <para>The private key content.</para>
        /// <remarks>
        /// <para>This parameter is required only when SSLProtocol is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the HTTPS certificate. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled. If the value is <b>on</b>, you must also set the SSLPub and SSLPri request parameters.</description></item>
        /// <item><description><b>off</b> (default): disabled.</description></item>
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
        /// <para>The public key content.</para>
        /// <remarks>
        /// <para>This parameter is required only when SSLProtocol is set to on.</para>
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
