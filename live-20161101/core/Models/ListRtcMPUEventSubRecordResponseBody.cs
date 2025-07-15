// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListRtcMPUEventSubRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>Indicates whether the current page is followed by a page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The callback records.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<ListRtcMPUEventSubRecordResponseBodyLogs> Logs { get; set; }
        public class ListRtcMPUEventSubRecordResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourAppId</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://testcallback***.com/callback">http://testcallback***.com/callback</a></para>
            /// </summary>
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// <para>The callback duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public long? Cost { get; set; }

            /// <summary>
            /// <para>For more information about the callback, see <a href="https://help.aliyun.com/document_detail/2804583.html">CreateRtcMPUEventSub</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;EventType\&quot;:1,\&quot;MsgId\&quot;:\&quot;42bba8b5-94ab-468c-9dae-9b501dd6c***\&quot;,\&quot;AppId\&quot;:\&quot;rtcdev\&quot;,\&quot;SubId\&quot;:\&quot;Sub-9799B2C45009799B2C4***\&quot;,\&quot;TaskId\&quot;:\&quot;mpucallbacktest\&quot;,\&quot;CallbackTs\&quot;:1712656430***,\&quot;Payload\&quot;:{\&quot;DstUrl\&quot;:\&quot;rtmp://domain/app/stream?auth\&quot;,\&quot;EventTs\&quot;:1712656430***,\&quot;EventCode\&quot;:1,\&quot;ErrorCode\&quot;:0,\&quot;ErrorMessage\&quot;:\&quot;\&quot;}}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>The HTTP status code. 200 indicates that the callback is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("HTTPCode")]
            [Validation(Required=false)]
            public string HTTPCode { get; set; }

            /// <summary>
            /// <para>The ID of the callback record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42bba8b5-********-9b501dd6cb6e</para>
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// <para>The ID of the subscription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sub-<b><b><b>9799B2C4500</b></b></b></para>
            /// </summary>
            [NameInMap("SubId")]
            [Validation(Required=false)]
            public string SubId { get; set; }

            /// <summary>
            /// <para>The time when the callback was invoked. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1970-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
