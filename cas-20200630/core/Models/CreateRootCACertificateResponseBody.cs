// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateRootCACertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The root CA certificate in the PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----\n......\n-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The certificate chain of the root CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----\n......\n-----END CERTIFICATE-----\n-----BEGIN CERTIFICATE-----\n......\n-----END CERTIFICATE-----\n</para>
        /// </summary>
        [NameInMap("CertificateChain")]
        [Validation(Required=false)]
        public string CertificateChain { get; set; }

        /// <summary>
        /// <para>The unique identifier of the root CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a83bcbb89e562885e40aa0108f5****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D9B4C5F-7140-5B41-924C-329181DC00C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
