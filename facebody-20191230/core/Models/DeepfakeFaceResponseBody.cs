// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DeepfakeFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeepfakeFaceResponseBodyData Data { get; set; }
        public class DeepfakeFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DeepfakeFaceResponseBodyDataElements> Elements { get; set; }
            public class DeepfakeFaceResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FaceNumber")]
                [Validation(Required=false)]
                public long? FaceNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DeepfakeFace/DeepfakeFace1.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DeepfakeFace/DeepfakeFace1.jpg</a></para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DeepfakeFaceResponseBodyDataElementsResults> Results { get; set; }
                public class DeepfakeFaceResponseBodyDataElementsResults : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>36.6455</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>normalface</para>
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

                    [NameInMap("Rect")]
                    [Validation(Required=false)]
                    public DeepfakeFaceResponseBodyDataElementsResultsRect Rect { get; set; }
                    public class DeepfakeFaceResponseBodyDataElementsResultsRect : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>284</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public long? Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>373</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public long? Left { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>111</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public long? Top { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>207</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public long? Width { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8E6F65D5-62A1-1E5B-BC0B-00508034AC92</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8E6F65D5-62A1-1E5B-BC0B-00508034AC92</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
