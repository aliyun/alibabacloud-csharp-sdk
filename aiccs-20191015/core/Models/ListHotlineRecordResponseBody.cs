// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListHotlineRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of Success indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The hotline session information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListHotlineRecordResponseBodyData> Data { get; set; }
        public class ListHotlineRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The session ID. This is the acid value in the WebSocket after an inbound call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100365558</para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>The connection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100365548</para>
            /// </summary>
            [NameInMap("ConnectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            /// <summary>
            /// <para>The timestamp when the recording ended. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16128694810</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the recording started. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16128694110</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The URL of the recording file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://aliccrec-shvpc.oss-cn-shanghai.aliyuncs.com">http://aliccrec-shvpc.oss-cn-shanghai.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
