// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveCertificateDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----****-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23451111</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

        /// <summary>
        /// <para>The name of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cert-****</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7C69682-7F88-40DD-A198-10D0309E439B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
