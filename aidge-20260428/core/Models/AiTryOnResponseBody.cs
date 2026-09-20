// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AiTryOnResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AiTryOnResponseBodyData Data { get; set; }
        public class AiTryOnResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1360</para>
            /// </summary>
            [NameInMap("ImageHeight")]
            [Validation(Required=false)]
            public string ImageHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/virtual-try-on-result.png">https://example.com/virtual-try-on-result.png</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>768</para>
            /// </summary>
            [NameInMap("ImageWidth")]
            [Validation(Required=false)]
            public string ImageWidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;ProcessedImageCount&quot;:1,&quot;Resolution&quot;:&quot;1K&quot;}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public AiTryOnResponseBodyDataUsageMap UsageMap { get; set; }
            public class AiTryOnResponseBodyDataUsageMap : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ProcessedImageCount")]
                [Validation(Required=false)]
                public long? ProcessedImageCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1K</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2728332e-72c1-9c0d-8869-5781b2cd25d4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
