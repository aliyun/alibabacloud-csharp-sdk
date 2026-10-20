// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePlacementDetectionLiteResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MerchandisePlacementDetectionLiteResponseBodyData Data { get; set; }
        public class MerchandisePlacementDetectionLiteResponseBodyData : Darabonba.Model {
            /// <summary>
            /// <para>The result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public MerchandisePlacementDetectionLiteResponseBodyDataResult Result { get; set; }
            public class MerchandisePlacementDetectionLiteResponseBodyDataResult : Darabonba.Model {
                /// <summary>
                /// <para>The supplementary element grounding results.</para>
                /// </summary>
                [NameInMap("Grounding")]
                [Validation(Required=false)]
                public MerchandisePlacementDetectionLiteResponseBodyDataResultGrounding Grounding { get; set; }
                public class MerchandisePlacementDetectionLiteResponseBodyDataResultGrounding : Darabonba.Model {
                    /// <summary>
                    /// <para>The coverage status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>complete: The relevant visible targets are complete.</description></item>
                    /// <item><description>partial: Only some targets are valid or recognizable.</description></item>
                    /// <item><description>Empty string: No valid supplementary grounding results are obtained.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>complete</para>
                    /// </summary>
                    [NameInMap("Coverage")]
                    [Validation(Required=false)]
                    public string Coverage { get; set; }

                    /// <summary>
                    /// <para>The target array, which contains up to 12 items. This array can be empty when no relevant targets are found.</para>
                    /// </summary>
                    [NameInMap("Regions")]
                    [Validation(Required=false)]
                    public List<MerchandisePlacementDetectionLiteResponseBodyDataResultGroundingRegions> Regions { get; set; }
                    public class MerchandisePlacementDetectionLiteResponseBodyDataResultGroundingRegions : Darabonba.Model {
                        /// <summary>
                        /// <para>The 2D bounding box in the format of [top-left x, top-left y, bottom-right x, bottom-right y]. The values range from 0 to 1000. The left coordinate is less than the right coordinate, and the top coordinate is less than the bottom coordinate.</para>
                        /// </summary>
                        [NameInMap("Bbox_2d")]
                        [Validation(Required=false)]
                        public List<long?> Bbox2d { get; set; }

                        /// <summary>
                        /// <para>The target category.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>price_tag</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The confirmable short name or text of up to 24 characters. This field is an empty string when the text is unclear.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5.50</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

                /// <summary>
                /// <para>The product items.</para>
                /// </summary>
                [NameInMap("Products")]
                [Validation(Required=false)]
                public List<MerchandisePlacementDetectionLiteResponseBodyDataResultProducts> Products { get; set; }
                public class MerchandisePlacementDetectionLiteResponseBodyDataResultProducts : Darabonba.Model {
                    /// <summary>
                    /// <para>The bounding boxes corresponding to the SKU.</para>
                    /// </summary>
                    [NameInMap("Boxes")]
                    [Validation(Required=false)]
                    public List<MerchandisePlacementDetectionLiteResponseBodyDataResultProductsBoxes> Boxes { get; set; }
                    public class MerchandisePlacementDetectionLiteResponseBodyDataResultProductsBoxes : Darabonba.Model {
                        /// <summary>
                        /// <para>The bottom coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("Bottom")]
                        [Validation(Required=false)]
                        public long? Bottom { get; set; }

                        /// <summary>
                        /// <para>The left coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public long? Left { get; set; }

                        /// <summary>
                        /// <para>The right coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>(\&quot;874\&quot;)</para>
                        /// </summary>
                        [NameInMap("Right")]
                        [Validation(Required=false)]
                        public long? Right { get; set; }

                        /// <summary>
                        /// <para>The bottom coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public long? Top { get; set; }

                    }

                    /// <summary>
                    /// <para>The recognition code, which is obtained by removing the trailing _ce from the recognition name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sku_test</para>
                    /// </summary>
                    [NameInMap("SkuId")]
                    [Validation(Required=false)]
                    public string SkuId { get; set; }

                }

                /// <summary>
                /// <para>The deduplicated list of SkuIds.</para>
                /// </summary>
                [NameInMap("SkuIds")]
                [Validation(Required=false)]
                public List<string> SkuIds { get; set; }

                /// <summary>
                /// <para>The result type, which is fixed to sku.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sku</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The usage map. The value is {&quot;ProcessingCount&quot;:1} for a successful call, and an empty object for a failed call.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The response message or failure description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70CBEFDF-BB17-1EB3-8A21-569F3124738F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

