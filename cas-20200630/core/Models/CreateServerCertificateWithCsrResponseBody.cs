// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateServerCertificateWithCsrResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate chain of the server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----\n......\n-----END CERTIFICATE-----\n-----BEGIN CERTIFICATE-----\n......\n-----END CERTIFICATE-----\n</para>
        /// </summary>
        [NameInMap("CertificateChain")]
        [Validation(Required=false)]
        public string CertificateChain { get; set; }

        /// <summary>
        /// <para>The unique identifier of the server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180ae6bb538d538c70c01f81dcf2****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The serial number of the server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>084bde9cd233f0ddae33adc438cfbbbd****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The content of the server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----\n......\n-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("X509Certificate")]
        [Validation(Required=false)]
        public string X509Certificate { get; set; }

    }

}
