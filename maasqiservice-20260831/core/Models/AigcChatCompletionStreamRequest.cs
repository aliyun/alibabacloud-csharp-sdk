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
            /// <para>The message content. You can pass text. A multimodal array can contain text, image_url, or video_url. The lite edition of Creative Agent performs image-to-image generation when a reference image is provided and text-to-image generation when no reference image is provided. It does not accept videos.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;text&quot;,&quot;text&quot;:&quot;Generate a night view of a futuristic city after rain&quot;}]</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<AigcChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class AigcChatCompletionStreamRequestMessagesContent : TeaModel {
                /// <summary>
                /// <para>The reference image when type is image_url. HTTPS URLs or Base64 data URLs are supported.</para>
                /// </summary>
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public AigcChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class AigcChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <para>The publicly accessible HTTPS URL of the reference image, or a complete Base64 image data URL (such as data:image/png;base64,...). Signed URLs must be valid during request execution. For expired or unauthorized images, you must re-upload them or update the links.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/input.png">https://example.com/input.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The generation or editing objective when type is text.</para>
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
                /// <para>The video input when type is video_url. Only the Planner of the dedicated edition of Creative Agent accepts it. The lite edition of Creative Agent rejects it.</para>
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
            /// <para>The message role. Place the current generation objective in a user message. The history can include user, assistant, and tool messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The extended input for the current image creation. Use the parameters object to set generation parameters. Do not use it to pass model addresses or keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;parameters&quot;:{&quot;size&quot;:&quot;1024*1024&quot;,&quot;n&quot;:1}}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public AigcChatCompletionStreamRequestMetadata Metadata { get; set; }
        public class AigcChatCompletionStreamRequestMetadata : TeaModel {
            /// <summary>
            /// <para>The image parameters for the current request. Only size, n, seed, negative_prompt, num_inference_steps, and guidance_scale are supported. Omitted fields use the default configurations. response_format is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;size&quot;:&quot;1024*1024&quot;,&quot;n&quot;:1,&quot;num_inference_steps&quot;:8}</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public AigcChatCompletionStreamRequestMetadataParameters Parameters { get; set; }
            public class AigcChatCompletionStreamRequestMetadataParameters : TeaModel {
                /// <summary>
                /// <para>The guidance scale, which must be a finite number from 0 to 20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("guidanceScale")]
                [Validation(Required=false)]
                public double? GuidanceScale { get; set; }

                /// <summary>
                /// <para>The number of images to generate for the current request, which must be an integer from 1 to 6.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("n")]
                [Validation(Required=false)]
                public long? N { get; set; }

                /// <summary>
                /// <para>The negative prompt, which is used to describe content that you do not want to appear in the results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Low quality, blurry, text, watermark</para>
                /// </summary>
                [NameInMap("negativePrompt")]
                [Validation(Required=false)]
                public string NegativePrompt { get; set; }

                /// <summary>
                /// <para>The number of model inference iterations, which must be an integer from 1 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("numInferenceSteps")]
                [Validation(Required=false)]
                public long? NumInferenceSteps { get; set; }

                /// <summary>
                /// <para>The random seed, which must be an integer from 0 to 2147483647.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("seed")]
                [Validation(Required=false)]
                public long? Seed { get; set; }

                /// <summary>
                /// <para>The output pixel size, such as 1024<em>1024 or 1280</em>720. 1024x1024 is also accepted. Specifying this parameter overrides the default aspect ratio size for the current request. Use the width and height supported by the model.</para>
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
        /// <para>A compatibility placeholder field. You can omit it or pass an empty string. You cannot use this field to switch the model used by the instance. The model field in the response is an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot; &quot;</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Specifies whether to use SSE streaming responses. You must set this parameter to true for this operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>The HTTP JSON key is stream_options. Set include_usage to obtain the token usage for the current call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;include_usage&quot;:true}</para>
        /// </summary>
        [NameInMap("streamOptions")]
        [Validation(Required=false)]
        public AigcChatCompletionStreamRequestStreamOptions StreamOptions { get; set; }
        public class AigcChatCompletionStreamRequestStreamOptions : TeaModel {
            /// <summary>
            /// <para>The HTTP JSON key is include_usage. When set to true, an independent usage block is returned before the end marker, and its choices field is an empty array. Token usage does not represent the number of images or the final bill.</para>
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
