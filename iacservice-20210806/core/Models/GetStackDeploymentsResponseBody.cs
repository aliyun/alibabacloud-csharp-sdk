// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetStackDeploymentsResponseBody : TeaModel {
        [NameInMap("deployments")]
        [Validation(Required=false)]
        public List<GetStackDeploymentsResponseBodyDeployments> Deployments { get; set; }
        public class GetStackDeploymentsResponseBodyDeployments : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetStackDeploymentsResponseBodyDeploymentsConfig Config { get; set; }
            public class GetStackDeploymentsResponseBodyDeploymentsConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("autoApply")]
                [Validation(Required=false)]
                public bool? AutoApply { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isDestroy")]
                [Validation(Required=false)]
                public bool? IsDestroy { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("configVersion")]
            [Validation(Required=false)]
            public string ConfigVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-01T12:10:18Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("deploymentName")]
            [Validation(Required=false)]
            public string DeploymentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("deploymentNo")]
            [Validation(Required=false)]
            public string DeploymentNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("deploymentVersion")]
            [Validation(Required=false)]
            public string DeploymentVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>38000</para>
            /// </summary>
            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("executeType")]
            [Validation(Required=false)]
            public string ExecuteType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>\n Error: Invalid value for input variable\n \n   on main.tf line 17, in module \&quot;alb\&quot;:\n   17:   log_project           = var.log_project.project_name\n \n The given value is not suitable for module.alb.var.log_project declared at\n modules/alb/main.tf:34,1-23: string required.\n╵\n</para>
            /// </summary>
            [NameInMap("failedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-as154vldqt46mv0ixxxxx</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("outputs")]
            [Validation(Required=false)]
            public List<GetStackDeploymentsResponseBodyDeploymentsOutputs> Outputs { get; set; }
            public class GetStackDeploymentsResponseBodyDeploymentsOutputs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>The name of the SLS log project</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>component.sls.project_name</para>
                /// </summary>
                [NameInMap("expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>project_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>log-project-xxxx</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetStackDeploymentsResponseBodyDeploymentsParameters> Parameters { get; set; }
            public class GetStackDeploymentsResponseBodyDeploymentsParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("defaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>region of the resource</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>region</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ap-southeast-6</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("planOutputs")]
            [Validation(Required=false)]
            public List<GetStackDeploymentsResponseBodyDeploymentsPlanOutputs> PlanOutputs { get; set; }
            public class GetStackDeploymentsResponseBodyDeploymentsPlanOutputs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>update</para>
                /// </summary>
                [NameInMap("moduleAction")]
                [Validation(Required=false)]
                public string ModuleAction { get; set; }

                [NameInMap("moduleActionDetail")]
                [Validation(Required=false)]
                public GetStackDeploymentsResponseBodyDeploymentsPlanOutputsModuleActionDetail ModuleActionDetail { get; set; }
                public class GetStackDeploymentsResponseBodyDeploymentsPlanOutputsModuleActionDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("add")]
                    [Validation(Required=false)]
                    public int? Add { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("change")]
                    [Validation(Required=false)]
                    public int? Change { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("destroy")]
                    [Validation(Required=false)]
                    public int? Destroy { get; set; }

                }

                [NameInMap("resourceChanges")]
                [Validation(Required=false)]
                public List<GetStackDeploymentsResponseBodyDeploymentsPlanOutputsResourceChanges> ResourceChanges { get; set; }
                public class GetStackDeploymentsResponseBodyDeploymentsPlanOutputsResourceChanges : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>~ resource \&quot;alicloud_log_store\&quot; \&quot;default\&quot; {\n        id                    = \&quot;alb-log-project-v1-ph-xxxxx:alb-log-store-ph\&quot;\n      ~ max_split_shard_count = 64 -&gt; 32\n        name                  = \&quot;alb-log-store-ph\&quot;\n\n        # (13 unchanged attributes hidden)\n    }</para>
                    /// </summary>
                    [NameInMap("change")]
                    [Validation(Required=false)]
                    public string Change { get; set; }

                    [NameInMap("resourceActions")]
                    [Validation(Required=false)]
                    public List<string> ResourceActions { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>alicloud_log_store.default</para>
                    /// </summary>
                    [NameInMap("resourceIdentifier")]
                    [Validation(Required=false)]
                    public string ResourceIdentifier { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sls</para>
                /// </summary>
                [NameInMap("stackModuleName")]
                [Validation(Required=false)]
                public string StackModuleName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-as1d4vld8ogb2l32xxxxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF72A6FB-B071-5F2E-A036-9D62545B962C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
