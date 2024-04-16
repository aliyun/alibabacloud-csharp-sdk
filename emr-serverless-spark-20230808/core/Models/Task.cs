// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Task : TeaModel {
        [NameInMap("artifactUrl")]
        [Validation(Required=false)]
        public string ArtifactUrl { get; set; }

        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("categoryBizId")]
        [Validation(Required=false)]
        public string CategoryBizId { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

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

        [NameInMap("extraArtifactIds")]
        [Validation(Required=false)]
        public List<string> ExtraArtifactIds { get; set; }

        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("hasChanged")]
        [Validation(Required=false)]
        public bool? HasChanged { get; set; }

        [NameInMap("hasCommited")]
        [Validation(Required=false)]
        public bool? HasCommited { get; set; }

        [NameInMap("lastRunResourceQueueId")]
        [Validation(Required=false)]
        public string LastRunResourceQueueId { get; set; }

        [NameInMap("modifier")]
        [Validation(Required=false)]
        public long? Modifier { get; set; }

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

        [NameInMap("sparkDriverCores")]
        [Validation(Required=false)]
        public int? SparkDriverCores { get; set; }

        [NameInMap("sparkDriverMemory")]
        [Validation(Required=false)]
        public long? SparkDriverMemory { get; set; }

        [NameInMap("sparkEntrypoint")]
        [Validation(Required=false)]
        public string SparkEntrypoint { get; set; }

        [NameInMap("sparkExecutorCores")]
        [Validation(Required=false)]
        public int? SparkExecutorCores { get; set; }

        [NameInMap("sparkExecutorMemory")]
        [Validation(Required=false)]
        public long? SparkExecutorMemory { get; set; }

        [NameInMap("sparkLogLevel")]
        [Validation(Required=false)]
        public string SparkLogLevel { get; set; }

        [NameInMap("sparkLogPath")]
        [Validation(Required=false)]
        public string SparkLogPath { get; set; }

        [NameInMap("sparkVersion")]
        [Validation(Required=false)]
        public string SparkVersion { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
