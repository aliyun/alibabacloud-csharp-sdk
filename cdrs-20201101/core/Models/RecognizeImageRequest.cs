// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class RecognizeImageRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("ImageContent")]
        [Validation(Required=false)]
        public string ImageContent { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("RecognizeType")]
        [Validation(Required=false)]
        public string RecognizeType { get; set; }

        [NameInMap("RequireCropImage")]
        [Validation(Required=false)]
        public bool? RequireCropImage { get; set; }

        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
