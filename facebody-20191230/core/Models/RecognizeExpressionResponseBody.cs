// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeExpressionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeExpressionResponseBodyData Data { get; set; }
        public class RecognizeExpressionResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeExpressionResponseBodyDataElements> Elements { get; set; }
            public class RecognizeExpressionResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>surprise</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.99651491641998291</para>
                /// </summary>
                [NameInMap("FaceProbability")]
                [Validation(Required=false)]
                public float? FaceProbability { get; set; }

                [NameInMap("FaceRectangle")]
                [Validation(Required=false)]
                public RecognizeExpressionResponseBodyDataElementsFaceRectangle FaceRectangle { get; set; }
                public class RecognizeExpressionResponseBodyDataElementsFaceRectangle : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>174</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>196</para>
                    /// </summary>
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public int? Left { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>41</para>
                    /// </summary>
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public int? Top { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>121</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E1C4C576-1799-4079-A934-15BC406A54EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
