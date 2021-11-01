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
                public List<DetectWorkwearResponseBodyDataElementsProperty> Property { get; set; }
                public class DetectWorkwearResponseBodyDataElementsProperty : TeaModel {
                    public string Label { get; set; }
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
                public double? Score { get; set; }
                public string Type { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
