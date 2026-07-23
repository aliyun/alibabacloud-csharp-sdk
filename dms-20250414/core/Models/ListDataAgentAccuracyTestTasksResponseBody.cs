// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentAccuracyTestTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataAgentAccuracyTestTasksResponseBodyData> Data { get; set; }
        public class ListDataAgentAccuracyTestTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The accuracy test instance ID to which the task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>at-106n4rg17gv9fxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("AccuracyTestInsId")]
            [Validation(Required=false)]
            public string AccuracyTestInsId { get; set; }

            /// <summary>
            /// <para>The accuracy test task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>692abb8f-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("AccuracyTestTaskId")]
            [Validation(Required=false)]
            public string AccuracyTestTaskId { get; set; }

            /// <summary>
            /// <para>The number of completed test subtasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("FinishedTaskNumber")]
            [Validation(Required=false)]
            public int? FinishedTaskNumber { get; set; }

            /// <summary>
            /// <para>The time when the document was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-30T08:03:30.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the document was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-30T08:03:30.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent sessions during the test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxConcurrent")]
            [Validation(Required=false)]
            public int? MaxConcurrent { get; set; }

            /// <summary>
            /// <para>Specifies whether sessions are displayed after analysis. This feature is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedDelete")]
            [Validation(Required=false)]
            public bool? NeedDelete { get; set; }

            /// <summary>
            /// <para>The status of the custom agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 PENDING,1 RUNNING,2 COMPLETED,3 STOPPED,4 FAILED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The total number of subtasks in the accuracy test task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalTaskNumber")]
            [Validation(Required=false)]
            public int? TotalTaskNumber { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8wfig6l33n4f4xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NesLo****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-xxx-FD8AD04A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
