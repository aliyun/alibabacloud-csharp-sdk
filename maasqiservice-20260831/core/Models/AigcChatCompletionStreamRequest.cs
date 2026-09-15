// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class AigcChatCompletionStreamRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:&quot;生成一张水墨山水画&quot;}]</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<AigcChatCompletionStreamRequestMessages> Messages { get; set; }
        public class AigcChatCompletionStreamRequestMessages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>生成一张雨后未来城市夜景</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<AigcChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class AigcChatCompletionStreamRequestMessagesContent : TeaModel {
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public AigcChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class AigcChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/input.png">https://example.com/input.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>把参考图背景改成海边日落</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("videoUrl")]
                [Validation(Required=false)]
                public AigcChatCompletionStreamRequestMessagesContentVideoUrl VideoUrl { get; set; }
                public class AigcChatCompletionStreamRequestMessagesContentVideoUrl : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/input.mp4">https://example.com/input.mp4</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;parameters&quot;:{&quot;size&quot;:&quot;1024*1024&quot;,&quot;n&quot;:1}}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public AigcChatCompletionStreamRequestMetadata Metadata { get; set; }
        public class AigcChatCompletionStreamRequestMetadata : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;size&quot;:&quot;1024*1024&quot;,&quot;n&quot;:1,&quot;num_inference_steps&quot;:8}</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public AigcChatCompletionStreamRequestMetadataParameters Parameters { get; set; }
            public class AigcChatCompletionStreamRequestMetadataParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("guidanceScale")]
                [Validation(Required=false)]
                public double? GuidanceScale { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("n")]
                [Validation(Required=false)]
                public long? N { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>低质量、模糊、文字、水印</para>
                /// </summary>
                [NameInMap("negativePrompt")]
                [Validation(Required=false)]
                public string NegativePrompt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("numInferenceSteps")]
                [Validation(Required=false)]
                public long? NumInferenceSteps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("seed")]
                [Validation(Required=false)]
                public long? Seed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024*1024</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

        }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;include_usage&quot;:true}</para>
        /// </summary>
        [NameInMap("streamOptions")]
        [Validation(Required=false)]
        public AigcChatCompletionStreamRequestStreamOptions StreamOptions { get; set; }
        public class AigcChatCompletionStreamRequestStreamOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("includeUsage")]
            [Validation(Required=false)]
            public bool? IncludeUsage { get; set; }

        }

    }

}
