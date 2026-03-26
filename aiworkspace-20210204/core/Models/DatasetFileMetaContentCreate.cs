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
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The MIME type of the file. It contains Type and SubType.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image/png: PNG.</description></item>
        /// <item><description>image/jpeg: JPEG.</description></item>
        /// <item><description>image/tiff: TIFF.</description></item>
        /// <item><description>image/bmp: BMP.</description></item>
        /// <item><description>image/gif: GIF.</description></item>
        /// <item><description>image/x-icon: ICON.</description></item>
        /// <item><description>image/svg+xml: SVG.</description></item>
        /// <item><description>image/webp: WEBP.</description></item>
        /// <item><description>image/heic: HEIC</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>10000</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The time when the file was created. The time follows the ISO 8601 standard.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("FileCreateTime")]
        [Validation(Required=false)]
        public string FileCreateTime { get; set; }

        /// <summary>
        /// <para>The file fingerprint. Used to check the uniqueness of the file. This value changes after the file content is modified. OSS files use ETags, and NAS files use MD5 values.</para>
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
        /// <para>The file type. The same as MIME type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image</description></item>
        /// <item><description>application</description></item>
        /// <item><description>audio</description></item>
        /// <item><description>video</description></item>
        /// <item><description>text</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The time when the file was last modified. The time follows the ISO 8601 standard.</para>
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
        /// <para>The specific metadata of the file. You cannot retrieve the metadata. The value is a JSON string.</para>
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
        /// <para>The tags manually added. The value is a JSON string. Operable tag group:</para>
        /// <list type="bullet">
        /// <item><description>user: the list of tags to add to a metadata entry.</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///     &quot;user&quot;:{
        ///         &quot;add&quot;:[&quot;lane line&quot;,&quot;sunny&quot;]
        ///     }
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;user&quot;:[&quot;cat&quot;, &quot;White&quot;]}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The URI of the file. Used to record the unique path of the file. File paths in Object Storage Service (OSS) and File Storage NAS (NAS) are supported.</para>
        /// <para><b>OSS</b></para>
        /// <para>oss://${bucket}/${path}</para>
        /// <para><b>NAS</b></para>
        /// <para>nas://${fileSystemId}/${path}</para>
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
