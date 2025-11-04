// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryTraceM3u8JobListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryTraceM3u8JobListResponseBodyData> Data { get; set; }
        public class QueryTraceM3u8JobListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1627357322</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1627357322</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>d718e2ff4f018ccf419a7b71</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The output video.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public QueryTraceM3u8JobListResponseBodyDataOutput Output { get; set; }
            public class QueryTraceM3u8JobListResponseBodyDataOutput : TeaModel {
                /// <summary>
                /// <para>The specific output information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/object</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The type of the output file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: an OSS object.</description></item>
                /// <item><description>Media: a media asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The current status of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The watermark information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Trace")]
            [Validation(Required=false)]
            public string Trace { get; set; }

            /// <summary>
            /// <para>The media ID for the trace watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>437bd2b105d07b12a9a82</b></b></para>
            /// </summary>
            [NameInMap("TraceMediaId")]
            [Validation(Required=false)]
            public string TraceMediaId { get; set; }

            /// <summary>
            /// <para>The user-defined data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The ID of the user who initiated the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1346693276****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
