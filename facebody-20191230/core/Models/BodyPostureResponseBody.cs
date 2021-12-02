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
                public int? HumanCount { get; set; }
                public List<BodyPostureResponseBodyDataOutputsResults> Results { get; set; }
                public class BodyPostureResponseBodyDataOutputsResults : TeaModel {
                    public List<BodyPostureResponseBodyDataOutputsResultsBodies> Bodies { get; set; }
                    public class BodyPostureResponseBodyDataOutputsResultsBodies : TeaModel {
                        public float? Confident { get; set; }
                        public string Label { get; set; }
                        public List<BodyPostureResponseBodyDataOutputsResultsBodiesPositions> Positions { get; set; }
                        public class BodyPostureResponseBodyDataOutputsResultsBodiesPositions : TeaModel {
                            public List<string> Points { get; set; }
                        }
                    }
                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
