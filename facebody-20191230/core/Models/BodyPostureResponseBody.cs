// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BodyPostureResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BodyPostureResponseBodyData Data { get; set; }
        public class BodyPostureResponseBodyData : TeaModel {
            [NameInMap("MetaObject")]
            [Validation(Required=false)]
            public BodyPostureResponseBodyDataMetaObject MetaObject { get; set; }
            public class BodyPostureResponseBodyDataMetaObject : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<BodyPostureResponseBodyDataOutputs> Outputs { get; set; }
            public class BodyPostureResponseBodyDataOutputs : TeaModel {
                [NameInMap("HumanCount")]
                [Validation(Required=false)]
                public int? HumanCount { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<BodyPostureResponseBodyDataOutputsResults> Results { get; set; }
                public class BodyPostureResponseBodyDataOutputsResults : TeaModel {
                    [NameInMap("Bodies")]
                    [Validation(Required=false)]
                    public List<BodyPostureResponseBodyDataOutputsResultsBodies> Bodies { get; set; }
                    public class BodyPostureResponseBodyDataOutputsResultsBodies : TeaModel {
                        [NameInMap("Confident")]
                        [Validation(Required=false)]
                        public float? Confident { get; set; }

                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("Positions")]
                        [Validation(Required=false)]
                        public List<BodyPostureResponseBodyDataOutputsResultsBodiesPositions> Positions { get; set; }
                        public class BodyPostureResponseBodyDataOutputsResultsBodiesPositions : TeaModel {
                            [NameInMap("Points")]
                            [Validation(Required=false)]
                            public List<float?> Points { get; set; }

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
