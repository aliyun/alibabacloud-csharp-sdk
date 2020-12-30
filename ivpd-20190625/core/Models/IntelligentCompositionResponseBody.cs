// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class IntelligentCompositionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public IntelligentCompositionResponseBodyData Data { get; set; }
        public class IntelligentCompositionResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<IntelligentCompositionResponseBodyDataElements> Elements { get; set; }
            public class IntelligentCompositionResponseBodyDataElements : TeaModel {
                public int? MinX { get; set; }
                public float? Score { get; set; }
                public int? MaxY { get; set; }
                public int? MaxX { get; set; }
                public int? MinY { get; set; }
            }
        };

    }

}
