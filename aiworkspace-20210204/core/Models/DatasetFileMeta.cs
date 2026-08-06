// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetFileMeta : TeaModel {
        /// <summary>
        /// <para>The MIME type of the file. The value contains the type and subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/jpeg</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The file size, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The dataset file metadata ID.</para>
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
        /// <para><a href="https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=171280****&OSSAccessKeyId=LTAI************&Signature=****jZcXOn7FHMCT1DLE22NuNjs%3D">https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=171280****&amp;OSSAccessKeyId=LTAI************&amp;Signature=****jZcXOn7FHMCT1DLE22NuNjs%3D</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The file creation time. The value is a UTC timestamp in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The file fingerprint value. This parameter is used to determine the uniqueness of the file content. The value changes when the file content is modified. The ETag is used for OSS files, and the MD5 value is used for NAS files.</para>
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
        /// <para>The file type. The value is the same as the MIME type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The last modification time of the file. The value is a UTC timestamp in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileUpdateTime")]
        [Validation(Required=false)]
        public string FileUpdateTime { get; set; }

        /// <summary>
        /// <para>The specific metadata of the file. For example, image width and height, or video bitrate and resolution. Search is not supported for this field. The value is in JSON string format.</para>
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
        /// <para>The task ID of the last semantic index build.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsjob-klfwtjto****scvt3</para>
        /// </summary>
        [NameInMap("SemanticIndexJobId")]
        [Validation(Required=false)]
        public string SemanticIndexJobId { get; set; }

        /// <summary>
        /// <para>The last update time of the semantic index. The value is a UTC timestamp in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("SemanticIndexUpdateTime")]
        [Validation(Required=false)]
        public string SemanticIndexUpdateTime { get; set; }

        /// <summary>
        /// <para>The current status of the metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACTIVE: active.</description></item>
        /// <item><description>DELETED: deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The collection of labels for the metadata, in JSON string format. The following label groups are included:</para>
        /// <list type="bullet">
        /// <item><description>Algorithm label group:<list type="bullet">
        /// <item><description>ai: the list of label names aggregated from all algorithm labeling tasks for a single metadata entry.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>User-defined label group:<list type="bullet">
        /// <item><description>user: the list of label names manually added by the user for a single metadata entry.</description></item>
        /// <item><description>user-delete-ai-tags: the list of label names in the algorithm label group that the user wants to delete for a single metadata entry.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ai&quot;:
        ///     [
        ///         &quot;Lane line&quot;,
        ///         &quot;Water horse&quot;,
        ///         &quot;Sunny day&quot;
        ///     ],
        ///     &quot;user&quot;:
        ///     [
        ///         &quot;Everett&quot;,
        ///         &quot;Intelligent driving Dataset 1&quot;,
        ///         &quot;Cloudy day&quot;
        ///     ],
        ///     &quot;user-delete-ai-tags&quot;:
        ///     [
        ///         &quot;Sunny day&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The thumbnail URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=171280****&OSSAccessKeyId=LTAI************&Signature=****jZcXOn7FHMCT1DLE22NuNjs%3D">https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=171280****&amp;OSSAccessKeyId=LTAI************&amp;Signature=****jZcXOn7FHMCT1DLE22NuNjs%3D</a></para>
        /// </summary>
        [NameInMap("ThumbnailUrl")]
        [Validation(Required=false)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// <para>The unique URI of the file. This parameter is used to record the unique path of the file. File paths in OSS and NAS are supported.</para>
        /// <details>
        /// <summary>OSS</summary>
        /// oss://${bucket}/${path}
        /// </details>
        /// <details>
        /// <summary>NAS</summary>
        /// nas://${fileSystemId}/${path}
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/dataset/cat.png</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
