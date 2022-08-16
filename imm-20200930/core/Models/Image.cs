// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Image : TeaModel {
        [NameInMap("CroppingSuggestions")]
        [Validation(Required=false)]
        public List<CroppingSuggestion> CroppingSuggestions { get; set; }

        [NameInMap("EXIF")]
        [Validation(Required=false)]
        public string EXIF { get; set; }

        [NameInMap("ImageHeight")]
        [Validation(Required=false)]
        public long? ImageHeight { get; set; }

        [NameInMap("ImageScore")]
        [Validation(Required=false)]
        public ImageScore ImageScore { get; set; }

        [NameInMap("ImageWidth")]
        [Validation(Required=false)]
        public long? ImageWidth { get; set; }

        [NameInMap("OCRContents")]
        [Validation(Required=false)]
        public List<OCRContents> OCRContents { get; set; }

    }

}
