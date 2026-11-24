// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePlacementDetectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is not returned when the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The display detection results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MerchandisePlacementDetectionResponseBodyData Data { get; set; }
        public class MerchandisePlacementDetectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of valid bounding boxes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BoxCount")]
            [Validation(Required=false)]
            public int? BoxCount { get; set; }

            /// <summary>
            /// <para>The list of retrieval details for each bounding box.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<MerchandisePlacementDetectionResponseBodyDataData> Data { get; set; }
            public class MerchandisePlacementDetectionResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The coordinates of the bounding box in the [x1,y1,x2,y2] format.</para>
                /// </summary>
                [NameInMap("Bbox")]
                [Validation(Required=false)]
                public List<float?> Bbox { get; set; }

                /// <summary>
                /// <para>The reason why the bounding box processing failed. This parameter is null if the processing is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Embedding failed</para>
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                /// <summary>
                /// <para>The index of the bounding box.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Idx")]
                [Validation(Required=false)]
                public int? Idx { get; set; }

                /// <summary>
                /// <para>The top-1 retrieved product for the bounding box.</para>
                /// </summary>
                [NameInMap("Top1")]
                [Validation(Required=false)]
                public MerchandisePlacementDetectionResponseBodyDataDataTop1 Top1 { get; set; }
                public class MerchandisePlacementDetectionResponseBodyDataDataTop1 : TeaModel {
                    /// <summary>
                    /// <para>The similarity score, which ranges from 0 to 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.53</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    /// <summary>
                    /// <para>The ID of the retrieved product.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("SkuId")]
                    [Validation(Required=false)]
                    public string SkuId { get; set; }

                    /// <summary>
                    /// <para>The name of the retrieved product.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bright Dairy Milk 500ml</para>
                    /// </summary>
                    [NameInMap("SkuName")]
                    [Validation(Required=false)]
                    public string SkuName { get; set; }

                }

                /// <summary>
                /// <para>The list of top-K retrieved products for the bounding box.</para>
                /// </summary>
                [NameInMap("Topk")]
                [Validation(Required=false)]
                public List<MerchandisePlacementDetectionResponseBodyDataDataTopk> Topk { get; set; }
                public class MerchandisePlacementDetectionResponseBodyDataDataTopk : TeaModel {
                    /// <summary>
                    /// <para>The retrieval rank.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Rank")]
                    [Validation(Required=false)]
                    public int? Rank { get; set; }

                    /// <summary>
                    /// <para>The similarity score, which ranges from 0 to 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.82</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    /// <summary>
                    /// <para>The ID of the retrieved product.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("SkuId")]
                    [Validation(Required=false)]
                    public string SkuId { get; set; }

                    /// <summary>
                    /// <para>The name of the retrieved product.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bright Dairy Milk 500ml</para>
                    /// </summary>
                    [NameInMap("SkuName")]
                    [Validation(Required=false)]
                    public string SkuName { get; set; }

                }

            }

            /// <summary>
            /// <para>The usage information. The key is the usage metric name and the value is the count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned when the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
