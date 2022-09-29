// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class HandPostureResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public HandPostureResponseBodyData Data { get; set; }
        public class HandPostureResponseBodyData : TeaModel {
            [NameInMap("MetaObject")]
            [Validation(Required=false)]
            public HandPostureResponseBodyDataMetaObject MetaObject { get; set; }
            public class HandPostureResponseBodyDataMetaObject : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<HandPostureResponseBodyDataOutputs> Outputs { get; set; }
            public class HandPostureResponseBodyDataOutputs : TeaModel {
                [NameInMap("HandCount")]
                [Validation(Required=false)]
                public int? HandCount { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<HandPostureResponseBodyDataOutputsResults> Results { get; set; }
                public class HandPostureResponseBodyDataOutputsResults : TeaModel {
                    [NameInMap("Box")]
                    [Validation(Required=false)]
                    public HandPostureResponseBodyDataOutputsResultsBox Box { get; set; }
                    public class HandPostureResponseBodyDataOutputsResultsBox : TeaModel {
                        [NameInMap("Confident")]
                        [Validation(Required=false)]
                        public float? Confident { get; set; }

                        [NameInMap("Positions")]
                        [Validation(Required=false)]
                        public List<HandPostureResponseBodyDataOutputsResultsBoxPositions> Positions { get; set; }
                        public class HandPostureResponseBodyDataOutputsResultsBoxPositions : TeaModel {
                            [NameInMap("Points")]
                            [Validation(Required=false)]
                            public List<float?> Points { get; set; }

                        }

                    }

                    [NameInMap("Hands")]
                    [Validation(Required=false)]
                    public HandPostureResponseBodyDataOutputsResultsHands Hands { get; set; }
                    public class HandPostureResponseBodyDataOutputsResultsHands : TeaModel {
                        [NameInMap("Confident")]
                        [Validation(Required=false)]
                        public float? Confident { get; set; }

                        [NameInMap("KeyPoints")]
                        [Validation(Required=false)]
                        public List<HandPostureResponseBodyDataOutputsResultsHandsKeyPoints> KeyPoints { get; set; }
                        public class HandPostureResponseBodyDataOutputsResultsHandsKeyPoints : TeaModel {
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            [NameInMap("Positions")]
                            [Validation(Required=false)]
                            public List<HandPostureResponseBodyDataOutputsResultsHandsKeyPointsPositions> Positions { get; set; }
                            public class HandPostureResponseBodyDataOutputsResultsHandsKeyPointsPositions : TeaModel {
                                [NameInMap("Points")]
                                [Validation(Required=false)]
                                public List<float?> Points { get; set; }

                            }

                        }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
