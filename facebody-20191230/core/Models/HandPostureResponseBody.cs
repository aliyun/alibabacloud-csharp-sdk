// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class HandPostureResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public HandPostureResponseBodyData Data { get; set; }
        public class HandPostureResponseBodyData : TeaModel {
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<HandPostureResponseBodyDataOutputs> Outputs { get; set; }
            public class HandPostureResponseBodyDataOutputs : TeaModel {
                public int? HandCount { get; set; }
                public List<HandPostureResponseBodyDataOutputsResults> Results { get; set; }
                public class HandPostureResponseBodyDataOutputsResults : TeaModel {
                    [NameInMap("KeyPoints")]
                    [Validation(Required=false)]
                    public List<HandPostureResponseBodyDataOutputsResultsKeyPoints> KeyPoints { get; set; }
                    public class HandPostureResponseBodyDataOutputsResultsKeyPoints : TeaModel {
                        [NameInMap("Positions")]
                        [Validation(Required=false)]
                        public List<HandPostureResponseBodyDataOutputsResultsKeyPointsPositions> Positions { get; set; }
                        public class HandPostureResponseBodyDataOutputsResultsKeyPointsPositions : TeaModel {
                            [NameInMap("Points")]
                            [Validation(Required=false)]
                            public List<float?> Points { get; set; }

                        }

                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    [NameInMap("Confident")]
                    [Validation(Required=false)]
                    public float? Confident { get; set; }

                }
            }
            [NameInMap("MetaObject")]
            [Validation(Required=false)]
            public HandPostureResponseBodyDataMetaObject MetaObject { get; set; }
            public class HandPostureResponseBodyDataMetaObject : TeaModel {
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

            }
        };

    }

}
