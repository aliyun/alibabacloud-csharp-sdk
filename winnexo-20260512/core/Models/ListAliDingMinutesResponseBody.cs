// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAliDingMinutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The location clusters.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListAliDingMinutesResponseBodyItems> Items { get; set; }
        public class ListAliDingMinutesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The name of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John Doe</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The execution duration of the asynchronous task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600000</para>
            /// </summary>
            [NameInMap("durationMs")]
            [Validation(Required=false)]
            public long? DurationMs { get; set; }

            /// <summary>
            /// <para>The end timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-08T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The DingTalk meeting minutes ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76327569643231383535353939365f3436383537393431335f32</para>
            /// </summary>
            [NameInMap("minutesId")]
            [Validation(Required=false)]
            public string MinutesId { get; set; }

            /// <summary>
            /// <para>The start timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-08T09:00:00+08:00</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Running is returned upon submission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The title of the scheduled meeting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weekly Project Meeting</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

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
        /// <para>The token for the next retrieval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opaque-next-cursor</para>
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-id</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
