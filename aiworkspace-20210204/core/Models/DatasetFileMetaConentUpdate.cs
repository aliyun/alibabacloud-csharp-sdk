// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetFileMetaConentUpdate : TeaModel {
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
        /// <para>The MIME type of the file. It includes a type and a subtype.</para>
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
        /// <para>The ID of the dataset file metadata.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07914c9534586e4e7aa6e9dbca5009082df******fd8a0d857b33296c59bf6</para>
        /// </summary>
        [NameInMap("DatasetFileMetaId")]
        [Validation(Required=false)]
        public string DatasetFileMetaId { get; set; }

        /// <summary>
        /// <para>The time when the file was created, in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.001Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The file fingerprint information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>124FB71******7BE45608CDEA4DE54B3</para>
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
        /// <para>The file type. This is the primary type from the Multipurpose Internet Mail Extensions (MIME) type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The time when the file was last modified, in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.001Z</para>
        /// </summary>
        [NameInMap("FileUpdateTime")]
        [Validation(Required=false)]
        public string FileUpdateTime { get; set; }

        /// <summary>
        /// <para>Specific file metadata, such as the width and height of an image, and the bitrate and resolution of a video. Retrieval based on this metadata is not yet supported. The value is a JSON string.</para>
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
        /// <para>The ID of the job that builds the semantic index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsjob-klfwt*****l0escvt3</para>
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

        /// <summary>
        /// <para>The tag groups to update.</para>
        /// <list type="bullet">
        /// <item><description>Update tags using an algorithm. Set a valid TagJobId.</description></item>
        /// </list>
        /// <pre><c>{
        ///    &quot;ai&quot;:[&quot;lane line&quot;, &quot;water barrier&quot;, &quot;sunny day&quot;]
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description><para>Manual tagging: Use add or remove to add or delete tags within a tag group. The modifiable tag groups are:</para>
        /// <list type="bullet">
        /// <item><description><para>user: A list of tag names to add to or delete from a single metadata entry.</para>
        /// </description></item>
        /// <item><description><para>user-delete-ai-tags: A list of tag names to delete from the algorithm-generated tag group for a single metadata entry.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <pre><c>{
        ///     &quot;user&quot;:{
        ///         &quot;add&quot;:[&quot;lane line&quot;,&quot;sunny day&quot;],
        ///         &quot;remove&quot;:[&quot;water barrier&quot;]
        ///     },
        ///     &quot;user-delete-ai-tags&quot;:{
        ///         &quot;add&quot;: [&quot;ground shade&quot;],
        ///         &quot;remove&quot;: []
        ///     }
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;user&quot;:{
        ///         &quot;add&quot;:[&quot;Lane line&quot;,&quot;Sunny day&quot;],
        ///         &quot;remove&quot;:[&quot;Water horse&quot;]
        ///     },
        ///     &quot;user-delete-ai-tags&quot;:{
        ///         &quot;add&quot;: [&quot;Ground shadow&quot;],
        ///         &quot;remove&quot;: []
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
