// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Task : TeaModel {
        [NameInMap("archives")]
        [Validation(Required=false)]
        public List<string> Archives { get; set; }

        [NameInMap("artifactUrl")]
        [Validation(Required=false)]
        public string ArtifactUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("categoryBizId")]
        [Validation(Required=false)]
        public string CategoryBizId { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public long? Creator { get; set; }

        [NameInMap("defaultCatalogId")]
        [Validation(Required=false)]
        public string DefaultCatalogId { get; set; }

        [NameInMap("defaultDatabase")]
        [Validation(Required=false)]
        public string DefaultDatabase { get; set; }

        [NameInMap("defaultResourceQueueId")]
        [Validation(Required=false)]
        public string DefaultResourceQueueId { get; set; }

        [NameInMap("defaultSqlComputeId")]
        [Validation(Required=false)]
        public string DefaultSqlComputeId { get; set; }

        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("extraArtifactIds")]
        [Validation(Required=false)]
        public List<string> ExtraArtifactIds { get; set; }

        [NameInMap("extraSparkSubmitParams")]
        [Validation(Required=false)]
        public string ExtraSparkSubmitParams { get; set; }

        [NameInMap("files")]
        [Validation(Required=false)]
        public List<string> Files { get; set; }

        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("hasChanged")]
        [Validation(Required=false)]
        public bool? HasChanged { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasCommited")]
        [Validation(Required=false)]
        public bool? HasCommited { get; set; }

        [NameInMap("isStreaming")]
        [Validation(Required=false)]
        public bool? IsStreaming { get; set; }

        [NameInMap("jars")]
        [Validation(Required=false)]
        public List<string> Jars { get; set; }

        [NameInMap("lastRunResourceQueueId")]
        [Validation(Required=false)]
        public string LastRunResourceQueueId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public long? Modifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("pyFiles")]
        [Validation(Required=false)]
        public List<string> PyFiles { get; set; }

        [NameInMap("sparkArgs")]
        [Validation(Required=false)]
        public string SparkArgs { get; set; }

        [NameInMap("sparkConf")]
        [Validation(Required=false)]
        public List<SparkConf> SparkConf { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sparkDriverCores")]
        [Validation(Required=false)]
        public int? SparkDriverCores { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sparkDriverMemory")]
        [Validation(Required=false)]
        public long? SparkDriverMemory { get; set; }

        [NameInMap("sparkEntrypoint")]
        [Validation(Required=false)]
        public string SparkEntrypoint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sparkExecutorCores")]
        [Validation(Required=false)]
        public int? SparkExecutorCores { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sparkExecutorMemory")]
        [Validation(Required=false)]
        public long? SparkExecutorMemory { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sparkLogLevel")]
        [Validation(Required=false)]
        public string SparkLogLevel { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sparkLogPath")]
        [Validation(Required=false)]
        public string SparkLogPath { get; set; }

        [NameInMap("sparkSubmitClause")]
        [Validation(Required=false)]
        public string SparkSubmitClause { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sparkVersion")]
        [Validation(Required=false)]
        public string SparkVersion { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
