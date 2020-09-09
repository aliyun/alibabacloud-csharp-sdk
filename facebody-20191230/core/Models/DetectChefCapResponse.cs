// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectChefCapResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public DetectChefCapResponseData Data { get; set; }
        public class DetectChefCapResponseData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=true)]
            public List<DetectChefCapResponseDataElements> Elements { get; set; }
            public class DetectChefCapResponseDataElements : TeaModel {
                public string Category { get; set; }
                public float? Confidence { get; set; }
                public List<string> Box { get; set; }
            }
        };

    }

}
