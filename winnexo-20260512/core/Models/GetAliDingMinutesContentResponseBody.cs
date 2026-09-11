// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetAliDingMinutesContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The DingTalk minutes ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76327569643231383535353939365f3436383537393431335f32</para>
        /// </summary>
        [NameInMap("minutesId")]
        [Validation(Required=false)]
        public string MinutesId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-id</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The intelligent meeting summary content.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Meeting Summary</h1>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The new session title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly Project Meeting</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The to-do item details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dingtalkTodoList&quot;:[]}</para>
        /// </summary>
        [NameInMap("todoContent")]
        [Validation(Required=false)]
        public string TodoContent { get; set; }

        /// <summary>
        /// <para>The speech-type execution parameters.</para>
        /// </summary>
        [NameInMap("transcription")]
        [Validation(Required=false)]
        public List<GetAliDingMinutesContentResponseBodyTranscription> Transcription { get; set; }
        public class GetAliDingMinutesContentResponseBodyTranscription : TeaModel {
            /// <summary>
            /// <para>The returned content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Meeting started</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The speaker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John</para>
            /// </summary>
            [NameInMap("speaker")]
            [Validation(Required=false)]
            public string Speaker { get; set; }

            /// <summary>
            /// <para>The avatar of the speaker. An empty string is returned if no avatar is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://robject.oss-cn-shanghai.aliyuncs.com/robject-daily1/">https://robject.oss-cn-shanghai.aliyuncs.com/robject-daily1/</a></para>
            /// </summary>
            [NameInMap("speakerAvatar")]
            [Validation(Required=false)]
            public string SpeakerAvatar { get; set; }

            /// <summary>
            /// <para>The end time of the segment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("timeEnd")]
            [Validation(Required=false)]
            public long? TimeEnd { get; set; }

            /// <summary>
            /// <para>The start time of the segment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("timeStart")]
            [Validation(Required=false)]
            public long? TimeStart { get; set; }

        }

    }

}
