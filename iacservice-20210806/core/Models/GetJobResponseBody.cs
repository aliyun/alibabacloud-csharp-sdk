// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The job details.</para>
        /// </summary>
        [NameInMap("job")]
        [Validation(Required=false)]
        public GetJobResponseBodyJob Job { get; set; }
        public class GetJobResponseBodyJob : TeaModel {
            [NameInMap("allParameters")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobAllParameters> AllParameters { get; set; }
            public class GetJobResponseBodyJobAllParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>regionId</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("secret")]
                [Validation(Required=false)]
                public bool? Secret { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of assertion checks. This parameter applies to scenario-based testing tasks.</para>
            /// </summary>
            [NameInMap("assertCheckDetail")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobAssertCheckDetail> AssertCheckDetail { get; set; }
            public class GetJobResponseBodyJobAssertCheckDetail : TeaModel {
                /// <summary>
                /// <para>The comparison operator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>eq: equal to</description></item>
                /// <item><description>n_eq: not equal to</description></item>
                /// <item><description>ctn: contains</description></item>
                /// <item><description>n_ctn: does not contain</description></item>
                /// <item><description>regex: regular expression match.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("comparison")]
                [Validation(Required=false)]
                public string Comparison { get; set; }

                /// <summary>
                /// <para>The expected value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>期望值</para>
                /// </summary>
                [NameInMap("expectedValue")]
                [Validation(Required=false)]
                public string ExpectedValue { get; set; }

                /// <summary>
                /// <para>Indicates whether the assertion check is passed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isPass")]
                [Validation(Required=false)]
                public bool? IsPass { get; set; }

                /// <summary>
                /// <para>The assertion type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>state: task status</description></item>
                /// <item><description>result: execution result</description></item>
                /// <item><description>resourceChange: resource change.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>result</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The job configuration.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobConfig Config { get; set; }
            public class GetJobResponseBodyJobConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to automatically execute the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoApply")]
                [Validation(Required=false)]
                public bool? AutoApply { get; set; }

                /// <summary>
                /// <para>Specifies whether compliance pre-check is performed for this job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hasConfigProactive")]
                [Validation(Required=false)]
                public string HasConfigProactive { get; set; }

                /// <summary>
                /// <para>Specifies whether to destroy resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fales</para>
                /// </summary>
                [NameInMap("isDestroy")]
                [Validation(Required=false)]
                public bool? IsDestroy { get; set; }

                /// <summary>
                /// <para>The template version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
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
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-31T03:38:40Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The job description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>url</para>
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public Dictionary<string, object> DownloadUrl { get; set; }

            /// <summary>
            /// <para>The execution duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3s</para>
            /// </summary>
            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The execution type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: manual execution (default)</description></item>
            /// <item><description>Auto: automatic execution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("executeType")]
            [Validation(Required=false)]
            public string ExecuteType { get; set; }

            /// <summary>
            /// <para>Indicates whether the assertion check is passed.</para>
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
            /// <para>job-518855d9a058cfff0dc933e6b5767</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

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
            /// <para>The run logs. The following log content (key values) is currently supported:</para>
            /// <list type="bullet">
            /// <item><description><para>tf-init.run.error.log</para>
            /// </description></item>
            /// <item><description><para>tf-init.plan.log</para>
            /// </description></item>
            /// <item><description><para>tf-plan.run.log</para>
            /// </description></item>
            /// <item><description><para>tf-apply.run.log</para>
            /// </description></item>
            /// <item><description><para>tf-init.apply.log.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("logFile")]
            [Validation(Required=false)]
            public Dictionary<string, object> LogFile { get; set; }

            /// <summary>
            /// <para>The job output.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The change details of the Plan phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;formatVersion&quot;: &quot;1.2&quot;,
            ///     &quot;terraformVersion&quot;: &quot;1.5.7&quot;,
            ///     &quot;providerVersion&quot;: &quot;1.262.1&quot;,
            ///     &quot;plannedValues&quot;: {
            ///         &quot;root_module&quot;: {
            ///         }
            ///     },
            ///     &quot;resourceChanges&quot;: [
            ///         {
            ///             &quot;address&quot;: &quot;alicloud_instance.uuid_ae98dda8_xxxxxxx&quot;,
            ///             &quot;mode&quot;: &quot;managed&quot;,
            ///             &quot;type&quot;: &quot;alicloud_instance&quot;,
            ///             &quot;name&quot;: &quot;uuid_ae98dda8_xxxxxx&quot;,
            ///             &quot;providerName&quot;: &quot;registry.terraform.io/aliyun/alicloud&quot;,
            ///             &quot;change&quot;: {
            ///                 &quot;actions&quot;: [
            ///                     &quot;delete&quot;
            ///                 ],
            ///                 &quot;before&quot;: Object{...},
            ///                 &quot;after_unknown&quot;: {
            ///                 },
            ///                 &quot;before_sensitive&quot;: Object{...},
            ///                 &quot;after_sensitive&quot;: false
            ///             },
            ///             &quot;cloudSpecResourceCode&quot;: &quot;ACS::ECS::Instance&quot;
            ///         }
            ///     ],
            ///     &quot;configuration&quot;: Object{...}
            /// }</para>
            /// </summary>
            [NameInMap("outputJsonPlan")]
            [Validation(Required=false)]
            public object OutputJsonPlan { get; set; }

            /// <summary>
            /// <para>The collection of parameters.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: the initial status after the job is created.</description></item>
            /// <item><description>PlanQueued: the job is queued because no available worker is ready after the job is created.</description></item>
            /// <item><description>Planning: the resource job is in the Plan phase.</description></item>
            /// <item><description>ConfigProactiveInProgress: compliance pre-check is in progress. The compliance pre-check feature must be enabled for the account.</description></item>
            /// <item><description>ConfigProactiveSuccess: compliance pre-check succeeded. The compliance pre-check feature must be enabled for the account.</description></item>
            /// <item><description>Planned: the resource job has completed the Plan phase.</description></item>
            /// <item><description>PlannedAndFinished: no diff is found after the Plan phase is completed. This is a final status.</description></item>
            /// <item><description>Confirmed: the resource job is waiting for confirmation after the Plan phase is completed.</description></item>
            /// <item><description>ApplyQueued: the job is queued because no available worker is ready during execution.</description></item>
            /// <item><description>Applying: the resource job is in the Apply phase.</description></item>
            /// <item><description>Applied: the resource job has completed the Apply phase. This is a final status.</description></item>
            /// <item><description>Errored: the job execution encountered an error. This is a final status.</description></item>
            /// <item><description>Canceled: the job execution was canceled. This is a final status.</description></item>
            /// <item><description>Discarded: the plan of the resource job was discarded. This is a final status.</description></item>
            /// <item><description>ConfigProactiveFailure: compliance pre-check failed. The compliance pre-check feature must be enabled for the account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Errored</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The job status details.</para>
            /// </summary>
            [NameInMap("statusDetail")]
            [Validation(Required=false)]
            public Dictionary<string, JobStatusDetailValue> StatusDetail { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-3b6cb9fa4751a1b9b5f22cbcf4e</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Task: regular task (default)</description></item>
            /// <item><description>SceneTestingTask: scenario-based testing task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SceneTestingTask</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The Terraform provider version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.230.0</para>
            /// </summary>
            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1435C78A-AED9-53D6-B7A6-E2661D29B1FA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
