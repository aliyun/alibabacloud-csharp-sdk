// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetFileMetaContentCreate : TeaModel {
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
        /// <para>This parameter is required.</para>
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
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The time when the file was created. The time is in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The fingerprint of the file. This value ensures the uniqueness of the file content and changes if the content is modified. For OSS files, this is the ETag. For NAS files, this is the MD5 value.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>00001.jpeg</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The type of the file. This is the same as the Multipurpose Internet Mail Extensions (MIME) type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The time when the file was last modified. The time is in ISO 8601 format.</para>
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
        /// <para>The specific metadata of the file. This metadata cannot be used for retrieval. The value must be a JSON string.</para>
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
        /// <para>The tags that are manually added by users. The \<c>add\\</c> operation is used to add tags to a tag group. The value must be a JSON string.
        /// The following tag group is available:</para>
        /// <list type="bullet">
        /// <item><description>user: A list of tag names added to a single piece of metadata.</description></item>
        /// </list>
        /// <pre><c>{
        ///     &quot;user&quot;:{
        ///         &quot;add&quot;:[&quot;Lane line&quot;,&quot;Sunny day&quot;]
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
        /// <para>The unique URI of the file. This URI records the unique path of the file. The path can be an OSS or NAS path.</para>
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
