// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpgradeLindormInstanceRequest : TeaModel {
        [NameInMap("ClusterStorage")]
        [Validation(Required=false)]
        public int? ClusterStorage { get; set; }

        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        [NameInMap("FilestoreNum")]
        [Validation(Required=false)]
        public int? FilestoreNum { get; set; }

        [NameInMap("FilestoreSpec")]
        [Validation(Required=false)]
        public string FilestoreSpec { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LindormNum")]
        [Validation(Required=false)]
        public int? LindormNum { get; set; }

        [NameInMap("LindormSpec")]
        [Validation(Required=false)]
        public string LindormSpec { get; set; }

        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        [NameInMap("LtsCoreNum")]
        [Validation(Required=false)]
        public int? LtsCoreNum { get; set; }

        [NameInMap("LtsCoreSpec")]
        [Validation(Required=false)]
        public string LtsCoreSpec { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PhoenixCoreNum")]
        [Validation(Required=false)]
        public int? PhoenixCoreNum { get; set; }

        [NameInMap("PhoenixCoreSpec")]
        [Validation(Required=false)]
        public string PhoenixCoreSpec { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("SolrNum")]
        [Validation(Required=false)]
        public int? SolrNum { get; set; }

        [NameInMap("SolrSpec")]
        [Validation(Required=false)]
        public string SolrSpec { get; set; }

        /// <summary>
        /// 变配后实例的流引擎节点数量，取值：**0**~**90**。
        /// </summary>
        [NameInMap("StreamNum")]
        [Validation(Required=false)]
        public int? StreamNum { get; set; }

        /// <summary>
        /// 变配后实例的流引擎节点规格，取值：
        /// 
        /// - **lindorm.c.2xlarge**：表示8核16GB（独享规格）。
        /// - **lindorm.c.4xlarge**：表示16核32GB（独享规格）。
        /// - **lindorm.c.8xlarge**：表示32核64GB（独享规格）。
        /// </summary>
        [NameInMap("StreamSpec")]
        [Validation(Required=false)]
        public string StreamSpec { get; set; }

        [NameInMap("TsdbNum")]
        [Validation(Required=false)]
        public int? TsdbNum { get; set; }

        [NameInMap("TsdbSpec")]
        [Validation(Required=false)]
        public string TsdbSpec { get; set; }

        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
