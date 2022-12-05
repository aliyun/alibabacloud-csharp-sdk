// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        [NameInMap("BlktagTotal")]
        [Validation(Required=false)]
        public long? BlktagTotal { get; set; }

        [NameInMap("BlktagUsed")]
        [Validation(Required=false)]
        public long? BlktagUsed { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeDBClusterAttributeResponseBodyDBNodes : TeaModel {
            [NameInMap("AddedCpuCores")]
            [Validation(Required=false)]
            public string AddedCpuCores { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            [NameInMap("DBNodeRole")]
            [Validation(Required=false)]
            public string DBNodeRole { get; set; }

            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            [NameInMap("FailoverPriority")]
            [Validation(Required=false)]
            public int? FailoverPriority { get; set; }

            [NameInMap("HotReplicaMode")]
            [Validation(Required=false)]
            public string HotReplicaMode { get; set; }

            [NameInMap("ImciSwitch")]
            [Validation(Required=false)]
            public string ImciSwitch { get; set; }

            [NameInMap("MasterId")]
            [Validation(Required=false)]
            public string MasterId { get; set; }

            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            [NameInMap("MaxIOPS")]
            [Validation(Required=false)]
            public int? MaxIOPS { get; set; }

            [NameInMap("SccMode")]
            [Validation(Required=false)]
            public string SccMode { get; set; }

            [NameInMap("ServerWeight")]
            [Validation(Required=false)]
            public string ServerWeight { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        [NameInMap("DataLevel1BackupChainSize")]
        [Validation(Required=false)]
        public long? DataLevel1BackupChainSize { get; set; }

        [NameInMap("DeletionLock")]
        [Validation(Required=false)]
        public int? DeletionLock { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        [NameInMap("InodeTotal")]
        [Validation(Required=false)]
        public long? InodeTotal { get; set; }

        [NameInMap("InodeUsed")]
        [Validation(Required=false)]
        public long? InodeUsed { get; set; }

        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        [NameInMap("IsProxyLatestVersion")]
        [Validation(Required=false)]
        public bool? IsProxyLatestVersion { get; set; }

        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        [NameInMap("MaintainTime")]
        [Validation(Required=false)]
        public string MaintainTime { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("ProxyCpuCores")]
        [Validation(Required=false)]
        public string ProxyCpuCores { get; set; }

        [NameInMap("ProxyStandardCpuCores")]
        [Validation(Required=false)]
        public string ProxyStandardCpuCores { get; set; }

        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public string ProxyStatus { get; set; }

        [NameInMap("ProxyType")]
        [Validation(Required=false)]
        public string ProxyType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        [NameInMap("StorageMax")]
        [Validation(Required=false)]
        public long? StorageMax { get; set; }

        [NameInMap("StoragePayType")]
        [Validation(Required=false)]
        public string StoragePayType { get; set; }

        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public long? StorageUsed { get; set; }

        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAttributeResponseBodyTags> Tags { get; set; }
        public class DescribeDBClusterAttributeResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}
