// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetIndexJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The error status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Index.Forbidden</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data field returned by the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIndexJobStatusResponseBodyData Data { get; set; }
        public class GetIndexJobStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of files imported in this job.</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<GetIndexJobStatusResponseBodyDataDocuments> Documents { get; set; }
            public class GetIndexJobStatusResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <para>The error status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Index.Document.ChunkError</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_9a65732555b54d5ea10796ca5742ba22_xxxxxxxx</para>
                /// </summary>
                [NameInMap("DocId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX产品介绍</para>
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
                /// <para>The file import status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INSERT_ERROR: Failed to import into the index.</description></item>
                /// <item><description>RUNNING: Index building in progress.</description></item>
                /// <item><description>DELETED: Deleted.</description></item>
                /// <item><description>FINISH: Index building succeeded.</description></item>
                /// <item><description>PARSE_FAILED: Parsing failed.</description></item>
                /// <item><description>DOC_PARSING: Parsing in progress.</description></item>
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
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66122af12a4e45ddae6bd6c84555xxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The current status of the knowledge base job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COMPLETED: Execution succeeded.</description></item>
            /// <item><description>FAILED: Execution failed.</description></item>
            /// <item><description>RUNNING: Execution in progress.</description></item>
            /// <item><description>PENDING: Waiting for execution.</description></item>
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
        /// <para>The status code returned by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
