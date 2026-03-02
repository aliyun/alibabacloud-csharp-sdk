// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Deployment : TeaModel {
        /// <summary>
        /// <para>The parameters that are required for starting a deployment.</para>
        /// </summary>
        [NameInMap("artifact")]
        [Validation(Required=false)]
        public Artifact Artifact { get; set; }

        /// <summary>
        /// <para>The resource configuration of the batch deployment.</para>
        /// </summary>
        [NameInMap("batchResourceSetting")]
        [Validation(Required=false)]
        public BatchResourceSetting BatchResourceSetting { get; set; }

        /// <summary>
        /// <para>The time at which the deployment was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714058507</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the account that is used to create the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The name of the account that is used to create the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>Specifies whether the deployment is modified after the deployment is started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("deploymentHasChanged")]
        [Validation(Required=false)]
        public bool? DeploymentHasChanged { get; set; }

        /// <summary>
        /// <para>The ID of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-0000012312****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <para>The cluster on which the deployment is deployed.</para>
        /// </summary>
        [NameInMap("deploymentTarget")]
        [Validation(Required=false)]
        public BriefDeploymentTarget DeploymentTarget { get; set; }

        /// <summary>
        /// <para>The description of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a deployment description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The engine version of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vvr-6.0.0-flink-1.15</para>
        /// </summary>
        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The execution mode of the deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>STREAMING</description></item>
        /// <item><description>BATCH</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STREAMING</para>
        /// </summary>
        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>The Realtime Compute for Apache Flink configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;taskmanager.numberOfTaskSlots&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("flinkConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlinkConf { get; set; }

        /// <summary>
        /// <para>The summary of jobs in the deployment.</para>
        /// </summary>
        [NameInMap("jobSummary")]
        [Validation(Required=false)]
        public JobSummary JobSummary { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <para>The variables of the deployment.</para>
        /// </summary>
        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        /// <summary>
        /// <para>The logging configuration.</para>
        /// </summary>
        [NameInMap("logging")]
        [Validation(Required=false)]
        public Logging Logging { get; set; }

        /// <summary>
        /// <para>The time at which the deployment was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714058843</para>
        /// </summary>
        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// <para>The ID of the account that is used to modify the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>The name of the account that is used to modify the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        /// <summary>
        /// <para>The name of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deploymentName</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-000000000003</para>
        /// </summary>
        [NameInMap("referencedDeploymentDraftId")]
        [Validation(Required=false)]
        public string ReferencedDeploymentDraftId { get; set; }

        /// <summary>
        /// <para>The resource configuration of the streaming deployment.</para>
        /// </summary>
        [NameInMap("streamingResourceSetting")]
        [Validation(Required=false)]
        public StreamingResourceSetting StreamingResourceSetting { get; set; }

        /// <summary>
        /// <para>The workspace to which the deployment belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
