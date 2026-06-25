// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetFileMetaContentGet : TeaModel {
        /// <summary>
        /// <para>The comment on the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The first image file in the dataset.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The MIME type of the file. It includes a type and a subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/png</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The file size in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
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
        /// <para>The time when the file was created. The time is in the ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The path of the folder where the OSS, NAS, or CPFS file is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>icp_certificate_card/icp/1577179298694813/1716429710367</para>
        /// </summary>
        [NameInMap("FileDir")]
        [Validation(Required=false)]
        public string FileDir { get; set; }

        /// <summary>
        /// <para>The fingerprint of the file. This value ensures the uniqueness of the file content. The value changes if the file content is modified. For OSS files, the ETag is used. For NAS files, the MD5 hash is used.</para>
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
        /// <para>The file type. This is the same as the Multipurpose Internet Mail Extensions (MIME) type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The time when the file was last modified. The time is in the ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileUpdateTime")]
        [Validation(Required=false)]
        public string FileUpdateTime { get; set; }

        /// <summary>
        /// <para>The specific metadata of the file. This metadata cannot be used for retrieval. The format is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ImageHeight&quot;: 1080,
        ///     &quot;ImageWidth&quot;: 1920
        /// }</para>
        /// </summary>
        [NameInMap("MetaAttributes")]
        [Validation(Required=false)]
        public string MetaAttributes { get; set; }

        /// <summary>
        /// <para>The ID of the job that builds the semantic index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsjob-klfwtjtov*****scvt3</para>
        /// </summary>
        [NameInMap("SemanticIndexJobId")]
        [Validation(Required=false)]
        public string SemanticIndexJobId { get; set; }

        /// <summary>
        /// <para>The time when the semantic index was built.</para>
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
        /// <para>The time when the tag was last modified. The time is in the ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("TagUpdateTime")]
        [Validation(Required=false)]
        public string TagUpdateTime { get; set; }

        /// <summary>
        /// <para>A collection of tags for the metadata. It includes the following groups:</para>
        /// <list type="bullet">
        /// <item><description><para>Algorithm tag group:</para>
        /// <list type="bullet">
        /// <item><description>ai: A list of tag names aggregated from all algorithmic tagging tasks for a single metadata record.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>User-defined tag group:</para>
        /// <list type="bullet">
        /// <item><description><para>user: A list of tag names that a user adds to a single metadata record.</para>
        /// </description></item>
        /// <item><description><para>user-delete-ai-tags: A list of tag names from the algorithm tag group that the user wants to delete from a single metadata record.</para>
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
        /// <para>The unique URI of the file. This URI records the unique path of the file. Paths for files in OSS and NAS are supported.</para>
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
        /// <para>oss://*****-test/dataset/1653421.jpg
        /// nas://0e25d***dff/dataset/1653421.jpg</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
