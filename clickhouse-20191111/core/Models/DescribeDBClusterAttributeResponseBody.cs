// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        [NameInMap("DBCluster")]
        [Validation(Required=false)]
        public DescribeDBClusterAttributeResponseBodyDBCluster DBCluster { get; set; }
        public class DescribeDBClusterAttributeResponseBodyDBCluster : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("AppointmentRestartTime")]
            [Validation(Required=false)]
            public string AppointmentRestartTime { get; set; }

            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            [NameInMap("ControlVersion")]
            [Validation(Required=false)]
            public string ControlVersion { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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

            [NameInMap("DBClusterType")]
            [Validation(Required=false)]
            public string DBClusterType { get; set; }

            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            [NameInMap("DBNodeCount")]
            [Validation(Required=false)]
            public long? DBNodeCount { get; set; }

            [NameInMap("DBNodeStorage")]
            [Validation(Required=false)]
            public long? DBNodeStorage { get; set; }

            [NameInMap("EncryptionKey")]
            [Validation(Required=false)]
            public string EncryptionKey { get; set; }

            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineLatestMinorVersion")]
            [Validation(Required=false)]
            public string EngineLatestMinorVersion { get; set; }

            [NameInMap("EngineMinorVersion")]
            [Validation(Required=false)]
            public string EngineMinorVersion { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("ExtStorageSize")]
            [Validation(Required=false)]
            public int? ExtStorageSize { get; set; }

            [NameInMap("ExtStorageType")]
            [Validation(Required=false)]
            public string ExtStorageType { get; set; }

            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public string IsExpired { get; set; }

            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            [NameInMap("MaintainAutoType")]
            [Validation(Required=false)]
            public bool? MaintainAutoType { get; set; }

            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("PublicConnectionString")]
            [Validation(Required=false)]
            public string PublicConnectionString { get; set; }

            [NameInMap("PublicIpAddr")]
            [Validation(Required=false)]
            public string PublicIpAddr { get; set; }

            [NameInMap("PublicPort")]
            [Validation(Required=false)]
            public string PublicPort { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ScaleOutStatus")]
            [Validation(Required=false)]
            public DescribeDBClusterAttributeResponseBodyDBClusterScaleOutStatus ScaleOutStatus { get; set; }
            public class DescribeDBClusterAttributeResponseBodyDBClusterScaleOutStatus : TeaModel {
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("Ratio")]
                [Validation(Required=false)]
                public string Ratio { get; set; }

            }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("SupportBackup")]
            [Validation(Required=false)]
            public int? SupportBackup { get; set; }

            [NameInMap("SupportHttpsPort")]
            [Validation(Required=false)]
            public bool? SupportHttpsPort { get; set; }

            [NameInMap("SupportMysqlPort")]
            [Validation(Required=false)]
            public bool? SupportMysqlPort { get; set; }

            [NameInMap("SupportOss")]
            [Validation(Required=false)]
            public int? SupportOss { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeDBClusterAttributeResponseBodyDBClusterTags Tags { get; set; }
            public class DescribeDBClusterAttributeResponseBodyDBClusterTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeDBClusterAttributeResponseBodyDBClusterTagsTag> Tag { get; set; }
                public class DescribeDBClusterAttributeResponseBodyDBClusterTagsTag : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VpcCloudInstanceId")]
            [Validation(Required=false)]
            public string VpcCloudInstanceId { get; set; }

            /// <summary>
            /// VPC ID。
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VpcIpAddr")]
            [Validation(Required=false)]
            public string VpcIpAddr { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("ZoneIdVswitchMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> ZoneIdVswitchMap { get; set; }

            [NameInMap("ZookeeperClass")]
            [Validation(Required=false)]
            public string ZookeeperClass { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
