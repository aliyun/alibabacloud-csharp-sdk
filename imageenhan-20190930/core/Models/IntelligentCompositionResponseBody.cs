// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class IntelligentCompositionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public IntelligentCompositionResponseBodyData Data { get; set; }
        public class IntelligentCompositionResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<IntelligentCompositionResponseBodyDataElements> Elements { get; set; }
            public class IntelligentCompositionResponseBodyDataElements : TeaModel {
                [NameInMap("MaxX")]
                [Validation(Required=false)]
                public int? MaxX { get; set; }

                [NameInMap("MaxY")]
                [Validation(Required=false)]
                public int? MaxY { get; set; }

                [NameInMap("MinX")]
                [Validation(Required=false)]
                public int? MinX { get; set; }

                [NameInMap("MinY")]
                [Validation(Required=false)]
                public int? MinY { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
