// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetFileMetaContentCreate : TeaModel {
        /// <summary>
        /// <para>The file comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The first image file in the dataset.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The MIME type of the file. Contains Type and SubType.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/jpeg</para>
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
        /// <para>The file creation time in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The file fingerprint value. Used to determine the uniqueness of file content. This value changes when the file content is modified. OSS files use ETag, and NAS files use MD5 values.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The file type. Same as MIME Type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The last modification time of the file in ISO 8601 format.</para>
        /// <para>This parameter is required.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileUpdateTime")]
        [Validation(Required=false)]
        public string FileUpdateTime { get; set; }

        /// <summary>
        /// <para>The specific metadata of the file, not searchable. In JSON string format.</para>
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
        /// <para>User manual tagging: (add indicates adding tags to the tag group). In JSON string format.
        /// The operable tag groups are:</para>
        /// <list type="bullet">
        /// <item><description>user: The list of tag names manually added by the user for a single metadata entry.</description></item>
        /// </list>
        /// <pre><c>{
        ///     &quot;user&quot;:{
        ///         &quot;add&quot;:[&quot;lane_line&quot;,&quot;sunny&quot;]
        ///     }
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;user&quot;:{
        ///         &quot;add&quot;:[&quot;Lane line&quot;,&quot;Sunny day&quot;]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The unique URI of the file. Used to record the unique file path. Supports file paths in OSS and NAS.</para>
        /// <details>
        /// <summary>OSS</summary>
        /// oss://${bucket}/${path}
        /// </details>
        /// <details>
        /// <summary>NAS</summary>
        /// nas://${fileSystemId}/${path}
        /// </details>
        /// 
        /// <para>This parameter is required.</para>
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
