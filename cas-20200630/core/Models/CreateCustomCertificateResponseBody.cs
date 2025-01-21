// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateCustomCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the certificate. This parameter is returned only if Immediately is set to 1 or 2.</para>
        /// 
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
        /// <para>The certificate chain of the certificate. This parameter is returned only if Immediately is set to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIIBfzCCATGgAwIBAgIUfI5kSdcO2S0+LkpdL3b2VUJG10YwBQYDK2VwMDUxCzAJ
        /// ...
        /// ...
        /// ...
        /// ZYYG
        /// -----END CERTIFICATE-----
        /// -----BEGIN CERTIFICATE-----
        /// MIIBczCCARgCAQAwgYoxFDASBgNVBAMMC2FsaXl1bi50ZXN0MQ0wCwYDVQQ
        /// ...
        /// ...
        /// ...
        /// KL5cUmF
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("CertificateChain")]
        [Validation(Required=false)]
        public string CertificateChain { get; set; }

        /// <summary>
        /// <para>The unique identifier of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160ae6bb538d538c70c01f81dcf2****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The serial number of the certificate. This parameter is returned only if Immediately is set to 1 or 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>084bde9cd233f0ddae33adc438cfbbbd****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}
