// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateExternalCACertificateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIIEkjCCA3qgAwIBAgIQCgFBQgAAAVOFc2oLheynCDANBgkqhkiG9w0BAQsFADA/
        /// ...
        /// ...
        /// ...
        /// KOqkqm57TH2H3eDJAkSnh6/DNFu0Qg==
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// ...
        /// ...
        /// -----END CERTIFICATE-----
        /// -----BEGIN CERTIFICATE-----
        /// ...
        /// ...
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("CertificateChain")]
        [Validation(Required=false)]
        public string CertificateChain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1ed4068c-6f1b-6deb-8e32-3f8439a851cb</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
