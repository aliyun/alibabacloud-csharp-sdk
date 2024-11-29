// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateClientCertificateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("CSR")]
        [Validation(Required=false)]
        public string CSR { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RSA</para>
        /// </summary>
        [NameInMap("PkeyType")]
        [Validation(Required=false)]
        public string PkeyType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
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
