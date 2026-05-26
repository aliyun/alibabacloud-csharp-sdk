// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class QaChatRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2047140750220754946</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public QaChatRequestMessage Message { get; set; }
        public class QaChatRequestMessage : TeaModel {
            [NameInMap("parts")]
            [Validation(Required=false)]
            public List<QaChatRequestMessageParts> Parts { get; set; }
            public class QaChatRequestMessageParts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;templateId&quot;: &quot;456789&quot;
                /// }</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>image/png</para>
                /// </summary>
                [NameInMap("mediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>帮我搜索下今天的天气</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://meeting.dingtalk.com/j/4sSPAxWaPbM">https://meeting.dingtalk.com/j/4sSPAxWaPbM</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

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
        /// <para>{
        ///   &quot;debug&quot;: true
        /// }</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, object> Options { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b2a979e79799489fbde56119bf8c4dc7</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
