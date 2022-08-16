// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageScoreResponseBody : TeaModel {
        [NameInMap("ImageScore")]
        [Validation(Required=false)]
        public DetectImageScoreResponseBodyImageScore ImageScore { get; set; }
        public class DetectImageScoreResponseBodyImageScore : TeaModel {
            [NameInMap("OverallQualityScore")]
            [Validation(Required=false)]
            public float? OverallQualityScore { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
