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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hat</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public DetectWorkwearResponseBodyDataElementsPropertyProbability Probability { get; set; }
                    public class DetectWorkwearResponseBodyDataElementsPropertyProbability : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.00036084422</para>
                        /// </summary>
                        [NameInMap("No")]
                        [Validation(Required=false)]
                        public double? No { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public long? Threshold { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.0006906331</para>
                        /// </summary>
                        [NameInMap("Unknown")]
                        [Validation(Required=false)]
                        public double? Unknown { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.9989485</para>
                        /// </summary>
                        [NameInMap("Yes")]
                        [Validation(Required=false)]
                        public double? Yes { get; set; }

                    }

                }

                [NameInMap("Rectangles")]
                [Validation(Required=false)]
                public DetectWorkwearResponseBodyDataElementsRectangles Rectangles { get; set; }
                public class DetectWorkwearResponseBodyDataElementsRectangles : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>96</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public long? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1067</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public long? Left { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>426</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public long? Top { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>88</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public long? Width { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.63913465</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16CA8094-D7BC-51D4-8D55-6AC59AB20E0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
