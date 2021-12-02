// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectChefCapResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectChefCapResponseBodyData Data { get; set; }
        public class DetectChefCapResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectChefCapResponseBodyDataElements> Elements { get; set; }
            public class DetectChefCapResponseBodyDataElements : TeaModel {
                public List<string> Box { get; set; }
                public string Category { get; set; }
                public float? Confidence { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
