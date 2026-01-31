// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetCertificateDetailRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18594156</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public long? CertificateId { get; set; }

    }

}
