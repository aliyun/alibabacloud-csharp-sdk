// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectWorkwearResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectWorkwearResponseBodyData Data { get; set; }
        public class DetectWorkwearResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectWorkwearResponseBodyDataElements> Elements { get; set; }
            public class DetectWorkwearResponseBodyDataElements : TeaModel {
                [NameInMap("Property")]
                [Validation(Required=false)]
                public List<DetectWorkwearResponseBodyDataElementsProperty> Property { get; set; }
                public class DetectWorkwearResponseBodyDataElementsProperty : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public DetectWorkwearResponseBodyDataElementsPropertyProbability Probability { get; set; }
                    public class DetectWorkwearResponseBodyDataElementsPropertyProbability : TeaModel {
                        [NameInMap("No")]
                        [Validation(Required=false)]
                        public double? No { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public long? Threshold { get; set; }

                        [NameInMap("Unknown")]
                        [Validation(Required=false)]
                        public double? Unknown { get; set; }

                        [NameInMap("Yes")]
                        [Validation(Required=false)]
                        public double? Yes { get; set; }

                    }

                }

                [NameInMap("Rectangles")]
                [Validation(Required=false)]
                public DetectWorkwearResponseBodyDataElementsRectangles Rectangles { get; set; }
                public class DetectWorkwearResponseBodyDataElementsRectangles : TeaModel {
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

                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
