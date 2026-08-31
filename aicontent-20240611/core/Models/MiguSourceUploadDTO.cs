// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class MiguSourceUploadDTO : TeaModel {
        /// <summary>
        /// <para>The expiration time of the upload URL in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-28T12:00:00Z</para>
        /// </summary>
        [NameInMap("expiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// <para>The type of the source file (uppercase). Valid values: VIDEO, IMAGE, AUDIO, and TEXT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIDEO</para>
        /// </summary>
        [NameInMap("fileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the source file, used for subsequent generation tasks and downloads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f2a1b9c8d7e4f60a1b2c3d4e5f6a7b8</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The OSS pre-signed upload URL. Use the PUT method to upload the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket.oss-cn-beijing.aliyuncs.com/pipeline/source/xxx.mp4?Expires=1700000000&Signature=xxx">https://bucket.oss-cn-beijing.aliyuncs.com/pipeline/source/xxx.mp4?Expires=1700000000&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("uploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
