// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AiTryOnResponseBody : Darabonba.Model {
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
        public class AiTryOnResponseBodyData : Darabonba.Model {
            /// <summary>
            /// <para>The height of the result image in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1360</para>
            /// </summary>
            [NameInMap("ImageHeight")]
            [Validation(Required=false)]
            public string ImageHeight { get; set; }

            /// <summary>
            /// <para>The URL of the virtual try-on result image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/virtual-try-on-result.png">https://example.com/virtual-try-on-result.png</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The width of the result image in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>768</para>
            /// </summary>
            [NameInMap("ImageWidth")]
            [Validation(Required=false)]
            public string ImageWidth { get; set; }

            /// <summary>
            /// <para>The usage details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessedImageCount&quot;:1,&quot;Resolution&quot;:&quot;1K&quot;}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public AiTryOnResponseBodyDataUsageMap UsageMap { get; set; }
            public class AiTryOnResponseBodyDataUsageMap : Darabonba.Model {
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
                /// <para>The resolution of the processed images.</para>
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

