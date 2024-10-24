// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        [NameInMap("DBInstance")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyDBInstance DBInstance { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBInstance : TeaModel {
            [NameInMap("CanNotCreateColumnar")]
            [Validation(Required=false)]
            public bool? CanNotCreateColumnar { get; set; }

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

            [NameInMap("ConnAddrs")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceConnAddrs> ConnAddrs { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceConnAddrs : TeaModel {
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// VPC ID。
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DBInstanceType")]
            [Validation(Required=false)]
            public string DBInstanceType { get; set; }

            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            [NameInMap("DBNodeCount")]
            [Validation(Required=false)]
            public int? DBNodeCount { get; set; }

            [NameInMap("DBNodes")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceDBNodes> DBNodes { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceDBNodes : TeaModel {
                [NameInMap("ComputeNodeId")]
                [Validation(Required=false)]
                public string ComputeNodeId { get; set; }

                [NameInMap("DataNodeId")]
                [Validation(Required=false)]
                public string DataNodeId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("NodeClass")]
                [Validation(Required=false)]
                public string NodeClass { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DifferentDNSpec")]
            [Validation(Required=false)]
            public bool? DifferentDNSpec { get; set; }

            [NameInMap("DnNodeClassCode")]
            [Validation(Required=false)]
            public string DnNodeClassCode { get; set; }

            [NameInMap("DnNodeCount")]
            [Validation(Required=false)]
            public int? DnNodeCount { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("KindCode")]
            [Validation(Required=false)]
            public int? KindCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("LTSVersions")]
            [Validation(Required=false)]
            public List<string> LTSVersions { get; set; }

            [NameInMap("LatestMinorVersion")]
            [Validation(Required=false)]
            public string LatestMinorVersion { get; set; }

            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

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

            [NameInMap("RightsSeparationEnabled")]
            [Validation(Required=false)]
            public bool? RightsSeparationEnabled { get; set; }

            [NameInMap("RightsSeparationStatus")]
            [Validation(Required=false)]
            public string RightsSeparationStatus { get; set; }

            /// <summary>
            /// 次可用区。
            /// </summary>
            [NameInMap("SecondaryZone")]
            [Validation(Required=false)]
            public string SecondaryZone { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            [NameInMap("SpecCategory")]
            [Validation(Required=false)]
            public string SpecCategory { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }

            [NameInMap("TagSet")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceTagSet> TagSet { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceTagSet : TeaModel {
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

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
