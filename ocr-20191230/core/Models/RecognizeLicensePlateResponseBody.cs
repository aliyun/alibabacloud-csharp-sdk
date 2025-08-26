// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeLicensePlateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeLicensePlateResponseBodyData Data { get; set; }
        public class RecognizeLicensePlateResponseBodyData : TeaModel {
            [NameInMap("Plates")]
            [Validation(Required=false)]
            public List<RecognizeLicensePlateResponseBodyDataPlates> Plates { get; set; }
            public class RecognizeLicensePlateResponseBodyDataPlates : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.99745339155197144</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("PlateNumber")]
                [Validation(Required=false)]
                public string PlateNumber { get; set; }

                [NameInMap("PlateType")]
                [Validation(Required=false)]
                public string PlateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PlateTypeConfidence")]
                [Validation(Required=false)]
                public float? PlateTypeConfidence { get; set; }

                [NameInMap("Positions")]
                [Validation(Required=false)]
                public List<RecognizeLicensePlateResponseBodyDataPlatesPositions> Positions { get; set; }
                public class RecognizeLicensePlateResponseBodyDataPlatesPositions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>466</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>293</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

                [NameInMap("Roi")]
                [Validation(Required=false)]
                public RecognizeLicensePlateResponseBodyDataPlatesRoi Roi { get; set; }
                public class RecognizeLicensePlateResponseBodyDataPlatesRoi : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>53</para>
                    /// </summary>
                    [NameInMap("H")]
                    [Validation(Required=false)]
                    public int? H { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>141</para>
                    /// </summary>
                    [NameInMap("W")]
                    [Validation(Required=false)]
                    public int? W { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>294</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>256</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3F10DAC3-CF4A-487C-BF33-3B8EB9AA12F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
