// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetIndexJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Index.Forbidden</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIndexJobStatusResponseBodyData Data { get; set; }
        public class GetIndexJobStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of imported documents.</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<GetIndexJobStatusResponseBodyDataDocuments> Documents { get; set; }
            public class GetIndexJobStatusResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <para>HTTP status code</para>
                /// 
                /// <b>Example:</b>
                /// <para>Index.Document.ChunkError</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The primary key ID of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_9a65732555b54d5ea10796ca5742ba22_XXXXXXXX</para>
                /// </summary>
                [NameInMap("DocId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>The name of the document.</para>
                /// </summary>
                [NameInMap("DocName")]
                [Validation(Required=false)]
                public string DocName { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>document parse error</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The import status of the document. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INSERT_ERROR</description></item>
                /// <item><description>RUNNING</description></item>
                /// <item><description>DELETED</description></item>
                /// <item><description>FINISH</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66122af12a4e45ddae6bd6c845556647</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The status of the knowledge base job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COMPLETED</description></item>
            /// <item><description>FAILED</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>PENDING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indications whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
