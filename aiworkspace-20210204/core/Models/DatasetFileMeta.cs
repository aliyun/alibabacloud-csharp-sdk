// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetFileMeta : TeaModel {
        /// <summary>
        /// <para>The MIME Type of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/jpeg</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The file size. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The metadata ID of the dataset file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07914c9534586e4e7aa6e9dbca5009082df******fd8a0d857b33296c59bf6</para>
        /// </summary>
        [NameInMap("DatasetFileMetaId")]
        [Validation(Required=false)]
        public string DatasetFileMetaId { get; set; }

        /// <summary>
        /// <para>The download URL of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=1712801702&OSSAccessKeyId=****************&Signature=x4oSjZcXOn7FHMCT1D****NuNjs%3D">https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=1712801702&amp;OSSAccessKeyId=****************&amp;Signature=x4oSjZcXOn7FHMCT1D****NuNjs%3D</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The time when the file was created. A UTC timestamp in the ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The file fingerprint, used to determine the uniqueness of the file content. This value changes after the file content is modified. OSS files use ETags, and NAS files use MD5 values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D41D8CD98F*****E9800998ECF8</para>
        /// </summary>
        [NameInMap("FileFingerPrint")]
        [Validation(Required=false)]
        public string FileFingerPrint { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cat.png</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The file type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The last modified time of the file. A UTC timestamp in the ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileUpdateTime")]
        [Validation(Required=false)]
        public string FileUpdateTime { get; set; }

        /// <summary>
        /// <para>The specific metadata of the file. For example, the width and height of an image file, or the bitrate and resolution of a video file. This parameter cannot be used for retrieval. In JSON String format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;ImageHeight&quot;: 400,     &quot;ImageWidth&quot;: 800 }</para>
        /// </summary>
        [NameInMap("MetaAttributes")]
        [Validation(Required=false)]
        public string MetaAttributes { get; set; }

        /// <summary>
        /// <para>The similarity score.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.6</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public float? Score { get; set; }

        /// <summary>
        /// <para>The ID of the last semantic indexing job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsjob-klfwtjto****scvt3</para>
        /// </summary>
        [NameInMap("SemanticIndexJobId")]
        [Validation(Required=false)]
        public string SemanticIndexJobId { get; set; }

        /// <summary>
        /// <para>The last update time of the semantic index. A UTC timestamp in the ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("SemanticIndexUpdateTime")]
        [Validation(Required=false)]
        public string SemanticIndexUpdateTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the metadata, in JSON string format. Including:</para>
        /// <list type="bullet">
        /// <item><description><para>Algorithm tag group:</para>
        /// <list type="bullet">
        /// <item><description>ai: tags from all algorithm tagging tasks on this metadata.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>User-defined tag group:</para>
        /// <list type="bullet">
        /// <item><description>user: tags added by the user to this metadata.</description></item>
        /// <item><description>user-delete-ai-tags: tags from the algorithm tag group that the user needs to delete.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ai&quot;:
        ///     [
        ///         &quot;Felis catus&quot;,
        ///         &quot;Shorthair&quot;
        ///     ],
        ///     &quot;user&quot;:
        ///     [
        ///         &quot;cat&quot;,
        ///         &quot;White&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The URL of the thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=171280****&OSSAccessKeyId=LTAI************&Signature=****jZcXOn7FHMCT1DLE22NuNjs%3D">https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=171280****&amp;OSSAccessKeyId=LTAI************&amp;Signature=****jZcXOn7FHMCT1DLE22NuNjs%3D</a></para>
        /// </summary>
        [NameInMap("ThumbnailUrl")]
        [Validation(Required=false)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// <para>The URI of the file. Used to record the unique path of the file. File paths in Object Storage Service (OSS) and File Storage NAS (NAS) are supported.</para>
        /// <para><b>OSS</b></para>
        /// <para>oss://${bucket}/${path}</para>
        /// <para><b>NAS</b></para>
        /// <para>nas://${fileSystemId}/${path}</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/dataset/cat.png</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
