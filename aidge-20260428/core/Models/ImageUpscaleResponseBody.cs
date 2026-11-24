// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageUpscaleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code, such as &quot;success&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageUpscaleResponseBodyData Data { get; set; }
        public class ImageUpscaleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The upscaling result data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ImageUpscaleResponseBodyDataData Data { get; set; }
            public class ImageUpscaleResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The actual height of the generated image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("ImageHeight")]
                [Validation(Required=false)]
                public int? ImageHeight { get; set; }

                /// <summary>
                /// <para>The URL of the upscaled single image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/output.png">https://example.com/output.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The actual width of the generated image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("ImageWidth")]
                [Validation(Required=false)]
                public int? ImageWidth { get; set; }

            }

            /// <summary>
            /// <para>The error code returned when the operation fails, such as InvalidParameter or DownstreamUnavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the operation fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation was successful. A value of true indicates success, and a value of false indicates failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The ID of the downstream task. This parameter is left empty for synchronous API operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ed9d8504-6141-9fbb-8345-4fa36433483f</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The usage information. The key is the billing dimension name.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public ImageUpscaleResponseBodyDataUsageMap UsageMap { get; set; }
            public class ImageUpscaleResponseBodyDataUsageMap : TeaModel {
                /// <summary>
                /// <para>The number of processed images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ProcessedImageCount")]
                [Validation(Required=false)]
                public int? ProcessedImageCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message or error prompt.</para>
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
        /// <para>Indicates whether the call was successful. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
