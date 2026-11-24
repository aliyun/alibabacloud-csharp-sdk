// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AiTryOnResponseBody : TeaModel {
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
        /// <para>The returned result struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AiTryOnResponseBodyData Data { get; set; }
        public class AiTryOnResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual height of the generated image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1360</para>
            /// </summary>
            [NameInMap("ImageHeight")]
            [Validation(Required=false)]
            public string ImageHeight { get; set; }

            /// <summary>
            /// <para>The recognition result of a single image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/virtual-try-on-result.png">https://example.com/virtual-try-on-result.png</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The actual width of the generated image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>768</para>
            /// </summary>
            [NameInMap("ImageWidth")]
            [Validation(Required=false)]
            public string ImageWidth { get; set; }

            /// <summary>
            /// <para>The usage field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessedImageCount&quot;:1,&quot;Resolution&quot;:&quot;1K&quot;}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public AiTryOnResponseBodyDataUsageMap UsageMap { get; set; }
            public class AiTryOnResponseBodyDataUsageMap : TeaModel {
                /// <summary>
                /// <para>The number of processed images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ProcessedImageCount")]
                [Validation(Required=false)]
                public long? ProcessedImageCount { get; set; }

                /// <summary>
                /// <para>The image resolution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1K</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

            }

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
        /// <para>The request ID, which is used to identify a unique request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
