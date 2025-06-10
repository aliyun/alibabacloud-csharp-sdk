// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectLiverSteatosisResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectLiverSteatosisResponseBodyData Data { get; set; }
        public class DetectLiverSteatosisResponseBodyData : TeaModel {
            [NameInMap("Detections")]
            [Validation(Required=false)]
            public List<DetectLiverSteatosisResponseBodyDataDetections> Detections { get; set; }
            public class DetectLiverSteatosisResponseBodyDataDetections : TeaModel {
                [NameInMap("FatFract")]
                [Validation(Required=false)]
                public double? FatFract { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>62.07644147383561</para>
                /// </summary>
                [NameInMap("LiverHU")]
                [Validation(Required=false)]
                public float? LiverHU { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>63.50222396850586</para>
                /// </summary>
                [NameInMap("LiverROI1")]
                [Validation(Required=false)]
                public float? LiverROI1 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>62.23713684082031</para>
                /// </summary>
                [NameInMap("LiverROI2")]
                [Validation(Required=false)]
                public float? LiverROI2 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>59.78181838989258</para>
                /// </summary>
                [NameInMap("LiverROI3")]
                [Validation(Required=false)]
                public float? LiverROI3 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12.0</para>
                /// </summary>
                [NameInMap("LiverSlice")]
                [Validation(Required=false)]
                public float? LiverSlice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8.206502275265478</para>
                /// </summary>
                [NameInMap("LiverSpleenDifference")]
                [Validation(Required=false)]
                public float? LiverSpleenDifference { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.15233917834983</para>
                /// </summary>
                [NameInMap("LiverSpleenRatio")]
                [Validation(Required=false)]
                public float? LiverSpleenRatio { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1059.4175610625439</para>
                /// </summary>
                [NameInMap("LiverVolume")]
                [Validation(Required=false)]
                public float? LiverVolume { get; set; }

                [NameInMap("MaossScore")]
                [Validation(Required=false)]
                public double? MaossScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Mod</para>
                /// </summary>
                [NameInMap("Prediction")]
                [Validation(Required=false)]
                public string Prediction { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.9457855224609375</para>
                /// </summary>
                [NameInMap("Probability")]
                [Validation(Required=false)]
                public float? Probability { get; set; }

                [NameInMap("ROI1Center")]
                [Validation(Required=false)]
                public List<long?> ROI1Center { get; set; }

                [NameInMap("ROI2Center")]
                [Validation(Required=false)]
                public List<long?> ROI2Center { get; set; }

                [NameInMap("ROI3Center")]
                [Validation(Required=false)]
                public List<long?> ROI3Center { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Radius")]
                [Validation(Required=false)]
                public long? Radius { get; set; }

                [NameInMap("SpleenCenter")]
                [Validation(Required=false)]
                public List<long?> SpleenCenter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>53.86993919857013</para>
                /// </summary>
                [NameInMap("SpleenHU")]
                [Validation(Required=false)]
                public float? SpleenHU { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50.553409576416016</para>
                /// </summary>
                [NameInMap("SpleenROI")]
                [Validation(Required=false)]
                public float? SpleenROI { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9.0</para>
                /// </summary>
                [NameInMap("SpleenSlice")]
                [Validation(Required=false)]
                public float? SpleenSlice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>156.01873229470647</para>
                /// </summary>
                [NameInMap("SpleenVolume")]
                [Validation(Required=false)]
                public float? SpleenVolume { get; set; }

            }

            [NameInMap("Origin")]
            [Validation(Required=false)]
            public List<float?> Origin { get; set; }

            [NameInMap("ResultUrl")]
            [Validation(Required=false)]
            public string ResultUrl { get; set; }

            [NameInMap("Spacing")]
            [Validation(Required=false)]
            public List<float?> Spacing { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39C848F7-D814-1A06-AE0D-AFC706B9700F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
