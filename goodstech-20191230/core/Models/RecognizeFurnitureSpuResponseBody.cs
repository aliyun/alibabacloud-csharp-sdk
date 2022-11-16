// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Goodstech20191230.Models
{
    public class RecognizeFurnitureSpuResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeFurnitureSpuResponseBodyData Data { get; set; }
        public class RecognizeFurnitureSpuResponseBodyData : TeaModel {
            [NameInMap("PredCate")]
            [Validation(Required=false)]
            public string PredCate { get; set; }

            [NameInMap("PredCateId")]
            [Validation(Required=false)]
            public string PredCateId { get; set; }

            [NameInMap("PredProbability")]
            [Validation(Required=false)]
            public float? PredProbability { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
