// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class QaChatResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public QaChatResponseBodyData Data { get; set; }
        public class QaChatResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;items&quot;: [
            ///     {
            ///       &quot;title&quot;: &quot;MacBook Neo 深度测评：全面超越，最轻盈的生产力&quot;,
            ///       &quot;videoUrl&quot;: &quot;<a href="https://video.example.com/macbook-neo-review.mp4">https://video.example.com/macbook-neo-review.mp4</a>&quot;,
            ///       &quot;coverUrl&quot;: &quot;<a href="https://images.unsplash.com/photo-1529139574466-a303027c1d8b?auto=format&fit=crop&w=800&q=80">https://images.unsplash.com/photo-1529139574466-a303027c1d8b?auto=format&amp;fit=crop&amp;w=800&amp;q=80</a>&quot;,
            ///       &quot;tags&quot;: [
            ///         &quot;数码产品&quot;,
            ///         &quot;评测&quot;,
            ///         &quot;MacBook&quot;,
            ///         &quot;生产力&quot;
            ///       ]
            ///     }
            ///   ]
            /// }</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>如果你想更快看到上身效果，这 3 条短视频会更直观。\n\n<b>第一条：完整通勤 look</b>\n\n3 套通勤到周末无缝切换的浅色运动鞋穿搭。</para>
            /// </summary>
            [NameInMap("delta")]
            [Validation(Required=false)]
            public string Delta { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>参数错误</para>
            /// </summary>
            [NameInMap("errorText")]
            [Validation(Required=false)]
            public string ErrorText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("finishReason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2a127bc9-9474-405d-916d-8bc4475fa459</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2a127bc9-9474-405d-916d-8bc4475fa459</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("retryable")]
            [Validation(Required=false)]
            public bool? Retryable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2a127bc9-9474-405d-916d-8bc4475fa459</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
