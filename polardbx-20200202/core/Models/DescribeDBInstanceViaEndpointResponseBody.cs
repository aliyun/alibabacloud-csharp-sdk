// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceViaEndpointResponseBody : TeaModel {
        [NameInMap("DBInstance")]
        [Validation(Required=false)]
        public DescribeDBInstanceViaEndpointResponseBodyDBInstance DBInstance { get; set; }
        public class DescribeDBInstanceViaEndpointResponseBodyDBInstance : TeaModel {
            [NameInMap("CnNodeClassCode")]
            [Validation(Required=false)]
            public string CnNodeClassCode { get; set; }

            [NameInMap("CnNodeCount")]
            [Validation(Required=false)]
            public int? CnNodeCount { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("ConnAddrs")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceViaEndpointResponseBodyDBInstanceConnAddrs> ConnAddrs { get; set; }
            public class DescribeDBInstanceViaEndpointResponseBodyDBInstanceConnAddrs : TeaModel {
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
            public List<DescribeDBInstanceViaEndpointResponseBodyDBInstanceDBNodes> DBNodes { get; set; }
            public class DescribeDBInstanceViaEndpointResponseBodyDBInstanceDBNodes : TeaModel {
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

            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }

            [NameInMap("TagSet")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceViaEndpointResponseBodyDBInstanceTagSet> TagSet { get; set; }
            public class DescribeDBInstanceViaEndpointResponseBodyDBInstanceTagSet : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
