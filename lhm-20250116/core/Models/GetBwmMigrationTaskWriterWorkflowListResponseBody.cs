// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetBwmMigrationTaskWriterWorkflowListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetBwmMigrationTaskWriterWorkflowListResponseBodyData> Data { get; set; }
        public class GetBwmMigrationTaskWriterWorkflowListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cron expression.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The database primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The submit failure error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Submit failed</para>
            /// </summary>
            [NameInMap("submitDetail")]
            [Validation(Required=false)]
            public string SubmitDetail { get; set; }

            /// <summary>
            /// <para>Filter by status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WRT_INIT: Submit not started.</description></item>
            /// <item><description>WRT_RUN: Submitting.</description></item>
            /// <item><description>WRT_SUCC: All submitted successfully.</description></item>
            /// <item><description>WRT_FAIL: All submissions failed.</description></item>
            /// <item><description>WRT_PART_FAIL: Some submissions failed.</description></item>
            /// <item><description>DPY_SUCC: Published successfully.</description></item>
            /// <item><description>DPY_FAIL: Publish failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WRT_INIT</para>
            /// </summary>
            [NameInMap("submitStatus")]
            [Validation(Required=false)]
            public string SubmitStatus { get; set; }

            /// <summary>
            /// <para>The workflow ID written to the target side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>target_wf-12345</para>
            /// </summary>
            [NameInMap("targetWorkflowId")]
            [Validation(Required=false)]
            public string TargetWorkflowId { get; set; }

            /// <summary>
            /// <para>The workflow name on the target side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>target_workflow_name</para>
            /// </summary>
            [NameInMap("targetWorkflowName")]
            [Validation(Required=false)]
            public string TargetWorkflowName { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("taskNodeCount")]
            [Validation(Required=false)]
            public int? TaskNodeCount { get; set; }

            /// <summary>
            /// <para>The actual workflow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wf-12345</para>
            /// </summary>
            [NameInMap("workflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

            /// <summary>
            /// <para>The workflow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workflow_name</para>
            /// </summary>
            [NameInMap("workflowName")]
            [Validation(Required=false)]
            public string WorkflowName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the result is empty.</para>
        /// </summary>
        [NameInMap("empty")]
        [Validation(Required=false)]
        public bool? Empty { get; set; }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>Indicates whether the result is not empty.</para>
        /// </summary>
        [NameInMap("notEmpty")]
        [Validation(Required=false)]
        public bool? NotEmpty { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure. If the call fails, check errCode and errMessage for details.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
