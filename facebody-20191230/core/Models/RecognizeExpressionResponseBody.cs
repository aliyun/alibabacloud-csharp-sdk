// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeExpressionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeExpressionResponseBodyData Data { get; set; }
        public class RecognizeExpressionResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeExpressionResponseBodyDataElements> Elements { get; set; }
            public class RecognizeExpressionResponseBodyDataElements : TeaModel {
                public RecognizeExpressionResponseBodyDataElementsFaceRectangle FaceRectangle { get; set; }
                public class RecognizeExpressionResponseBodyDataElementsFaceRectangle : TeaModel {
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public int? Top { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public int? Left { get; set; }

                }
                public string Expression { get; set; }
                public float? FaceProbability { get; set; }
            }
        };

    }

}
