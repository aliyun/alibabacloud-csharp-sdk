// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesResponseBodyDBInstances> DBInstances { get; set; }
        public class DescribeDBInstancesResponseBodyDBInstances : TeaModel {
            [NameInMap("CdcInstanceName")]
            [Validation(Required=false)]
            public string CdcInstanceName { get; set; }

            [NameInMap("CnNodeClassCode")]
            [Validation(Required=false)]
            public string CnNodeClassCode { get; set; }

            [NameInMap("CnNodeCount")]
            [Validation(Required=false)]
            public int? CnNodeCount { get; set; }

            [NameInMap("ColumnarInstanceName")]
            [Validation(Required=false)]
            public string ColumnarInstanceName { get; set; }

            [NameInMap("ColumnarReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ColumnarReadDBInstances { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("ContainBinlogX")]
            [Validation(Required=false)]
            public bool? ContainBinlogX { get; set; }

            [NameInMap("CpuType")]
            [Validation(Required=false)]
            public string CpuType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DnNodeClassCode")]
            [Validation(Required=false)]
            public string DnNodeClassCode { get; set; }

            [NameInMap("DnNodeCount")]
            [Validation(Required=false)]
            public int? DnNodeCount { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            [NameInMap("NodeClass")]
            [Validation(Required=false)]
            public string NodeClass { get; set; }

            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyDBInstancesNodes> Nodes { get; set; }
            public class DescribeDBInstancesResponseBodyDBInstancesNodes : TeaModel {
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// 主可用区。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            [NameInMap("ReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ReadDBInstances { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// 次可用区。
            /// </summary>
            [NameInMap("SecondaryZone")]
            [Validation(Required=false)]
            public string SecondaryZone { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }

            [NameInMap("SupportBinlogX")]
            [Validation(Required=false)]
            public bool? SupportBinlogX { get; set; }

            [NameInMap("TagSet")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyDBInstancesTagSet> TagSet { get; set; }
            public class DescribeDBInstancesResponseBodyDBInstancesTagSet : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 第三可用区。
            /// </summary>
            [NameInMap("TertiaryZone")]
            [Validation(Required=false)]
            public string TertiaryZone { get; set; }

            /// <summary>
            /// 拓扑类型：
            /// 
            /// - **3azones**：三可用区；
            /// - **1azone**：单可用区。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// VPC ID。
            /// </summary>
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("gdnRole")]
            [Validation(Required=false)]
            public string GdnRole { get; set; }

            [NameInMap("isInGdn")]
            [Validation(Required=false)]
            public bool? IsInGdn { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
