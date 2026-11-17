// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class CuaChatCompletionStreamRequest : TeaModel {
        /// <summary>
        /// <para>The messages. In the first round, only one user message is allowed. In subsequent rounds, only one tool message followed by one user message is allowed. Exactly one screenshot is required for each step.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CuaChatCompletionStreamRequestMessages> Messages { get; set; }
        public class CuaChatCompletionStreamRequestMessages : TeaModel {
            /// <summary>
            /// <para>The message content. The user role uses a multimodal array. The tool role supports an array of text items, a non-empty string, or an object to return execution results.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<CuaChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class CuaChatCompletionStreamRequestMessagesContent : TeaModel {
                /// <summary>
                /// <para>The compatibility field for input_image. It uses a complete Base64 image data URL. Raw Base64 without a prefix is not accepted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data:image/png;base64,<IMAGE_BASE64></para>
                /// </summary>
                [NameInMap("imageData")]
                [Validation(Required=false)]
                public string ImageData { get; set; }

                /// <summary>
                /// <para>The screenshot reference. The URL object format is recommended. The backend is also compatible with the image_url string.</para>
                /// </summary>
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public CuaChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class CuaChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <para>The accessible HTTP(S) URL or complete image data URL. HTTPS is recommended.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>data:image/jpeg;base64,<BASE64_OF_CURRENT_SCREENSHOT></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The text content. In the first round, the user must provide a non-empty task objective. For the tool role, enter the actual execution result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Observe the desktop, open the browser, and find the settings page</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The content type. For text, use text or input_text. For screenshots, use image_url or input_image.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image_url</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The role of the message. Only user and tool are supported. Do not pass system, assistant, or complete history.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The tool call ID. This parameter is required when role is set to tool. It must be equal to the computer_use call ID returned in the previous step of the same session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_ID_RETURNED_IN_THE_PREVIOUS_ROUND</para>
            /// </summary>
            [NameInMap("toolCallId")]
            [Validation(Required=false)]
            public string ToolCallId { get; set; }

        }

        /// <summary>
        /// <para>The auxiliary information of the current screenshot and the running modes supported by the service instructions.</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public CuaChatCompletionStreamRequestMetadata Metadata { get; set; }
        public class CuaChatCompletionStreamRequestMetadata : TeaModel {
            /// <summary>
            /// <para>The action mode. Valid values: gui-only and gui+cli. This parameter is case-sensitive and fixed within a session, and is supplemented by subsequent service instructions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gui-only / gui+cli</para>
            /// </summary>
            [NameInMap("actionMode")]
            [Validation(Required=false)]
            public string ActionMode { get; set; }

            /// <summary>
            /// <para>The pixel height of the uploaded screenshot. If provided, it must be a positive integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("screenHeight")]
            [Validation(Required=false)]
            public int? ScreenHeight { get; set; }

            /// <summary>
            /// <para>The pixel width of the uploaded screenshot. If provided, it must be a positive integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("screenWidth")]
            [Validation(Required=false)]
            public int? ScreenWidth { get; set; }

        }

        /// <summary>
        /// <para>The model. This is a compatibility field. You can omit it or pass an empty string. The actual model is determined by the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable streaming. Set this parameter to true for this SSE API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>The SSE settings.</para>
        /// </summary>
        [NameInMap("streamOptions")]
        [Validation(Required=false)]
        public CuaChatCompletionStreamRequestStreamOptions StreamOptions { get; set; }
        public class CuaChatCompletionStreamRequestStreamOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to return an independent usage event before the end marker. If set to true, an independent usage event is returned, and choices is an empty array.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("includeUsage")]
            [Validation(Required=false)]
            public bool? IncludeUsage { get; set; }

        }

        /// <summary>
        /// <para>The tools. You can only omit this parameter or pass an empty array. CUA uses the fixed computer_use tool, and custom tools are not allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Tools { get; set; }

    }

}
