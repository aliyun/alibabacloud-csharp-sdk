// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectInfraredLivingFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectInfraredLivingFaceResponseBodyData Data { get; set; }
        public class DetectInfraredLivingFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectInfraredLivingFaceResponseBodyDataElements> Elements { get; set; }
            public class DetectInfraredLivingFaceResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FaceNumber")]
                [Validation(Required=false)]
                public long? FaceNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://viapi-demo.oss-cn-shanghai.aliyuncs.com/viapi-demo/images/SegmentCommonImage/segmentimage-src-hu.jpeg">http://viapi-demo.oss-cn-shanghai.aliyuncs.com/viapi-demo/images/SegmentCommonImage/segmentimage-src-hu.jpeg</a></para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DetectInfraredLivingFaceResponseBodyDataElementsResults> Results { get; set; }
                public class DetectInfraredLivingFaceResponseBodyDataElementsResults : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>liveness</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>blurred, occluded or large angle face, please check.</para>
                    /// </summary>
                    [NameInMap("MessageTips")]
                    [Validation(Required=false)]
                    public string MessageTips { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>83.3848</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Rect")]
                    [Validation(Required=false)]
                    public DetectInfraredLivingFaceResponseBodyDataElementsResultsRect Rect { get; set; }
                    public class DetectInfraredLivingFaceResponseBodyDataElementsResultsRect : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public long? Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public long? Left { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public long? Top { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public long? Width { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>review</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>68DF6EC7-3B1D-11EE-9FA7-1122F1AE92DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
