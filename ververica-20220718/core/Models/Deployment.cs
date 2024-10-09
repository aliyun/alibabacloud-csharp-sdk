// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Deployment : TeaModel {
        [NameInMap("artifact")]
        [Validation(Required=false)]
        public Artifact Artifact { get; set; }

        [NameInMap("batchResourceSetting")]
        [Validation(Required=false)]
        public BatchResourceSetting BatchResourceSetting { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("deploymentHasChanged")]
        [Validation(Required=false)]
        public bool? DeploymentHasChanged { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("deploymentTarget")]
        [Validation(Required=false)]
        public BriefDeploymentTarget DeploymentTarget { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>this is a deployment description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vvr-6.0.0-flink-1.15</para>
        /// </summary>
        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>STREAMING | BATCH</para>
        /// </summary>
        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;taskmanager.numberOfTaskSlots&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("flinkConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlinkConf { get; set; }

        [NameInMap("jobSummary")]
        [Validation(Required=false)]
        public JobSummary JobSummary { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        [NameInMap("logging")]
        [Validation(Required=false)]
        public Logging Logging { get; set; }

        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>deploymentName</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
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

        [NameInMap("streamingResourceSetting")]
        [Validation(Required=false)]
        public StreamingResourceSetting StreamingResourceSetting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
