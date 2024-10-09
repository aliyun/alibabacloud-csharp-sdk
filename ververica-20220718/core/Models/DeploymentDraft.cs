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
        /// <para>00000000-0000-0000-0000-00000012****</para>
        /// </summary>
        [NameInMap("deploymentDraftId")]
        [Validation(Required=false)]
        public string DeploymentDraftId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vvr-6.0.7-flink-1.15</para>
        /// </summary>
        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>STREAMING</para>
        /// </summary>
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
        /// <para>test-draft</para>
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
        /// <para>00000000-0000-0000-0000-00000013****</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-0000012312****</para>
        /// </summary>
        [NameInMap("referencedDeploymentId")]
        [Validation(Required=false)]
        public string ReferencedDeploymentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
