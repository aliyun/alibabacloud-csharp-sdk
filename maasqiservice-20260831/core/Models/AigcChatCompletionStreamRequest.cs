// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class AigcChatCompletionStreamRequest : TeaModel {
        /// <summary>
        /// <para>The conversation message array. Creative Agent uses the last user message as the current objective and executes it in combination with the session history.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:&quot;Generate an ink wash landscape painting&quot;}]</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<AigcChatCompletionStreamRequestMessages> Messages { get; set; }
        public class AigcChatCompletionStreamRequestMessages : TeaModel {
            /// <summary>
            /// <para>The message content. Can be text. A multimodal array can contain text, image_url, or video_url. The Creative Agent Lite edition performs image-to-image when a reference image is provided and text-to-image when no reference image is provided. It does not accept video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generate a futuristic city nightscape after rain</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<AigcChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class AigcChatCompletionStreamRequestMessagesContent : TeaModel {
                /// <summary>
                /// <para>The reference image when type is set to image_url. Supports HTTPS URLs or Base64 Data URLs.</para>
                /// </summary>
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public AigcChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class AigcChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <para>The publicly accessible HTTPS URL of the reference image, or a complete Base64 image Data URL (such as data:image/png;base64,...). Signed URLs must remain valid during request execution. Re-upload or update the link for expired or unauthorized images.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/input.png">https://example.com/input.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The generation or editing objective when type is set to text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Change the background of the reference image to a seaside sunset</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The content part type: text, image_url, or video_url.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The video input when type is set to video_url. Only accepted by the Creative Agent Dedicated edition Planner. The Creative Agent Lite edition rejects this type.</para>
                /// </summary>
                [NameInMap("videoUrl")]
                [Validation(Required=false)]
                public AigcChatCompletionStreamRequestMessagesContentVideoUrl VideoUrl { get; set; }
                public class AigcChatCompletionStreamRequestMessagesContentVideoUrl : TeaModel {
                    /// <summary>
                    /// <para>The video URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/input.mp4">https://example.com/input.mp4</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The message role. Place the current generation objective in a user message. History can include user, assistant, and tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The extended input for this image creation request. Use the parameters object to set generation parameters. Do not use this field to pass model addresses or keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;parameters&quot;:{&quot;size&quot;:&quot;1024*1024&quot;,&quot;n&quot;:1}}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public AigcChatCompletionStreamRequestMetadata Metadata { get; set; }
        public class AigcChatCompletionStreamRequestMetadata : TeaModel {
            /// <summary>
            /// <para>The image parameters for this request. Only size, n, seed, negative_prompt, num_inference_steps, and guidance_scale are supported. Omitted fields use the default configurations. response_format is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;size&quot;:&quot;1024*1024&quot;,&quot;n&quot;:1,&quot;num_inference_steps&quot;:8}</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public AigcChatCompletionStreamRequestMetadataParameters Parameters { get; set; }
            public class AigcChatCompletionStreamRequestMetadataParameters : TeaModel {
                /// <summary>
                /// <para>The guidance scale. Must be a finite number between 0 and 20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("guidanceScale")]
                [Validation(Required=false)]
                public double? GuidanceScale { get; set; }

                /// <summary>
                /// <para>The number of images to generate for this request. Must be an integer in the range of 1 to 6.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("n")]
                [Validation(Required=false)]
                public long? N { get; set; }

                /// <summary>
                /// <para>The negative prompt that describes content you do not want to appear in the result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>low quality, blurry, text, watermark</para>
                /// </summary>
                [NameInMap("negativePrompt")]
                [Validation(Required=false)]
                public string NegativePrompt { get; set; }

                /// <summary>
                /// <para>The number of model inference iterations. Must be an integer in the range of 1 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("numInferenceSteps")]
                [Validation(Required=false)]
                public long? NumInferenceSteps { get; set; }

                /// <summary>
                /// <para>The random seed. Must be an integer in the range of 0 to 2147483647.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("seed")]
                [Validation(Required=false)]
                public long? Seed { get; set; }

                /// <summary>
                /// <para>The output pixel dimensions, such as <c>1024*1024</c> or <c>1280*720</c>. The format <c>1024x1024</c> is also accepted. When specified, this value overrides the default canvas dimensions for this request. Use width and height values supported by the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024*1024</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public string Size { get; set; }

            }

        }

        /// <summary>
        /// <para>A compatibility placeholder field. Can be omitted or set to an empty string. You cannot use this field to switch the model used by the instance. The model field in the response is an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot; &quot;</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Specifies whether to use SSE streaming responses. This parameter must be set to true for this operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>The HTTP JSON key is stream_options. Set include_usage to retrieve the token usage for this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;include_usage&quot;:true}</para>
        /// </summary>
        [NameInMap("streamOptions")]
        [Validation(Required=false)]
        public AigcChatCompletionStreamRequestStreamOptions StreamOptions { get; set; }
        public class AigcChatCompletionStreamRequestStreamOptions : TeaModel {
            /// <summary>
            /// <para>The HTTP JSON key is include_usage. When set to true, an independent usage chunk is returned before the end marker. The choices field in this chunk is an empty array. Token usage does not represent the number of images or the final bill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("includeUsage")]
            [Validation(Required=false)]
            public bool? IncludeUsage { get; set; }

        }

    }

}
