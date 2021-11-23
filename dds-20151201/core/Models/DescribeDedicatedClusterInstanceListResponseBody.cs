// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDedicatedClusterInstanceListResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeDedicatedClusterInstanceListResponseBodyInstances Instances { get; set; }
        public class DescribeDedicatedClusterInstanceListResponseBodyInstances : TeaModel {
            [NameInMap("dbInstance")]
            [Validation(Required=false)]
            public List<DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstance> DbInstance { get; set; }
            public class DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstance : TeaModel {
                public string CharacterType { get; set; }
                public string ClusterId { get; set; }
                public string ClusterName { get; set; }
                public string CreateTime { get; set; }
                public string CustomId { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string InstanceClass { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeList InstanceNodeList { get; set; }
                public class DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeList : TeaModel {
                    [NameInMap("InstanceNodes")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeListInstanceNodes> InstanceNodes { get; set; }
                    public class DescribeDedicatedClusterInstanceListResponseBodyInstancesDbInstanceInstanceNodeListInstanceNodes : TeaModel {
                        [NameInMap("DedicatedHostName")]
                        [Validation(Required=false)]
                        public string DedicatedHostName { get; set; }

                        [NameInMap("InsName")]
                        [Validation(Required=false)]
                        public string InsName { get; set; }

                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public int? NodeId { get; set; }

                        [NameInMap("NodeIp")]
                        [Validation(Required=false)]
                        public string NodeIp { get; set; }

                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }
                public string InstanceStatus { get; set; }
                public string MaintainEndTime { get; set; }
                public string MaintainStartTime { get; set; }
                public string Region { get; set; }
                public string RegionId { get; set; }
                public string StorageType { get; set; }
                public string VpcId { get; set; }
                public string VswitchId { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
