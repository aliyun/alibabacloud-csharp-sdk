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

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        [NameInMap("deploymentHasChanged")]
        [Validation(Required=false)]
        public bool? DeploymentHasChanged { get; set; }

        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("deploymentTarget")]
        [Validation(Required=false)]
        public BriefDeploymentTarget DeploymentTarget { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        [NameInMap("flinkConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlinkConf { get; set; }

        [NameInMap("jobSummary")]
        [Validation(Required=false)]
        public JobSummary JobSummary { get; set; }

        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        [NameInMap("logging")]
        [Validation(Required=false)]
        public Logging Logging { get; set; }

        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public string ModifiedAt { get; set; }

        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("streamingResourceSetting")]
        [Validation(Required=false)]
        public StreamingResourceSetting StreamingResourceSetting { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
