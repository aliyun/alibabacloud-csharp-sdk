// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListEventSubEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of callback records returned on the current page.</para>
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
        public List<ListEventSubEventResponseBodyLogs> Logs { get; set; }
        public class ListEventSubEventResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9qb1****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The HTTP status code. A value of 200 indicates that the callback was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>The callback duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public int? Cost { get; set; }

            /// <summary>
            /// <para>The details about the callback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;MsgId\&quot;:\&quot;875d5266cbabb1834cc84a105cf68454\&quot;,\&quot;MsgTimestamp\&quot;:1697545591,\&quot;SubscribeId\&quot;:\&quot;09be0d2254cb5a89f4cbd86403ec5343\&quot;,\&quot;AppId\&quot;:\&quot;xxx\&quot;,\&quot;ChannelId\&quot;:\&quot;9099\&quot;,\&quot;Contents\&quot;:[{\&quot;Event\&quot;:\&quot;UserEvent\&quot;,\&quot;UserEvent\&quot;:{\&quot;UserId\&quot;:\&quot;linux_test\&quot;,\&quot;EventTag\&quot;:\&quot;Leave\&quot;,\&quot;SessionId\&quot;:\&quot;je7y2sBZJZQ0VBJZrh4LnBkxvGH2WyVs\&quot;,\&quot;Timestamp\&quot;:1697545591,\&quot;ChannelProfile\&quot;:\&quot;interactive_live\&quot;,\&quot;US\&quot;:5068748604047364,\&quot;Reason\&quot;:1,\&quot;Role\&quot;:1,\&quot;TerminalType\&quot;:6,\&quot;UserType\&quot;:2}}]}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>The ID of the callback record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>875d5266cbabb1834cc84a105cf6****</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The subscription ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad53276431c****</para>
            /// </summary>
            [NameInMap("SubId")]
            [Validation(Required=false)]
            public string SubId { get; set; }

            /// <summary>
            /// <para>The time when the callback was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-17 20:26:31.988</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://****.com/callback</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC8CB656-A7BA-1811-9D6B-4CC187E988BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
