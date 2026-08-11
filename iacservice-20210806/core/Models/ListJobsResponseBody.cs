// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of job information.</para>
        /// </summary>
        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<ListJobsResponseBodyJobs> Jobs { get; set; }
        public class ListJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The job configuration.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public ListJobsResponseBodyJobsConfig Config { get; set; }
            public class ListJobsResponseBodyJobsConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether the job is a destroy job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isDestroy")]
                [Validation(Required=false)]
                public bool? IsDestroy { get; set; }

                /// <summary>
                /// <para>The template description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>moduleDescription</para>
                /// </summary>
                [NameInMap("moduleDescription")]
                [Validation(Required=false)]
                public string ModuleDescription { get; set; }

                /// <summary>
                /// <para>The template version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("moduleVersion")]
                [Validation(Required=false)]
                public string ModuleVersion { get; set; }

                /// <summary>
                /// <para>The resource change content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>+0 ~0 -0</para>
                /// </summary>
                [NameInMap("resourcesChanged")]
                [Validation(Required=false)]
                public string ResourcesChanged { get; set; }

                /// <summary>
                /// <para>The operation command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>destroy</para>
                /// </summary>
                [NameInMap("subCommand")]
                [Validation(Required=false)]
                public string SubCommand { get; set; }

            }

            /// <summary>
            /// <para>The time when the job was created, in UTC in the ISO 8601 format of YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-05T02:13:43Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The job description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The execution duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5m</para>
            /// </summary>
            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The execution type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: Manual execution (default).</description></item>
            /// <item><description>Auto: Automatic execution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("executeType")]
            [Validation(Required=false)]
            public string ExecuteType { get; set; }

            /// <summary>
            /// <para>Indicates whether the assertion check passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isPassAssertCheck")]
            [Validation(Required=false)]
            public bool? IsPassAssertCheck { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-433aff9e4dca57b147c</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The initial status after the job is created.</description></item>
            /// <item><description>PlanQueued: After the job is created, if no workflow is available, the job is queued.</description></item>
            /// <item><description>Planning: The resource job is in the Plan execution phase.</description></item>
            /// <item><description>ConfigProactiveInProgress: Compliance pre-check is in progress. The account must have the compliance pre-check feature enabled.</description></item>
            /// <item><description>ConfigProactiveSuccess: Compliance pre-check succeeded. The account must have the compliance pre-check feature enabled.</description></item>
            /// <item><description>Planned: The resource job has completed Plan execution.</description></item>
            /// <item><description>PlannedAndFinished: After Plan execution is completed, no diff is found. This is a final status.</description></item>
            /// <item><description>Confirmed: The resource job is waiting for confirmation after Plan execution is completed.</description></item>
            /// <item><description>ApplyQueued: During job execution, if no workflow is available, the job is queued.</description></item>
            /// <item><description>Applying: The resource job is in the Apply execution phase.</description></item>
            /// <item><description>Applied: The resource job has completed Apply execution. This is a final status.</description></item>
            /// <item><description>Errored: The job execution encountered an error. This is a final status.</description></item>
            /// <item><description>Canceled: The job execution was canceled. This is a final status.</description></item>
            /// <item><description>Discarded: The plan of the resource job was discarded. This is a final status.</description></item>
            /// <item><description>ConfigProactiveFailure: Compliance pre-check failed. The account must have the compliance pre-check feature enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Errored</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The status details.</para>
            /// </summary>
            [NameInMap("statusDetail")]
            [Validation(Required=false)]
            public Dictionary<string, JobsStatusDetailValue> StatusDetail { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-518876866c2c3efb</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The Terraform provider version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.240.0</para>
            /// </summary>
            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

        }

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
        /// <para>The number of results returned per page. Default value: 20. Minimum value: 1. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>882304F9-6DB1-5593-A719-33473D082B9C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
