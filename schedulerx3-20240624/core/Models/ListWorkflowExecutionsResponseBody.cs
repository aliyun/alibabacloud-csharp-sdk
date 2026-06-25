// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListWorkflowExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of <c>200</c> indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkflowExecutionsResponseBodyData Data { get; set; }
        public class ListWorkflowExecutionsResponseBodyData : TeaModel {
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
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListWorkflowExecutionsResponseBodyDataRecords> Records { get; set; }
            public class ListWorkflowExecutionsResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The data time of the workflow execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-12 14:52:42</para>
                /// </summary>
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                /// <summary>
                /// <para>The end time of the workflow execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-12 14:52:42</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The executor ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1827811800526000</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// <para>The schedule time of the workflow execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-12 14:52:42</para>
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                /// <summary>
                /// <para>The start time of the workflow execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-11-04 01:09:27</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the workflow execution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: UNKNOWN</para>
                /// </description></item>
                /// <item><description><para>1: WAITING</para>
                /// </description></item>
                /// <item><description><para>2: READY</para>
                /// </description></item>
                /// <item><description><para>3: RUNNING</para>
                /// </description></item>
                /// <item><description><para>4: SUCCESS</para>
                /// </description></item>
                /// <item><description><para>5: FAILED</para>
                /// </description></item>
                /// <item><description><para>6: PAUSED</para>
                /// </description></item>
                /// <item><description><para>7: SUBMITTED</para>
                /// </description></item>
                /// <item><description><para>8: REJECTED</para>
                /// </description></item>
                /// <item><description><para>9: ACCEPTED</para>
                /// </description></item>
                /// <item><description><para>10: PARTIAL_FAILED</para>
                /// </description></item>
                /// <item><description><para>11: SKIPPED</para>
                /// </description></item>
                /// <item><description><para>12: REMOVED</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The workflow execution ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("WorkflowExecutionId")]
                [Validation(Required=false)]
                public string WorkflowExecutionId { get; set; }

                /// <summary>
                /// <para>The workflow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public string WorkflowId { get; set; }

                /// <summary>
                /// <para>The workflow name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myWorkflow</para>
                /// </summary>
                [NameInMap("WorkflowName")]
                [Validation(Required=false)]
                public string WorkflowName { get; set; }

            }

            /// <summary>
            /// <para>The total number of matching workflow executions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message. If the request fails, this parameter provides details about the error.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If this parameter is not returned, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eCKqVlS5FKF5EWGGOo8EgQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique request ID. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BAC1ADB5-EEB5-5834-93D8-522E067AF8D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
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
