// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class MiguSourceDownloadDTO : TeaModel {
        /// <summary>
        /// <para>The OSS pre-signed download URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket.oss-cn-beijing.aliyuncs.com/pipeline/source/xxx.mp4?Expires=1700000000&Signature=xxx">https://bucket.oss-cn-beijing.aliyuncs.com/pipeline/source/xxx.mp4?Expires=1700000000&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The expiration time of the download URL, in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-28T12:00:00Z</para>
        /// </summary>
        [NameInMap("expiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// <para>The download request method. The value is fixed to GET.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The unique identifier of the source file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f2a1b9c8d7e4f60a1b2c3d4e5f6a7b8</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
