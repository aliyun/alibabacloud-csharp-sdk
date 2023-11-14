// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DeepfakeFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeepfakeFaceResponseBodyData Data { get; set; }
        public class DeepfakeFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DeepfakeFaceResponseBodyDataElements> Elements { get; set; }
            public class DeepfakeFaceResponseBodyDataElements : TeaModel {
                [NameInMap("FaceNumber")]
                [Validation(Required=false)]
                public long? FaceNumber { get; set; }

                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DeepfakeFaceResponseBodyDataElementsResults> Results { get; set; }
                public class DeepfakeFaceResponseBodyDataElementsResults : TeaModel {
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("MessageTips")]
                    [Validation(Required=false)]
                    public string MessageTips { get; set; }

                    [NameInMap("Rect")]
                    [Validation(Required=false)]
                    public DeepfakeFaceResponseBodyDataElementsResultsRect Rect { get; set; }
                    public class DeepfakeFaceResponseBodyDataElementsResultsRect : TeaModel {
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public long? Height { get; set; }

                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public long? Left { get; set; }

                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public long? Top { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public long? Width { get; set; }

                    }

                }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
