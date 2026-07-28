// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListJobsRequest : TeaModel {
        /// <summary>
        /// <para>The job type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("jobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results per page. Default value: 20. Minimum value: 1. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: The initial status after the job is created.</description></item>
        /// <item><description>PlanQueued: After the job is created, if no workflow is available, the job is queued.</description></item>
        /// <item><description>Planning: The resource job is in the Plan execution phase.</description></item>
        /// <item><description>ConfigProactiveInProgress: Compliance pre-check is in progress. The compliance pre-check feature must be enabled for the account.</description></item>
        /// <item><description>ConfigProactiveSuccess: Compliance pre-check succeeded. The compliance pre-check feature must be enabled for the account.</description></item>
        /// <item><description>Planned: The resource job has completed the Plan execution.</description></item>
        /// <item><description>PlannedAndFinished: After the Plan execution is complete, no diff is found. This is a final status.</description></item>
        /// <item><description>Confirmed: The resource job is waiting for confirmation after the Plan execution is complete.</description></item>
        /// <item><description>ApplyQueued: During job execution, if no workflow is available, the job is queued.</description></item>
        /// <item><description>Applying: The resource job is in the Apply execution phase.</description></item>
        /// <item><description>Applied: The resource job has completed the Apply execution. This is a final status.</description></item>
        /// <item><description>Errored: The job execution encountered an error. This is a final status.</description></item>
        /// <item><description>Canceled: The job execution was canceled. This is a final status.</description></item>
        /// <item><description>Discarded: The plan of the resource job was discarded. This is a final status.</description></item>
        /// <item><description>ConfigProactiveFailure: Compliance pre-check failed. The compliance pre-check feature must be enabled for the account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Errored</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Task: regular task. This is the default value.</description></item>
        /// <item><description>SceneTestingTask: scenario-based testing task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SceneTestingTask</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
