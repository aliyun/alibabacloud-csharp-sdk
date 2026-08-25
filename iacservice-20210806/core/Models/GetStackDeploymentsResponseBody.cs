// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetStackDeploymentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The deployment results of the stack.</para>
        /// </summary>
        [NameInMap("deployments")]
        [Validation(Required=false)]
        public List<GetStackDeploymentsResponseBodyDeployments> Deployments { get; set; }
        public class GetStackDeploymentsResponseBodyDeployments : TeaModel {
            /// <summary>
            /// <para>The configuration item.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetStackDeploymentsResponseBodyDeploymentsConfig Config { get; set; }
            public class GetStackDeploymentsResponseBodyDeploymentsConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to automatically execute the task. Default value: false. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: No.</description></item>
                /// <item><description><b>true</b>: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("autoApply")]
                [Validation(Required=false)]
                public bool? AutoApply { get; set; }

                /// <summary>
                /// <para>Indicates whether this is a destroy job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isDestroy")]
                [Validation(Required=false)]
                public bool? IsDestroy { get; set; }

            }

            /// <summary>
            /// <para>The configuration version, such as v1. The initial value is v1. The version number increments each time the stack is updated or refreshed and the configuration changes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("configVersion")]
            [Validation(Required=false)]
            public string ConfigVersion { get; set; }

            /// <summary>
            /// <para>The creation time in UTC, in the format of YYYY-MM-DDTHH:mm:ssZ (ISO 8601).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-01T12:10:18Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The deployment name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("deploymentName")]
            [Validation(Required=false)]
            public string DeploymentName { get; set; }

            /// <summary>
            /// <para>The deployment number. The deployment number for each stack starts from 1 and increments each time a deployment is successfully triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("deploymentNo")]
            [Validation(Required=false)]
            public string DeploymentNo { get; set; }

            /// <summary>
            /// <para>Deprecated field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("deploymentVersion")]
            [Validation(Required=false)]
            public string DeploymentVersion { get; set; }

            /// <summary>
            /// <para>The execution duration, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38000</para>
            /// </summary>
            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The execution type.</para>
            /// <para>Manual: Manual execution (default).</para>
            /// <para>Auto: Automatic execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("executeType")]
            [Validation(Required=false)]
            public string ExecuteType { get; set; }

            /// <summary>
            /// <para>The failure reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\n Error: Invalid value for input variable\n \n   on main.tf line 17, in module \&quot;alb\&quot;:\n   17:   log_project           = var.log_project.project_name\n \n The given value is not suitable for module.alb.var.log_project declared at\n modules/alb/main.tf:34,1-23: string required.\n╵\n</para>
            /// </summary>
            [NameInMap("failedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-as154vldqt46mv0ixxxxx</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>OSS object key prefix for deployment logs</para>
            /// </summary>
            [NameInMap("logOutputPath")]
            [Validation(Required=false)]
            public string LogOutputPath { get; set; }

            /// <summary>
            /// <para>The outputs.</para>
            /// </summary>
            [NameInMap("outputs")]
            [Validation(Required=false)]
            public List<GetStackDeploymentsResponseBodyDeploymentsOutputs> Outputs { get; set; }
            public class GetStackDeploymentsResponseBodyDeploymentsOutputs : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the SLS log project</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The expression that can reference component outputs, in the format: component.{component name}.{component output name}.</para>
                /// 
                /// <b>Example:</b>
                /// <para>component.sls.project_name</para>
                /// </summary>
                [NameInMap("expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parameter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The actual value after the deployment is completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>log-project-xxxx</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The parameter set content.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetStackDeploymentsResponseBodyDeploymentsParameters> Parameters { get; set; }
            public class GetStackDeploymentsResponseBodyDeploymentsParameters : TeaModel {
                /// <summary>
                /// <para>The default value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("defaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>region of the resource</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>region</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the parameter is sensitive. Sensitive parameter values are not visible in the console or API. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Sensitive.</description></item>
                /// <item><description>false: Not sensitive.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("sensitive")]
                [Validation(Required=false)]
                public bool? Sensitive { get; set; }

                /// <summary>
                /// <para>The parameter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-6</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The state file output results.</para>
            /// </summary>
            [NameInMap("planOutputs")]
            [Validation(Required=false)]
            public List<GetStackDeploymentsResponseBodyDeploymentsPlanOutputs> PlanOutputs { get; set; }
            public class GetStackDeploymentsResponseBodyDeploymentsPlanOutputs : TeaModel {
                /// <summary>
                /// <para>The change type of the component. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>create: All resource changes in the component are creations.</description></item>
                /// <item><description>delete: All resource changes in the component are deletions.</description></item>
                /// <item><description>read: All resource changes in the component are reads.</description></item>
                /// <item><description>update: Resource changes in the component include two or more types among creation, deletion, and read.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>update</para>
                /// </summary>
                [NameInMap("moduleAction")]
                [Validation(Required=false)]
                public string ModuleAction { get; set; }

                /// <summary>
                /// <para>The number of resources to be created, updated, and destroyed in this deployment.</para>
                /// </summary>
                [NameInMap("moduleActionDetail")]
                [Validation(Required=false)]
                public GetStackDeploymentsResponseBodyDeploymentsPlanOutputsModuleActionDetail ModuleActionDetail { get; set; }
                public class GetStackDeploymentsResponseBodyDeploymentsPlanOutputsModuleActionDetail : TeaModel {
                    /// <summary>
                    /// <para>The number of resources to be created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("add")]
                    [Validation(Required=false)]
                    public int? Add { get; set; }

                    /// <summary>
                    /// <para>The number of resources to be changed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("change")]
                    [Validation(Required=false)]
                    public int? Change { get; set; }

                    /// <summary>
                    /// <para>The number of resources to be destroyed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("destroy")]
                    [Validation(Required=false)]
                    public int? Destroy { get; set; }

                }

                /// <summary>
                /// <para>The resource change information.</para>
                /// </summary>
                [NameInMap("resourceChanges")]
                [Validation(Required=false)]
                public List<GetStackDeploymentsResponseBodyDeploymentsPlanOutputsResourceChanges> ResourceChanges { get; set; }
                public class GetStackDeploymentsResponseBodyDeploymentsPlanOutputsResourceChanges : TeaModel {
                    /// <summary>
                    /// <para>The diff information of the resource change.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>~ resource \&quot;alicloud_log_store\&quot; \&quot;default\&quot; {\n        id                    = \&quot;alb-log-project-v1-ph-xxxxx:alb-log-store-ph\&quot;\n      ~ max_split_shard_count = 64 -&gt; 32\n        name                  = \&quot;alb-log-store-ph\&quot;\n\n        # (13 unchanged attributes hidden)\n    }</para>
                    /// </summary>
                    [NameInMap("change")]
                    [Validation(Required=false)]
                    public string Change { get; set; }

                    /// <summary>
                    /// <para>The types of resource change actions included in this resource change.</para>
                    /// </summary>
                    [NameInMap("resourceActions")]
                    [Validation(Required=false)]
                    public List<string> ResourceActions { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alicloud_log_store.default</para>
                    /// </summary>
                    [NameInMap("resourceIdentifier")]
                    [Validation(Required=false)]
                    public string ResourceIdentifier { get; set; }

                }

                /// <summary>
                /// <para>The component name of the stack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls</para>
                /// </summary>
                [NameInMap("stackModuleName")]
                [Validation(Required=false)]
                public string StackModuleName { get; set; }

            }

            /// <summary>
            /// <para>The deployment status.</para>
            /// <table>
            /// <thead>
            /// <tr>
            /// <th>Name</th>
            /// <th>Description</th>
            /// </tr>
            /// </thead>
            /// <tbody><tr>
            /// <td>Pending</td>
            /// <td>The initial status after the deployment is created.</td>
            /// </tr>
            /// <tr>
            /// <td>PriorityQueued</td>
            /// <td>Priority queuing in progress.</td>
            /// </tr>
            /// <tr>
            /// <td>PlanQueued</td>
            /// <td>The deployment is queuing because no workflow is available after creation.</td>
            /// </tr>
            /// <tr>
            /// <td>ApplyQueued</td>
            /// <td>The deployment is queuing because no workflow is available during execution.</td>
            /// </tr>
            /// <tr>
            /// <td>Planning</td>
            /// <td>The resource deployment is in the Plan phase.</td>
            /// </tr>
            /// <tr>
            /// <td>Planned</td>
            /// <td>The resource deployment has completed the Plan phase.</td>
            /// </tr>
            /// <tr>
            /// <td>ConfigProactiveInProgress</td>
            /// <td>Compliance pre-check in progress.</td>
            /// </tr>
            /// <tr>
            /// <td>ConfigProactiveSuccess</td>
            /// <td>Compliance pre-check succeeded.</td>
            /// </tr>
            /// <tr>
            /// <td>DetectInProgress</td>
            /// <td>Drift detection in progress.</td>
            /// </tr>
            /// <tr>
            /// <td>ImportQueued</td>
            /// <td>The deployment is queuing because no workflow is available during Import execution.</td>
            /// </tr>
            /// <tr>
            /// <td>Importing</td>
            /// <td>The resource deployment is in the Import phase.</td>
            /// </tr>
            /// <tr>
            /// <td>Imported</td>
            /// <td>The resource deployment has completed the Import phase.</td>
            /// </tr>
            /// <tr>
            /// <td>StateQueued</td>
            /// <td>The deployment is queuing because no workflow is available during state command execution.</td>
            /// </tr>
            /// <tr>
            /// <td>Stating</td>
            /// <td>The resource deployment is executing the state command.</td>
            /// </tr>
            /// <tr>
            /// <td>Stated</td>
            /// <td>The resource deployment has completed the state command execution.</td>
            /// </tr>
            /// <tr>
            /// <td>Confirmed</td>
            /// <td>The resource deployment has been confirmed after the Plan phase.</td>
            /// </tr>
            /// <tr>
            /// <td>PlannedAndFinished</td>
            /// <td>No diff was found after the Plan phase. The deployment is in a final status.</td>
            /// </tr>
            /// <tr>
            /// <td>Applying</td>
            /// <td>The resource deployment is in the Apply phase.</td>
            /// </tr>
            /// <tr>
            /// <td>Applied</td>
            /// <td>The resource deployment has completed the Apply phase.</td>
            /// </tr>
            /// <tr>
            /// <td>Discarded</td>
            /// <td>The resource deployment has been discarded and is in a final status.</td>
            /// </tr>
            /// <tr>
            /// <td>Errored</td>
            /// <td>The deployment execution encountered an error and is in a final status.</td>
            /// </tr>
            /// <tr>
            /// <td>ConfigProactiveFailure</td>
            /// <td>Compliance pre-check failed.</td>
            /// </tr>
            /// <tr>
            /// <td>Canceled</td>
            /// <td>The deployment execution has been canceled and is in a final status.</td>
            /// </tr>
            /// </tbody></table>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-as1d4vld8ogb2l32xxxxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF72A6FB-B071-5F2E-A036-9D62545B962C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
