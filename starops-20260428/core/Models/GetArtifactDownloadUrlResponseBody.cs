// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class GetArtifactDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1770000000</para>
        /// </summary>
        [NameInMap("expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-1234567890AB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/agents/123/sample-agent/home/starops/reports/summary.pdf?response-content-disposition=attachment&Expires=1770000000&OSSAccessKeyId=LTAI******&Signature=">https://example-bucket.oss-cn-shanghai.aliyuncs.com/agents/123/sample-agent/home/starops/reports/summary.pdf?response-content-disposition=attachment&amp;Expires=1770000000&amp;OSSAccessKeyId=LTAI******&amp;Signature=</a>******</para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
