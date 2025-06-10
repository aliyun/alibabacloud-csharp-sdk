// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectLungNoduleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectLungNoduleResponseBodyData Data { get; set; }
        public class DetectLungNoduleResponseBodyData : TeaModel {
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DetectLungNoduleResponseBodyDataSeries> Series { get; set; }
            public class DetectLungNoduleResponseBodyDataSeries : TeaModel {
                [NameInMap("Elements")]
                [Validation(Required=false)]
                public List<DetectLungNoduleResponseBodyDataSeriesElements> Elements { get; set; }
                public class DetectLungNoduleResponseBodyDataSeriesElements : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.7012705768508907</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9.730626493692398</para>
                    /// </summary>
                    [NameInMap("Diameter")]
                    [Validation(Required=false)]
                    public float? Diameter { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>308.9676976455463</para>
                    /// </summary>
                    [NameInMap("ImageX")]
                    [Validation(Required=false)]
                    public float? ImageX { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>198.3552282631497</para>
                    /// </summary>
                    [NameInMap("ImageY")]
                    [Validation(Required=false)]
                    public float? ImageY { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20.434030793471255</para>
                    /// </summary>
                    [NameInMap("ImageZ")]
                    [Validation(Required=false)]
                    public float? ImageZ { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>up</para>
                    /// </summary>
                    [NameInMap("Lobe")]
                    [Validation(Required=false)]
                    public string Lobe { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>left</para>
                    /// </summary>
                    [NameInMap("Lung")]
                    [Validation(Required=false)]
                    public string Lung { get; set; }

                    [NameInMap("MajorAxis")]
                    [Validation(Required=false)]
                    public List<float?> MajorAxis { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>261.37589112119247</para>
                    /// </summary>
                    [NameInMap("MeanValue")]
                    [Validation(Required=false)]
                    public float? MeanValue { get; set; }

                    [NameInMap("MinorAxis")]
                    [Validation(Required=false)]
                    public List<float?> MinorAxis { get; set; }

                    /// <summary>
                    /// <para>结节最大径位置所在帧的ID标识。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.3.6.1.4.1.14519.5.2.1.6279.6001.468208655866166788627471660948</para>
                    /// </summary>
                    [NameInMap("RecistSOPInstanceUID")]
                    [Validation(Required=false)]
                    public string RecistSOPInstanceUID { get; set; }

                    /// <summary>
                    /// <para>结节为恶性的置信度。取值范围0~1。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.173</para>
                    /// </summary>
                    [NameInMap("Risk")]
                    [Validation(Required=false)]
                    public float? Risk { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.3.6.1.4.1.14519.5.2.1.6279.6001.261151233960269013402330853013</para>
                    /// </summary>
                    [NameInMap("SOPInstanceUID")]
                    [Validation(Required=false)]
                    public string SOPInstanceUID { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10959.220491175074</para>
                    /// </summary>
                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public float? Volume { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>51.24291240631416</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public float? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-32.23147700784307</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-46.81608170781766</para>
                    /// </summary>
                    [NameInMap("Z")]
                    [Validation(Required=false)]
                    public float? Z { get; set; }

                }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Origin")]
                [Validation(Required=false)]
                public List<float?> Origin { get; set; }

                [NameInMap("Report")]
                [Validation(Required=false)]
                public string Report { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.3.6.1.4.1.14519.5.2.1.6279.6001.179049373636438705059720603192</para>
                /// </summary>
                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Spacing")]
                [Validation(Required=false)]
                public List<float?> Spacing { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9889ef5b-b973-4dd0-9f26-3b9cc489c436</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
