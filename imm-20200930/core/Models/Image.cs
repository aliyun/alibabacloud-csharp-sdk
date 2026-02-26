// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Image : TeaModel {
        /// <summary>
        /// <para>The image cropping suggestions. This parameter is reserved and not available.</para>
        /// </summary>
        [NameInMap("CroppingSuggestions")]
        [Validation(Required=false)]
        public List<CroppingSuggestion> CroppingSuggestions { get; set; }

        /// <summary>
        /// <para>The original EXIF information about the image. The EXIF information is stored in the serialized JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/44975.html">Query image information</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FileSize&quot;:{&quot;value&quot;:&quot;29304&quot;},&quot;Format&quot;:{&quot;value&quot;:&quot;jpg&quot;}}</para>
        /// </summary>
        [NameInMap("EXIF")]
        [Validation(Required=false)]
        public string EXIF { get; set; }

        /// <summary>
        /// <para>The height of the image. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>820</para>
        /// </summary>
        [NameInMap("ImageHeight")]
        [Validation(Required=false)]
        public long? ImageHeight { get; set; }

        /// <summary>
        /// <para>The image scoring information.</para>
        /// </summary>
        [NameInMap("ImageScore")]
        [Validation(Required=false)]
        public ImageScore ImageScore { get; set; }

        /// <summary>
        /// <para>The width of the image. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("ImageWidth")]
        [Validation(Required=false)]
        public long? ImageWidth { get; set; }

        /// <summary>
        /// <para>The results of optical character recognition (OCR). This parameter is reserved and not available.</para>
        /// </summary>
        [NameInMap("OCRContents")]
        [Validation(Required=false)]
        public List<OCRContents> OCRContents { get; set; }

    }

}
