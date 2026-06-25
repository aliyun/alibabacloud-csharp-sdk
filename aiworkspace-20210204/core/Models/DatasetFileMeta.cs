// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetFileMeta : TeaModel {
        /// <summary>
        /// <para>The MIME type of the file. It includes a type and a subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/jpeg</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The size of the file in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The ID of the dataset file metadata.</para>
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
        /// <para>The time when the file was created. The time is in UTC and in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The file fingerprint. This value ensures the uniqueness of the file content and changes if the content is modified. The ETag is used for OSS files, and the MD5 value is used for NAS files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D41D8CD98F*****E9800998ECF8</para>
        /// </summary>
        [NameInMap("FileFingerPrint")]
        [Validation(Required=false)]
        public string FileFingerPrint { get; set; }

        /// <summary>
        /// <para>The name of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cat.png</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The type of the file. This corresponds to the main type of a Multipurpose Internet Mail Extensions (MIME) type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The time when the file was last modified. The time is in Coordinated Universal Time (UTC) and in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileUpdateTime")]
        [Validation(Required=false)]
        public string FileUpdateTime { get; set; }

        /// <summary>
        /// <para>Specific metadata for the file, such as the width and height of an image or the bitrate and resolution of a video. Currently, this metadata cannot be used for retrieval. The format is a JSON string.</para>
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
        /// <para>The ID of the job that last built the semantic index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsjob-klfwtjto****scvt3</para>
        /// </summary>
        [NameInMap("SemanticIndexJobId")]
        [Validation(Required=false)]
        public string SemanticIndexJobId { get; set; }

        /// <summary>
        /// <para>The time when the semantic index was last updated. The time is in UTC and in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("SemanticIndexUpdateTime")]
        [Validation(Required=false)]
        public string SemanticIndexUpdateTime { get; set; }

        /// <summary>
        /// <para>The current status of the metadata:
        /// \- ACTIVE: Active.
        /// \- DELETED: Deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A collection of tags for the metadata, in JSON string format. The collection includes the following groups:</para>
        /// <list type="bullet">
        /// <item><description><para>Algorithm tag group:</para>
        /// <list type="bullet">
        /// <item><description>ai: A list of tag names aggregated from all algorithm-based tagging tasks for a single metadata record.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>User-defined tag group:</para>
        /// <list type="bullet">
        /// <item><description><para>user: A list of tag names that a user adds to a single metadata record.</para>
        /// </description></item>
        /// <item><description><para>user-delete-ai-tags: A list of tag names from the algorithm tag group that the user deletes from a single metadata record.</para>
        /// </description></item>
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
        /// <para>The URL of the thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=171280****&OSSAccessKeyId=LTAI************&Signature=****jZcXOn7FHMCT1DLE22NuNjs%3D">https://test-bucket.oss-cn-shanghai.aliyuncs.com/dataset/cat.png?Expires=171280****&amp;OSSAccessKeyId=LTAI************&amp;Signature=****jZcXOn7FHMCT1DLE22NuNjs%3D</a></para>
        /// </summary>
        [NameInMap("ThumbnailUrl")]
        [Validation(Required=false)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// <para>The unique URI of the file. It records the unique path of the file. Paths for files in OSS and NAS are supported.</para>
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>OSS</para>
        /// </summary>
        /// 
        /// <para>oss\://${bucket}/${path}</para>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>NAS</para>
        /// </summary>
        /// 
        /// <para>nas\://${fileSystemId}/${path}</para>
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
