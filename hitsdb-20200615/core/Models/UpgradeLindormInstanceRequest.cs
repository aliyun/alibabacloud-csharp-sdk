// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpgradeLindormInstanceRequest : TeaModel {
        /// <summary>
        /// The storage capacity of the instance after it is upgraded. Unit: GB. Valid values: **480** to **1017600**.
        /// </summary>
        [NameInMap("ClusterStorage")]
        [Validation(Required=false)]
        public int? ClusterStorage { get; set; }

        /// <summary>
        /// The cold storage capacity of the instance after it is upgraded. Unit: GB. Valid values: **800** to **1000000**.
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// The storage capacity of a single core node in the instance after the instance upgraded. This parameter is available only if the instance you want to upgrade is a multi-zone instance. Unit: GB. Valid values: 400 to 64000. **This parameter is optional**.
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// The number of LindormDFS nodes in the instance after the instance is upgraded. Valid values: integers from **0** to **60**.
        /// </summary>
        [NameInMap("FilestoreNum")]
        [Validation(Required=false)]
        public int? FilestoreNum { get; set; }

        /// <summary>
        /// The specification of LindormDFS nodes in the instance after the instance is upgraded. Valid values:
        /// 
        /// *   **lindorm.g.xlarge**: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.g.2xlarge**: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.g.4xlarge**: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.
        /// *   **lindorm.g.8xlarge**: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.
        /// </summary>
        [NameInMap("FilestoreSpec")]
        [Validation(Required=false)]
        public string FilestoreSpec { get; set; }

        /// <summary>
        /// The ID of the instance that you want to upgrade, scale up, or enable cold storage. You can call the [GetLindormInstanceList](~~426069~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The number of LindormTable nodes in the instance after the instance is upgraded. Valid values: integers from **0** to **90**.
        /// 
        /// > This parameter must be specified together with the LindormSpec parameter.
        /// </summary>
        [NameInMap("LindormNum")]
        [Validation(Required=false)]
        public int? LindormNum { get; set; }

        /// <summary>
        /// The specification of LindormTable nodes in the instance after the instance is upgraded. Valid values:
        /// 
        /// *   **lindorm.c.xlarge**: Each node has 4 dedicated CPU cores and 8 GB of dedicated memory.
        /// *   **lindorm.c.2xlarge**: Each node has 8 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.c.4xlarge**: Each node has 16 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.c.8xlarge**: Each node has 32 dedicated CPU cores and 64 GB of dedicated memory.
        /// </summary>
        [NameInMap("LindormSpec")]
        [Validation(Required=false)]
        public string LindormSpec { get; set; }

        /// <summary>
        /// The number of log nodes in the instance after the instance is upgraded. This parameter is available only if the instance you want to upgrade is a multi-zone instance. **This parameter is optional**.
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// The storage capacity of a single log node in the instance after the instance upgraded. This parameter is available only if the instance you want to upgrade is a multi-zone instance. **This parameter is optional**.
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// The specification of log nodes in the instance after the instance is upgraded. This parameter is available only if the instance you want to upgrade is a multi-zone instance. Valid values:
        /// 
        /// *   **lindorm.sn1.large**: Each node has 4 dedicated CPU cores and 8 GB of dedicated memory.
        /// *   **lindorm.sn1.2xlarge**: Each node has 8 dedicated CPU cores and 16 GB of dedicated memory.
        /// 
        /// **This parameter is optional**.
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// The number of LTS nodes in the instance after the instance is upgraded. Valid values: integers from **0** to **50**.
        /// </summary>
        [NameInMap("LtsCoreNum")]
        [Validation(Required=false)]
        public int? LtsCoreNum { get; set; }

        /// <summary>
        /// The specification of Lindorm Tunnel Service (LTS) nodes in the instance after the instance is upgraded. Valid values:
        /// 
        /// *   **lindorm.g.xlarge**: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.g.2xlarge**: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.
        /// </summary>
        [NameInMap("LtsCoreSpec")]
        [Validation(Required=false)]
        public string LtsCoreSpec { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region in which the instance that you want to upgrade, scale up, or enable cold storage is located. You can call the [DescribeRegions](~~426062~~) operation to query the region ID.
        /// </summary>
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

        /// <summary>
        /// The number of LindormSearch nodes in the instance after the instance is upgraded. Valid values: integers from **0** to **60**.
        /// </summary>
        [NameInMap("SolrNum")]
        [Validation(Required=false)]
        public int? SolrNum { get; set; }

        /// <summary>
        /// The specification of LindormSearch nodes in the instance after the instance is upgraded. Valid values:
        /// 
        /// *   **lindorm.g.xlarge**: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.g.2xlarge**: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.g.4xlarge**: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.
        /// *   **lindorm.g.8xlarge**: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.
        /// </summary>
        [NameInMap("SolrSpec")]
        [Validation(Required=false)]
        public string SolrSpec { get; set; }

        /// <summary>
        /// The number of LindormStream nodes in the instance after the instance is upgraded. Valid values: integers from **0** to **60**.
        /// </summary>
        [NameInMap("StreamNum")]
        [Validation(Required=false)]
        public int? StreamNum { get; set; }

        /// <summary>
        /// The specification of LindormStream nodes in the instance after the instance is upgraded. Valid values:
        /// 
        /// *   **lindorm.g.xlarge**: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.g.2xlarge**: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.g.4xlarge**: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.
        /// *   **lindorm.g.8xlarge**: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.
        /// </summary>
        [NameInMap("StreamSpec")]
        [Validation(Required=false)]
        public string StreamSpec { get; set; }

        /// <summary>
        /// The number of LindormTSDB nodes in the instance after the instance is upgraded. Valid values: integers from **0** to **24**.
        /// </summary>
        [NameInMap("TsdbNum")]
        [Validation(Required=false)]
        public int? TsdbNum { get; set; }

        /// <summary>
        /// The specification of LindormTSDB nodes in the instance after the instance is upgraded. Valid values:
        /// 
        /// *   **lindorm.g.xlarge**: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.g.2xlarge**: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.g.4xlarge**: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.
        /// *   **lindorm.g.8xlarge**: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.
        /// </summary>
        [NameInMap("TsdbSpec")]
        [Validation(Required=false)]
        public string TsdbSpec { get; set; }

        /// <summary>
        /// The upgrade type of the operation. For more information about upgrade types, see the UpgradeType parameters section.
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

        /// <summary>
        /// The ID of the zone in which the instance that you want to upgrade, scale up, or enable cold storage is located. You can call the [GetLindormInstance](~~426067~~) operation to query the zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
