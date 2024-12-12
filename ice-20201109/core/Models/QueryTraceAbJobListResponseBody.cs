// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryTraceAbJobListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryTraceAbJobListResponseBodyData> Data { get; set; }
        public class QueryTraceAbJobListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1627357322</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1627357322</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public QueryTraceAbJobListResponseBodyDataInput Input { get; set; }
            public class QueryTraceAbJobListResponseBodyDataInput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://bucket/object</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bfb786c639894f4d80648792021eff90</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public QueryTraceAbJobListResponseBodyDataOutput Output { get; set; }
            public class QueryTraceAbJobListResponseBodyDataOutput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://bucket/dir/</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;Code&quot;:&quot;success&quot;,&quot;Message&quot;:&quot;ok&quot;}</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>437bd2b51105d07b12a9</b></b></para>
            /// </summary>
            [NameInMap("TraceMediaId")]
            [Validation(Required=false)]
            public string TraceMediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13466932****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
