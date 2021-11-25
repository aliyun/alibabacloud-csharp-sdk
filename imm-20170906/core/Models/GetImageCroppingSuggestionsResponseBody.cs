// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetImageCroppingSuggestionsResponseBody : TeaModel {
        [NameInMap("CroppingSuggestions")]
        [Validation(Required=false)]
        public List<GetImageCroppingSuggestionsResponseBodyCroppingSuggestions> CroppingSuggestions { get; set; }
        public class GetImageCroppingSuggestionsResponseBodyCroppingSuggestions : TeaModel {
            [NameInMap("AspectRatio")]
            [Validation(Required=false)]
            public string AspectRatio { get; set; }

            [NameInMap("CroppingBoundary")]
            [Validation(Required=false)]
            public GetImageCroppingSuggestionsResponseBodyCroppingSuggestionsCroppingBoundary CroppingBoundary { get; set; }
            public class GetImageCroppingSuggestionsResponseBodyCroppingSuggestionsCroppingBoundary : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }
                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }
            };

            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

        }

        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
