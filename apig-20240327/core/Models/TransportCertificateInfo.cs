// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class TransportCertificateInfo : TeaModel {
        /// <summary>
        /// <para>The signature or key algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The certificate identifier, which is the certificate ID under the APIG cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-1（1716***@cn-hangzhou 形态）</para>
        /// </summary>
        [NameInMap("certIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-name</para>
        /// </summary>
        [NameInMap("certName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The matching status between the certificate and the instance domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Matched</para>
        /// </summary>
        [NameInMap("certificateMatchStatus")]
        [Validation(Required=false)]
        public string CertificateMatchStatus { get; set; }

        /// <summary>
        /// <para>The common name (CN) of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.example.com</para>
        /// </summary>
        [NameInMap("commonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The set of covered domain names parsed from the CN and SAN. The domain names are in lowercase, deduplicated, and may include wildcards such as *.</para>
        /// </summary>
        [NameInMap("coveredDomains")]
        [Validation(Required=false)]
        public List<string> CoveredDomains { get; set; }

        /// <summary>
        /// <para>The certificate issuer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DigiCert Secure Site CN CA G3</para>
        /// </summary>
        [NameInMap("issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The gateway instance domain names matched by the covered domain names. The order follows the instance domain names, and the results are deduplicated.</para>
        /// </summary>
        [NameInMap("matchedDomains")]
        [Validation(Required=false)]
        public List<string> MatchedDomains { get; set; }

        /// <summary>
        /// <para>The expiration timestamp in UNIX milliseconds, which is obtained from the afterDate of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1747958400000</para>
        /// </summary>
        [NameInMap("notAfterTimestamp")]
        [Validation(Required=false)]
        public long? NotAfterTimestamp { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp for the effective period in milliseconds, which is obtained from the beforeDate of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1716336000000</para>
        /// </summary>
        [NameInMap("notBeforeTimestamp")]
        [Validation(Required=false)]
        public long? NotBeforeTimestamp { get; set; }

        /// <summary>
        /// <para>The raw Subject Alternative Name (SAN) string separated by commas, semicolons, or spaces. Elements may include the DNS: prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DNS:*.example.org, DNS:foo.example.net</para>
        /// </summary>
        [NameInMap("sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

    }

}
