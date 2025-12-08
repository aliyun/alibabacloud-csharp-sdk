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
                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<BodyPostureResponseBodyDataOutputs> Outputs { get; set; }
            public class BodyPostureResponseBodyDataOutputs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.91309475898742676</para>
                        /// </summary>
                        [NameInMap("Confident")]
                        [Validation(Required=false)]
                        public float? Confident { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>nose</para>
                        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>B854094B-9231-4A54-89AB-C377CB0D237D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
