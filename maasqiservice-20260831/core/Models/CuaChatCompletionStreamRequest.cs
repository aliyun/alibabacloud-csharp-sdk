// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class CuaChatCompletionStreamRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CuaChatCompletionStreamRequestMessages> Messages { get; set; }
        public class CuaChatCompletionStreamRequestMessages : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<CuaChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class CuaChatCompletionStreamRequestMessagesContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>data:image/png;base64,<IMAGE_BASE64></para>
                /// </summary>
                [NameInMap("imageData")]
                [Validation(Required=false)]
                public string ImageData { get; set; }

                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public CuaChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class CuaChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/desktop.png">https://example.com/desktop.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>打开浏览器并访问指定页面。</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>call_cua_1</para>
            /// </summary>
            [NameInMap("toolCallId")]
            [Validation(Required=false)]
            public string ToolCallId { get; set; }

        }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public CuaChatCompletionStreamRequestMetadata Metadata { get; set; }
        public class CuaChatCompletionStreamRequestMetadata : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("screenHeight")]
            [Validation(Required=false)]
            public int? ScreenHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("screenWidth")]
            [Validation(Required=false)]
            public int? ScreenWidth { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot; &quot;</para>
        /// </summary>
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

        [NameInMap("streamOptions")]
        [Validation(Required=false)]
        public CuaChatCompletionStreamRequestStreamOptions StreamOptions { get; set; }
        public class CuaChatCompletionStreamRequestStreamOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("includeUsage")]
            [Validation(Required=false)]
            public bool? IncludeUsage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Tools { get; set; }

    }

}
