// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Goodstech20191230.Models
{
    public class RecognizeFurnitureAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeFurnitureAttributeResponseBodyData Data { get; set; }
        public class RecognizeFurnitureAttributeResponseBodyData : TeaModel {
            [NameInMap("PredStyle")]
            [Validation(Required=false)]
            public string PredStyle { get; set; }
            [NameInMap("PredProbability")]
            [Validation(Required=false)]
            public float? PredProbability { get; set; }
            [NameInMap("PredStyleId")]
            [Validation(Required=false)]
            public string PredStyleId { get; set; }
        };

    }

}
