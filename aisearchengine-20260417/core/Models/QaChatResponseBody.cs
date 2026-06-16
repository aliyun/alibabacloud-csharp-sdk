// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class QaChatResponseBody : TeaModel {
        /// <summary>
        /// <para>Protocol data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QaChatResponseBodyData Data { get; set; }
        public class QaChatResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Structured response data</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///  &quot;items&quot;: [
            ///  {
            ///  &quot;title&quot;: &quot;电脑产品评测&quot;,
            ///  &quot;videoUrl&quot;: &quot;<a href="https://video.example.com/review.mp4">https://video.example.com/review.mp4</a>&quot;,
            ///  &quot;coverUrl&quot;: &quot;<a href="https://images.example">https://images.example</a>&quot;,
            ///  &quot;tags&quot;: [
            ///  &quot;数码产品&quot;,
            ///  &quot;评测&quot;,
            ///  &quot;电脑&quot;,
            ///  &quot;生产力&quot;
            ///  ]
            ///  }
            ///  ]
            /// }</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>Incremental text output</para>
            /// 
            /// <b>Example:</b>
            /// <para>如果你想更快看到上身效果，这 3 条短视频会更直观。\n\n<b>第一条：完整通勤 look</b>\n\n3 套通勤到周末无缝切换的浅色运动鞋穿搭。</para>
            /// </summary>
            [NameInMap("delta")]
            [Validation(Required=false)]
            public string Delta { get; set; }

            /// <summary>
            /// <para>See error code list</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>See error code list</para>
            /// 
            /// <b>Example:</b>
            /// <para>参数错误</para>
            /// </summary>
            [NameInMap("errorText")]
            [Validation(Required=false)]
            public string ErrorText { get; set; }

            /// <summary>
            /// <para>Completion reason. When the value is stop, it indicates output is complete; on error, the output is the error reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("finishReason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            /// <summary>
            /// <para>Unique identifier. For multi-segment text, different segments use different ids, while the id remains consistent within a text segment</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a127bc9-9474-405d-916d-8bc4475fa459</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Request ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a127bc9-9474-405d-916d-8bc4475fa459</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>Whether the error is retryable, defaults to true</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("retryable")]
            [Validation(Required=false)]
            public bool? Retryable { get; set; }

            /// <summary>
            /// <para>Same as event</para>
            /// 
            /// <b>Example:</b>
            /// <para>v</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Event type description:</para>
        /// <ol>
        /// <item><description><para>Lifecycle</para>
        /// <list type="bullet">
        /// <item><description>start / finish</description></item>
        /// <item><description>Marks the beginning and end of a message</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Text content</para>
        /// <list type="bullet">
        /// <item><description>text-start / text-delta / text-end</description></item>
        /// <item><description>Markdown text streaming output</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Inline media</para>
        /// <list type="bullet">
        /// <item><description>data-image-info / data-video-info</description></item>
        /// <item><description>Media cards in text-image/text-video mixed content</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Source references</para>
        /// <list type="bullet">
        /// <item><description>data-reference</description></item>
        /// <item><description>Unified source list (web / document / image / video)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Inline references</para>
        /// <list type="bullet">
        /// <item><description>data-document-ref</description></item>
        /// <item><description>Perplexity-style inline document references</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Template video</para>
        /// <list type="bullet">
        /// <item><description>data-template-video</description></item>
        /// <item><description>Video cards output by AV template agent</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Template analysis</para>
        /// <list type="bullet">
        /// <item><description>data-video-info / data-template-info / data-template-video-content</description></item>
        /// <item><description>Analysis result data from AV template agent</description></item>
        /// <item><description>Table-type templates such as &quot;Speech Transcription&quot;, &quot;Video Outline&quot;, and &quot;Video-to-Script&quot; are delivered at once via data-template-video-content</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Streaming JSON</para>
        /// <list type="bullet">
        /// <item><description>json-start / json-delta / json-end</description></item>
        /// <item><description>Incremental delta-only JSON streaming protocol</description></item>
        /// <item><description>Used for structured JSON template analysis output such as &quot;Action Expression&quot;</description></item>
        /// </list>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>Request ID, same as requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2a127bc9-9474-405d-916d-8bc4475fa459</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
