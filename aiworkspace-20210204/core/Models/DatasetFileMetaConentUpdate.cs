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
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The MIME type of the file. The value consists of a type and a subtype.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image/png</description></item>
        /// <item><description>image/svg+xml</description></item>
        /// <item><description>image/jpeg</description></item>
        /// <item><description>image/tiff</description></item>
        /// <item><description>image/gif</description></item>
        /// <item><description>image/bmp</description></item>
        /// <item><description>image/x-icon</description></item>
        /// <item><description>image/heic</description></item>
        /// <item><description>image/webp</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>image/jpeg</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07914c9534586e4e7aa6e9dbca5009082df******fd8a0d857b33296c59bf6</para>
        /// </summary>
        [NameInMap("DatasetFileMetaId")]
        [Validation(Required=false)]
        public string DatasetFileMetaId { get; set; }

        /// <summary>
        /// <para>The time when the file is created. The time follows the ISO 8601 standard.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The fingerprint information of the file.</para>
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
        /// <para>The file type, which is the same as Multipurpose Internet Mail Extensions (MIME) type.</para>
        /// <para>Valid values:</para>
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
        /// <para>The time when the file is last modified. The time follows the ISO 8601 standard.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileUpdateTime")]
        [Validation(Required=false)]
        public string FileUpdateTime { get; set; }

        /// <summary>
        /// <para>The specific metadata of the file, such as the width and height of an image and the bitrate and resolution of a video file. You cannot retrieve the metadata. The value is a JSON string.</para>
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
        /// <para>dsjob-klfwt*****l0escvt3</para>
        /// </summary>
        [NameInMap("SemanticIndexJobId")]
        [Validation(Required=false)]
        public string SemanticIndexJobId { get; set; }

        /// <summary>
        /// <para>The time when the semantic index is created.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("SemanticIndexUpdateTime")]
        [Validation(Required=false)]
        public string SemanticIndexUpdateTime { get; set; }

        /// <summary>
        /// <para>The tags to be updated.</para>
        /// <list type="bullet">
        /// <item><description>Update an algorithm tag group (a valid TagJobId must be set):</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///    &quot;ai&quot;:[&quot;Lane line&quot;, &quot;Water horse&quot;, &quot;Sunny day&quot;]
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description><para>Update a user-defined tag group (add or remove indicates that tags are added or deleted): Tag groups that can be updated:</para>
        /// <list type="bullet">
        /// <item><description>user: a list of user-defined tags that can be added to or deleted from a single piece of metadata.</description></item>
        /// <item><description>user-delete-ai-tags: a list of tags that you want to delete from an algorithm tag group.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///     &quot;user&quot;:{
        ///         &quot;add&quot;:[&quot;Lane line&quot;,&quot;Sunny day&quot;],
        ///         &quot;remove&quot;:[&quot;Water horse&quot;]    },
        ///     &quot;user-delete-ai-tags&quot;:{
        ///         &quot;add&quot;: [&quot;Ground shadow&quot;],
        ///         &quot;remove&quot;: []
        ///     }
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ai&quot;:[&quot;cat&quot;], &quot;user&quot;:[&quot;black&quot;]}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
