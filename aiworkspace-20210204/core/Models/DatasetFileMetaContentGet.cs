// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetFileMetaContentGet : TeaModel {
        /// <summary>
        /// <para>The file comment.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The MIME type of the file. It contains a Type and a SubType.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>image/png: PNG</description></item>
        /// <item><description>image/jpeg: JPEG</description></item>
        /// <item><description>image/tiff: TIFF</description></item>
        /// <item><description>image/bmp: BMP</description></item>
        /// <item><description>image/gif: GIF</description></item>
        /// <item><description>image/x-icon: ICON</description></item>
        /// <item><description>image/svg + xml: SVG</description></item>
        /// <item><description>image/heic: HEIC</description></item>
        /// <item><description>image/webp: WEBP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text/png</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The file size. Unit: byte.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
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
        /// <para>The time when the file was created. Format: ISO8601.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The directory of the file that is stored in OSS, NAS, or Cloud Parallel File Storage (CPFS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>icp_certificate_card/icp/1577179298694813/1716429710367</para>
        /// </summary>
        [NameInMap("FileDir")]
        [Validation(Required=false)]
        public string FileDir { get; set; }

        /// <summary>
        /// <para>The fingerprint value of the file. Used to check the uniqueness of the file. This value changes after the file content is modified. OSS files use ETags, and NAS files use MD5.</para>
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
        /// <para>00001.jpeg</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The file type. The same as MIME type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>image</description></item>
        /// <item><description>application</description></item>
        /// <item><description>audio</description></item>
        /// <item><description>video</description></item>
        /// <item><description>text</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The time when the file was last modified. Format: ISO8601.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileUpdateTime")]
        [Validation(Required=false)]
        public string FileUpdateTime { get; set; }

        /// <summary>
        /// <para>The specific metadata of the file. You cannot retrieve the metadata. In JSON String format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;Image&quot;:
        ///     {
        ///         &quot;Width&quot;: 1920,
        ///         &quot;Height&quot;: 1080,
        ///         &quot;Channel&quot;: 3
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("MetaAttributes")]
        [Validation(Required=false)]
        public string MetaAttributes { get; set; }

        /// <summary>
        /// <para>The ID of the semantic index-based job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsjob-klfwtjtov*****scvt3</para>
        /// </summary>
        [NameInMap("SemanticIndexJobId")]
        [Validation(Required=false)]
        public string SemanticIndexJobId { get; set; }

        /// <summary>
        /// <para>The time when the semantic index-based job is created.</para>
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
        /// <para>The time when the tag is last modified. The time follows the ISO 8601 standard.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("TagUpdateTime")]
        [Validation(Required=false)]
        public string TagUpdateTime { get; set; }

        /// <summary>
        /// <para>The tags for the metadata. The tags are divided into the following groups:</para>
        /// <list type="bullet">
        /// <item><description><para>Algorithm tag group:</para>
        /// <list type="bullet">
        /// <item><description>ai: a list of tags that are aggregated by all algorithm tagging tasks for a single piece of metadata.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>User-defined tag groups:</para>
        /// <list type="bullet">
        /// <item><description>user: a list of user-defined tags that are added to a single piece of metadata.</description></item>
        /// <item><description>user-delete-ai-tags: a list of tags that you want to delete from an algorithm tag group.</description></item>
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
        /// <para>The unique URI of the file. Used to record the unique path of the file. File paths in OSS and NAS are supported.</para>
        /// <para><b>OSS</b></para>
        /// <para>oss://${bucket}/${path}</para>
        /// <para><b>NAS</b></para>
        /// <para>nas://${fileSystemId}/${path}</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://*****-test/dataset/1653421.jpg
        /// nas://0e25d***dff/dataset/1653421.jpg</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
