// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate. It is the globally unique identifier (GUID) of the certificate in Certificates Manager.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9a28de48-8d8b-484d-a766-dec4****</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

    }

}
