// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CompareFaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompareFaceResponseBodyData Data { get; set; }
        public class CompareFaceResponseBodyData : TeaModel {
            [NameInMap("Thresholds")]
            [Validation(Required=false)]
            public List<string> Thresholds { get; set; }
            [NameInMap("RectBList")]
            [Validation(Required=false)]
            public List<string> RectBList { get; set; }
            [NameInMap("Confidence")]
            [Validation(Required=false)]
            public float? Confidence { get; set; }
            [NameInMap("RectAList")]
            [Validation(Required=false)]
            public List<string> RectAList { get; set; }
            [NameInMap("QualityScoreA")]
            [Validation(Required=false)]
            public float? QualityScoreA { get; set; }
            [NameInMap("QualityScoreB")]
            [Validation(Required=false)]
            public float? QualityScoreB { get; set; }
            [NameInMap("MessageTips")]
            [Validation(Required=false)]
            public string MessageTips { get; set; }
        };

    }

}
