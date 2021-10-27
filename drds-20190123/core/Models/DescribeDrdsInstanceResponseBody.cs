// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceResponseBodyData Data { get; set; }
        public class DescribeDrdsInstanceResponseBodyData : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DrdsInstanceId")]
            [Validation(Required=false)]
            public string DrdsInstanceId { get; set; }
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }
            [NameInMap("InstRole")]
            [Validation(Required=false)]
            public string InstRole { get; set; }
            [NameInMap("InstanceSeries")]
            [Validation(Required=false)]
            public string InstanceSeries { get; set; }
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public string InstanceSpec { get; set; }
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }
            [NameInMap("MasterInstanceId")]
            [Validation(Required=false)]
            public string MasterInstanceId { get; set; }
            [NameInMap("MysqlVersion")]
            [Validation(Required=false)]
            public int? MysqlVersion { get; set; }
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }
            [NameInMap("OrderInstanceId")]
            [Validation(Required=false)]
            public string OrderInstanceId { get; set; }
            [NameInMap("ProductVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }
            [NameInMap("ReadOnlyDBInstanceIds")]
            [Validation(Required=false)]
            public DescribeDrdsInstanceResponseBodyDataReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
            public class DescribeDrdsInstanceResponseBodyDataReadOnlyDBInstanceIds : TeaModel {
                [NameInMap("ReadOnlyDBInstanceId")]
                [Validation(Required=false)]
                public List<string> ReadOnlyDBInstanceId { get; set; }

            }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }
            [NameInMap("VersionAction")]
            [Validation(Required=false)]
            public string VersionAction { get; set; }
            [NameInMap("Vips")]
            [Validation(Required=false)]
            public DescribeDrdsInstanceResponseBodyDataVips Vips { get; set; }
            public class DescribeDrdsInstanceResponseBodyDataVips : TeaModel {
                [NameInMap("Vip")]
                [Validation(Required=false)]
                public List<DescribeDrdsInstanceResponseBodyDataVipsVip> Vip { get; set; }
                public class DescribeDrdsInstanceResponseBodyDataVipsVip : TeaModel {
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public string Dns { get; set; }

                    [NameInMap("ExpireDays")]
                    [Validation(Required=false)]
                    public long? ExpireDays { get; set; }

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
            [NameInMap("VpcCloudInstanceId")]
            [Validation(Required=false)]
            public string VpcCloudInstanceId { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
