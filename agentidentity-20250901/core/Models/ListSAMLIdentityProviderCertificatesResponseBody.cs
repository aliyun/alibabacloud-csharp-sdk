// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListSAMLIdentityProviderCertificatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("X509Certificates")]
        [Validation(Required=false)]
        public List<ListSAMLIdentityProviderCertificatesResponseBodyX509Certificates> X509Certificates { get; set; }
        public class ListSAMLIdentityProviderCertificatesResponseBodyX509Certificates : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cert-xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----
            /// MIIDdz...
            /// -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("X509Certificate")]
            [Validation(Required=false)]
            public string X509Certificate { get; set; }

        }

    }

}
