// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeploymentDraft : TeaModel {
        /// <summary>
        /// <para>The artifact. Supported types include SQLSCRIPT and CDCYAML.</para>
        /// </summary>
        [NameInMap("artifact")]
        [Validation(Required=false)]
        public Artifact Artifact { get; set; }

        /// <summary>
        /// <para>Output only. The creation time, represented as a Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723537978</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>Output only. The ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>Output only. The name of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>The deployment draft ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-00000012****</para>
        /// </summary>
        [NameInMap("deploymentDraftId")]
        [Validation(Required=false)]
        public string DeploymentDraftId { get; set; }

        /// <summary>
        /// <para>The engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vvr-6.0.7-flink-1.15</para>
        /// </summary>
        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The execution mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STREAMING</para>
        /// </summary>
        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>Key-value pairs to apply as labels.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <para>The local variables.</para>
        /// </summary>
        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        /// <summary>
        /// <para>The deployment draft lock.</para>
        /// </summary>
        [NameInMap("lock")]
        [Validation(Required=false)]
        public Lock Lock { get; set; }

        /// <summary>
        /// <para>Output only. The modification time, represented as a Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723537978</para>
        /// </summary>
        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public long? ModifiedAt { get; set; }

        /// <summary>
        /// <para>Output only. The ID of the modifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>Output only. The name of the modifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        /// <summary>
        /// <para>The deployment draft name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-draft</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The parent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-00000013****</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The referenced deployment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-0000012312****</para>
        /// </summary>
        [NameInMap("referencedDeploymentId")]
        [Validation(Required=false)]
        public string ReferencedDeploymentId { get; set; }

        /// <summary>
        /// <para>The workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
