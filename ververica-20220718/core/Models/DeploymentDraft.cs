// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeploymentDraft : TeaModel {
        [NameInMap("artifact")]
        [Validation(Required=false)]
        public Artifact Artifact { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        [NameInMap("deploymentDraftId")]
        [Validation(Required=false)]
        public string DeploymentDraftId { get; set; }

        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        [NameInMap("lock")]
        [Validation(Required=false)]
        public Lock Lock { get; set; }

        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public long? ModifiedAt { get; set; }

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

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        [NameInMap("referencedDeploymentId")]
        [Validation(Required=false)]
        public string ReferencedDeploymentId { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
