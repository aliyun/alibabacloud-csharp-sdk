// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class GetTlsInspectCertificateDownloadUrlResponseBody : TeaModel {
        [NameInMap("CaCertId")]
        [Validation(Required=false)]
        public string CaCertId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://cfw-tls-inspect-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/tls_cert%2F2025-08-13%2F1850">https://cfw-tls-inspect-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/tls_cert%2F2025-08-13%2F1850</a>****</para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>850A84D6-0DE4-4797-A1E8-******h4j6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
