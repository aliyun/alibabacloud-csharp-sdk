// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class QaChatRequest : TeaModel {
        /// <summary>
        /// <para>Application ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2052929167853146113</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>User message object containing role and multimodal content.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public QaChatRequestMessage Message { get; set; }
        public class QaChatRequestMessage : TeaModel {
            /// <summary>
            /// <para>Individual content block, differentiated by <c>type</c></para>
            /// </summary>
            [NameInMap("parts")]
            [Validation(Required=false)]
            public List<QaChatRequestMessageParts> Parts { get; set; }
            public class QaChatRequestMessageParts : TeaModel {
                /// <summary>
                /// <para>Required when type = &quot;data&quot;. The data object structure is as follows:</para>
                /// <list type="bullet">
                /// <item><description>type: String type, required, indicates the data subtype. Currently supported value is &quot;template&quot;, indicating a video template.</description></item>
                /// <item><description>videoId: String type, conditionally required. Only required when type = &quot;template&quot;, indicating the video template ID; can be ignored or set to null for other types.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;type&quot;: &quot;template&quot;,
                ///   &quot;videoId&quot;: &quot;xxxx&quot;
                /// }</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                /// <summary>
                /// <para>Required when <c>type=&quot;file&quot;</c>.</para>
                /// <list type="bullet">
                /// <item><description>Media type, currently only supports image formats JPG/PNG/WEBP/JPEG, maximum 5</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>image/png</para>
                /// </summary>
                [NameInMap("mediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>Required when <c>type=&quot;text&quot;</c>.</para>
                /// <list type="bullet">
                /// <item><description>Text content, maximum 1024 characters</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>请问这个视频讲了什么？</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>Fixed content block type, only supports <c>&quot;text&quot;</c> / <c>&quot;file&quot;</c> / <c>&quot;data&quot;</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Required when <c>type=&quot;file&quot;</c>. Supports the following two types, with format support for JPG/PNG/WEBP/JPEG:</para>
                /// <para>• Media resource CDN URL, currently supports images, maximum 5;
                /// • Image encoding, upload image files using base64 encoded strings (supports bitmap formats), maximum 5</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/img.jpg">https://example.com/img.jpg</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Message role, currently only supports the <c>&quot;user&quot;</c> role</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>No input required</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;debug&quot;: true
        /// }</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, object> Options { get; set; }

        /// <summary>
        /// <para>Q&amp;A session ID, used to track multiple Q&amp;A interactions from the same user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req_123456789</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
