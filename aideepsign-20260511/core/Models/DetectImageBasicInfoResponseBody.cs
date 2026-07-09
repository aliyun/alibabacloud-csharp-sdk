// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class DetectImageBasicInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. &quot;OK&quot; is returned if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The image resolution (width × height), such as 1920 × 1080. This value is empty if the resolution cannot be identified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048 * 2048</para>
        /// </summary>
        [NameInMap("Dpi")]
        [Validation(Required=false)]
        public string Dpi { get; set; }

        /// <summary>
        /// <para>The HTTP status code. 200 is returned if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The additional information. &quot;success&quot; is returned if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>photo.jpg</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The file size in a human-readable format, such as 1.5 MB or 256 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.3 MB</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The image format, such as JPEG, PNG, GIF, or WEBP. UNKNOWN is returned if the format cannot be identified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PNG</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
