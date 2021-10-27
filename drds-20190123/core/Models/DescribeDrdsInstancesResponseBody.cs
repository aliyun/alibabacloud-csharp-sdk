// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeDrdsInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeDrdsInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeDrdsInstancesResponseBodyInstancesInstance : TeaModel {
                public string CommodityCode { get; set; }
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public string DrdsInstanceId { get; set; }
                public long? ExpireDate { get; set; }
                public string InstRole { get; set; }
                public string InstanceSeries { get; set; }
                public string InstanceSpec { get; set; }
                public string Label { get; set; }
                public string MachineType { get; set; }
                public string MasterInstanceId { get; set; }
                public string NetworkType { get; set; }
                public string OrderInstanceId { get; set; }
                public string ProductVersion { get; set; }
                public DescribeDrdsInstancesResponseBodyInstancesInstanceReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDrdsInstancesResponseBodyInstancesInstanceReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<string> ReadOnlyDBInstanceId { get; set; }

                }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
                public long? Version { get; set; }
                public string VersionAction { get; set; }
                public DescribeDrdsInstancesResponseBodyInstancesInstanceVips Vips { get; set; }
                public class DescribeDrdsInstancesResponseBodyInstancesInstanceVips : TeaModel {
                    [NameInMap("Vip")]
                    [Validation(Required=false)]
                    public List<DescribeDrdsInstancesResponseBodyInstancesInstanceVipsVip> Vip { get; set; }
                    public class DescribeDrdsInstancesResponseBodyInstancesInstanceVipsVip : TeaModel {
                        [NameInMap("IP")]
                        [Validation(Required=false)]
                        public string IP { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                    }

                }
                public string VpcCloudInstanceId { get; set; }
                public string VpcId { get; set; }
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

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
