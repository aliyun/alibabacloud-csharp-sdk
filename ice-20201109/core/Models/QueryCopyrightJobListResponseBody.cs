// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryCopyrightJobListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCopyrightJobListResponseBodyData> Data { get; set; }
        public class QueryCopyrightJobListResponseBodyData : TeaModel {
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
            /// <para>Information about the input video for watermarking.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public QueryCopyrightJobListResponseBodyDataInput Input { get; set; }
            public class QueryCopyrightJobListResponseBodyDataInput : TeaModel {
                /// <summary>
                /// <para>The specific input information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/object</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The type of the input file. Valid values:</para>
                /// <ol>
                /// <item><description>OSS: an Object Storage Service (OSS) object.</description></item>
                /// <item><description>Media: a media asset.</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bfb786c639894f4d80648792021****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The watermark level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            /// <summary>
            /// <para>The content of the embedded watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Information about the watermarked output video.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public QueryCopyrightJobListResponseBodyDataOutput Output { get; set; }
            public class QueryCopyrightJobListResponseBodyDataOutput : TeaModel {
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
            /// <para>The job result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Code&quot;:&quot;success&quot;,&quot;Message&quot;:&quot;ok&quot;}</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The status of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user-defined data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The ID of the user who initiated the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1346693***</para>
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
        /// <para><b><b><b>36-3C1E-4417-BDB2-1E034F</b></b></b></para>
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
