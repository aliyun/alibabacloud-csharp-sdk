// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePriceTagDetectionResponseBody : Darabonba.Model {
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
        /// <para>The scenario recognition result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MerchandisePriceTagDetectionResponseBodyData Data { get; set; }
        public class MerchandisePriceTagDetectionResponseBodyData : Darabonba.Model {
            /// <summary>
            /// <para>The detection and recognition result details.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public MerchandisePriceTagDetectionResponseBodyDataResult Result { get; set; }
            public class MerchandisePriceTagDetectionResponseBodyDataResult : Darabonba.Model {
                /// <summary>
                /// <para>The localization information.</para>
                /// </summary>
                [NameInMap("Grounding")]
                [Validation(Required=false)]
                public MerchandisePriceTagDetectionResponseBodyDataResultGrounding Grounding { get; set; }
                public class MerchandisePriceTagDetectionResponseBodyDataResultGrounding : Darabonba.Model {
                    /// <summary>
                    /// <para>The coverage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>complete</para>
                    /// </summary>
                    [NameInMap("Coverage")]
                    [Validation(Required=false)]
                    public string Coverage { get; set; }

                    /// <summary>
                    /// <para>The region list.</para>
                    /// </summary>
                    [NameInMap("Regions")]
                    [Validation(Required=false)]
                    public List<MerchandisePriceTagDetectionResponseBodyDataResultGroundingRegions> Regions { get; set; }
                    public class MerchandisePriceTagDetectionResponseBodyDataResultGroundingRegions : Darabonba.Model {
                        /// <summary>
                        /// <para>The bounding box coordinates.</para>
                        /// </summary>
                        [NameInMap("Bbox2d")]
                        [Validation(Required=false)]
                        public List<double?> Bbox2d { get; set; }

                        /// <summary>
                        /// <para>The label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>price_tag</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The recognized text.</para>
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
                /// <para>The price tag list. This can be an empty array if no price tags are recognized under normal conditions.</para>
                /// </summary>
                [NameInMap("PriceTags")]
                [Validation(Required=false)]
                public List<MerchandisePriceTagDetectionResponseBodyDataResultPriceTags> PriceTags { get; set; }
                public class MerchandisePriceTagDetectionResponseBodyDataResultPriceTags : Darabonba.Model {
                    /// <summary>
                    /// <para>The location.</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public MerchandisePriceTagDetectionResponseBodyDataResultPriceTagsLocation Location { get; set; }
                    public class MerchandisePriceTagDetectionResponseBodyDataResultPriceTagsLocation : Darabonba.Model {
                        /// <summary>
                        /// <para>The bottom boundary of the detection box.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>369</para>
                        /// </summary>
                        [NameInMap("Bottom")]
                        [Validation(Required=false)]
                        public string Bottom { get; set; }

                        /// <summary>
                        /// <para>The left boundary of the detection box.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>796</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public string Left { get; set; }

                        /// <summary>
                        /// <para>The right boundary of the detection box.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>820</para>
                        /// </summary>
                        [NameInMap("Right")]
                        [Validation(Required=false)]
                        public string Right { get; set; }

                        /// <summary>
                        /// <para>The top boundary of the detection box.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>338</para>
                        /// </summary>
                        [NameInMap("top")]
                        [Validation(Required=false)]
                        public string Top { get; set; }

                    }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public string OriginalPrice { get; set; }

                    /// <summary>
                    /// <para>The selling price, retained as a string to avoid being parsed as a reserved word or reserved character.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.50</para>
                    /// </summary>
                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    /// <summary>
                    /// <para>The associated product code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>001</para>
                    /// </summary>
                    [NameInMap("SkuCode")]
                    [Validation(Required=false)]
                    public string SkuCode { get; set; }

                    /// <summary>
                    /// <para>The associated product name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sku_test</para>
                    /// </summary>
                    [NameInMap("SkuName")]
                    [Validation(Required=false)]
                    public string SkuName { get; set; }

                }

                /// <summary>
                /// <para>The value is fixed to priceTag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>priceTag</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The usage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The return message or failure description.</para>
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

