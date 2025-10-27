// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class GetTlsInspectCertificateDownloadUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3E91391-16CD-1BFC-A133-******D429</para>
        /// </summary>
        [NameInMap("CaCertId")]
        [Validation(Required=false)]
        public string CaCertId { get; set; }

    }

}
