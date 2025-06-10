// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenLCResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenLCResponseBodyData Data { get; set; }
        public class ScreenLCResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public ScreenLCResponseBodyDataLesion Lesion { get; set; }
            public class ScreenLCResponseBodyDataLesion : TeaModel {
                [NameInMap("LesionList")]
                [Validation(Required=false)]
                public List<ScreenLCResponseBodyDataLesionLesionList> LesionList { get; set; }
                public class ScreenLCResponseBodyDataLesionLesionList : TeaModel {
                    [NameInMap("Diameter")]
                    [Validation(Required=false)]
                    public List<float?> Diameter { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("KeySlice")]
                    [Validation(Required=false)]
                    public long? KeySlice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.9375</para>
                    /// </summary>
                    [NameInMap("Malignancy")]
                    [Validation(Required=false)]
                    public float? Malignancy { get; set; }

                    [NameInMap("RecistEndpoints")]
                    [Validation(Required=false)]
                    public List<float?> RecistEndpoints { get; set; }

                    [NameInMap("ScoreAllClassesProb")]
                    [Validation(Required=false)]
                    public ScreenLCResponseBodyDataLesionLesionListScoreAllClassesProb ScoreAllClassesProb { get; set; }
                    public class ScreenLCResponseBodyDataLesionLesionListScoreAllClassesProb : TeaModel {
                        [NameInMap("BenignProb")]
                        [Validation(Required=false)]
                        public float? BenignProb { get; set; }

                        [NameInMap("CalcProb")]
                        [Validation(Required=false)]
                        public float? CalcProb { get; set; }

                        [NameInMap("CystProb")]
                        [Validation(Required=false)]
                        public float? CystProb { get; set; }

                        [NameInMap("MalignantProb")]
                        [Validation(Required=false)]
                        public float? MalignantProb { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HCC</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>305.3661</para>
                    /// </summary>
                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public float? Volume { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1364.9468</para>
                /// </summary>
                [NameInMap("LiverVolume")]
                [Validation(Required=false)]
                public float? LiverVolume { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20-050_0000.nii.gz</para>
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("PatientLevelProb")]
                [Validation(Required=false)]
                public float? PatientLevelProb { get; set; }

                [NameInMap("PatientLevelResult")]
                [Validation(Required=false)]
                public ScreenLCResponseBodyDataLesionPatientLevelResult PatientLevelResult { get; set; }
                public class ScreenLCResponseBodyDataLesionPatientLevelResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0077</para>
                    /// </summary>
                    [NameInMap("BenignNonCystProb")]
                    [Validation(Required=false)]
                    public string BenignNonCystProb { get; set; }

                    [NameInMap("BenignProb")]
                    [Validation(Required=false)]
                    public float? BenignProb { get; set; }

                    [NameInMap("CalcProb")]
                    [Validation(Required=false)]
                    public float? CalcProb { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.9233</para>
                    /// </summary>
                    [NameInMap("CystProb")]
                    [Validation(Required=false)]
                    public float? CystProb { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.9941</para>
                    /// </summary>
                    [NameInMap("HCCProb")]
                    [Validation(Required=false)]
                    public float? HCCProb { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0073</para>
                    /// </summary>
                    [NameInMap("MalignantNonHCCProb")]
                    [Validation(Required=false)]
                    public float? MalignantNonHCCProb { get; set; }

                    [NameInMap("MalignantProb")]
                    [Validation(Required=false)]
                    public float? MalignantProb { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473dbfb0-9cb7-e18e-450b-e4d0e4ce6c1c</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
