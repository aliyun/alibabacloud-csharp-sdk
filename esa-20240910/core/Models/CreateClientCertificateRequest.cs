// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateClientCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The certificate signing request (CSR) content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("CSR")]
        [Validation(Required=false)]
        public string CSR { get; set; }

        /// <summary>
        /// <para>The private key algorithm type. This parameter is required if CSR is not provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA</para>
        /// </summary>
        [NameInMap("PkeyType")]
        [Validation(Required=false)]
        public string PkeyType { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The validity period of the certificate. Unit: days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("ValidityDays")]
        [Validation(Required=false)]
        public long? ValidityDays { get; set; }

    }

}
