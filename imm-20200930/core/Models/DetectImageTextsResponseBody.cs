// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageTextsResponseBody : TeaModel {
        /// <summary>
        /// <para>OCR text blocks.</para>
        /// </summary>
        [NameInMap("OCRContents")]
        [Validation(Required=false)]
        public List<OCRContents> OCRContents { get; set; }

        /// <summary>
        /// <para>The full Optical Character Recognition (OCR) text, which is spliced by using the content of OCRContents.</para>
        /// </summary>
        [NameInMap("OCRTexts")]
        [Validation(Required=false)]
        public string OCRTexts { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B3D5E0A-D8B8-4DA0-8127-ED32C851****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
