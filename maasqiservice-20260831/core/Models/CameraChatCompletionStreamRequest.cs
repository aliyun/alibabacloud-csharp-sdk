// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class CameraChatCompletionStreamRequest : TeaModel {
        /// <summary>
        /// <para>Required. Provide only one role=user message and one image. Multiple images, custom text, videos, and tool invocations are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:[{&quot;type&quot;:&quot;image_url&quot;,&quot;image_url&quot;:{&quot;url&quot;:&quot;<a href="https://example.com/images/person.jpg%22%7D%7D%5D%7D%5D">https://example.com/images/person.jpg&quot;}}]}]</a></para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CameraChatCompletionStreamRequestMessages> Messages { get; set; }
        public class CameraChatCompletionStreamRequestMessages : TeaModel {
            /// <summary>
            /// <para>Required. Contains one image_url image. Do not include custom recognition prompts here.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<CameraChatCompletionStreamRequestMessagesContent> Content { get; set; }
            public class CameraChatCompletionStreamRequestMessagesContent : TeaModel {
                /// <summary>
                /// <para>The HTTP JSON key is image_url. Required. Contains the url field for the image address.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public CameraChatCompletionStreamRequestMessagesContentImageUrl ImageUrl { get; set; }
                public class CameraChatCompletionStreamRequestMessagesContentImageUrl : TeaModel {
                    /// <summary>
                    /// <para>A publicly accessible HTTPS URL or a complete Base64 image data URL. Signed links must remain valid during execution. Both the image and the request body are subject to size limits. Use URLs for large images.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/images/person.jpg">https://example.com/images/person.jpg</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>Required. Fixed to image_url.</para>
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
            /// <para>Required. Fixed to user.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The HTTP JSON key is scene_id. Required for person recognition. The value must be non-empty, contain no leading or trailing whitespace, and be up to 50 characters in length. Reuse the same scene ID for person recognition. Omit this field for food recognition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>meeting-room-001</para>
        /// </summary>
        [NameInMap("sceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>If set to true, an SSE response is returned. If set to false or omitted, a complete JSON detection result is returned. SSE transmits the final result and does not output token by token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
