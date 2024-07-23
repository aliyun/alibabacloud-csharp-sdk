// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Job : TeaModel {
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
        /// <para>354dde66-a3ae-463e-967a-0b4107fd****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>flinktest</para>
        /// </summary>
        [NameInMap("deploymentName")]
        [Validation(Required=false)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1660277235</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vvr-4.0.14-flink-1.13</para>
        /// </summary>
        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BATCH</para>
        /// </summary>
        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        [NameInMap("flinkConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlinkConf { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>354dde66-a3ae-463e-967a-0b4107fd****</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        [NameInMap("logging")]
        [Validation(Required=false)]
        public Logging Logging { get; set; }

        [NameInMap("metric")]
        [Validation(Required=false)]
        public JobMetric Metric { get; set; }

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
        /// <para>namespacetest</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("restoreStrategy")]
        [Validation(Required=false)]
        public DeploymentRestoreStrategy RestoreStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>preview</para>
        /// </summary>
        [NameInMap("sessionClusterName")]
        [Validation(Required=false)]
        public string SessionClusterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1660190835</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public JobStatus Status { get; set; }

        [NameInMap("streamingResourceSetting")]
        [Validation(Required=false)]
        public StreamingResourceSetting StreamingResourceSetting { get; set; }

        [NameInMap("userFlinkConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> UserFlinkConf { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
