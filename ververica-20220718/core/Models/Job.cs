// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Job : TeaModel {
        /// <summary>
        /// <para>The content template of the job.</para>
        /// </summary>
        [NameInMap("artifact")]
        [Validation(Required=false)]
        public Artifact Artifact { get; set; }

        /// <summary>
        /// <para>The resource configuration of the job in batch mode.</para>
        /// </summary>
        [NameInMap("batchResourceSetting")]
        [Validation(Required=false)]
        public BatchResourceSetting BatchResourceSetting { get; set; }

        /// <summary>
        /// <para>The time when the job was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714058507</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the account that is used to create the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The name of the account that is used to create the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>The deployment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>354dde66-a3ae-463e-967a-0b4107fd****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <para>The name of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flinktest</para>
        /// </summary>
        [NameInMap("deploymentName")]
        [Validation(Required=false)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// <para>The end time of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660277235</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The engine version of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vvr-4.0.14-flink-1.13</para>
        /// </summary>
        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The execution mode of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>STREAM</description></item>
        /// <item><description>BATCH</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BATCH</para>
        /// </summary>
        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>The configuration of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{execution.checkpointing.unaligned: false}</para>
        /// </summary>
        [NameInMap("flinkConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlinkConf { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>354dde66-a3ae-463e-967a-0b4107fd****</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The variables.</para>
        /// </summary>
        [NameInMap("localVariables")]
        [Validation(Required=false)]
        public List<LocalVariable> LocalVariables { get; set; }

        /// <summary>
        /// <para>The logging configuration of the job.</para>
        /// </summary>
        [NameInMap("logging")]
        [Validation(Required=false)]
        public Logging Logging { get; set; }

        /// <summary>
        /// <para>The resource information of the job.</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public JobMetric Metric { get; set; }

        /// <summary>
        /// <para>The time when the job was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714058800</para>
        /// </summary>
        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// <para>The ID of the account that is used to modify the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27846363877456****</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>The name of the account that is used to modify the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****@streamcompute.onaliyun.com</para>
        /// </summary>
        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespacetest</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The startup strategy of the job.</para>
        /// </summary>
        [NameInMap("restoreStrategy")]
        [Validation(Required=false)]
        public DeploymentRestoreStrategy RestoreStrategy { get; set; }

        /// <summary>
        /// <para>If the job runs in a session cluster, the value of this parameter is the name of the session cluster. Otherwise, the value of this parameter is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>preview</para>
        /// </summary>
        [NameInMap("sessionClusterName")]
        [Validation(Required=false)]
        public string SessionClusterName { get; set; }

        /// <summary>
        /// <para>The start time of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660190835</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status of the job.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public JobStatus Status { get; set; }

        /// <summary>
        /// <para>The resource configuration of the job in streaming mode.</para>
        /// </summary>
        [NameInMap("streamingResourceSetting")]
        [Validation(Required=false)]
        public StreamingResourceSetting StreamingResourceSetting { get; set; }

        /// <summary>
        /// <para>The Flink configuration.</para>
        /// </summary>
        [NameInMap("userFlinkConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> UserFlinkConf { get; set; }

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
