// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceTopologyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceTopologyResponseBodyData Data { get; set; }
        public class DescribeDBInstanceTopologyResponseBodyData : TeaModel {
            [NameInMap("LogicInstanceTopology")]
            [Validation(Required=false)]
            public DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopology LogicInstanceTopology { get; set; }
            public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopology : TeaModel {
                [NameInMap("DBInstanceConnType")]
                [Validation(Required=false)]
                public string DBInstanceConnType { get; set; }

                [NameInMap("DBInstanceCreateTime")]
                [Validation(Required=false)]
                public string DBInstanceCreateTime { get; set; }

                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public int? DBInstanceStatus { get; set; }

                [NameInMap("DBInstanceStatusDescription")]
                [Validation(Required=false)]
                public string DBInstanceStatusDescription { get; set; }

                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItems> Items { get; set; }
                public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItems : TeaModel {
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    [NameInMap("Azone")]
                    [Validation(Required=false)]
                    public string Azone { get; set; }

                    [NameInMap("AzoneRoleList")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsAzoneRoleList> AzoneRoleList { get; set; }
                    public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsAzoneRoleList : TeaModel {
                        [NameInMap("Azone")]
                        [Validation(Required=false)]
                        public string Azone { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                    }

                    [NameInMap("CharacterType")]
                    [Validation(Required=false)]
                    public string CharacterType { get; set; }

                    [NameInMap("ConnectionIp")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsConnectionIp> ConnectionIp { get; set; }
                    public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsConnectionIp : TeaModel {
                        [NameInMap("ConnectionString")]
                        [Validation(Required=false)]
                        public string ConnectionString { get; set; }

                        [NameInMap("DBInstanceNetType")]
                        [Validation(Required=false)]
                        public int? DBInstanceNetType { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                    }

                    [NameInMap("DBInstanceConnType")]
                    [Validation(Required=false)]
                    public int? DBInstanceConnType { get; set; }

                    [NameInMap("DBInstanceCreateTime")]
                    [Validation(Required=false)]
                    public string DBInstanceCreateTime { get; set; }

                    [NameInMap("DBInstanceDescription")]
                    [Validation(Required=false)]
                    public string DBInstanceDescription { get; set; }

                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

                    [NameInMap("DBInstanceName")]
                    [Validation(Required=false)]
                    public string DBInstanceName { get; set; }

                    [NameInMap("DBInstanceStatus")]
                    [Validation(Required=false)]
                    public int? DBInstanceStatus { get; set; }

                    [NameInMap("DBInstanceStatusDescription")]
                    [Validation(Required=false)]
                    public string DBInstanceStatusDescription { get; set; }

                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public long? DiskSize { get; set; }

                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    [NameInMap("EngineVersion")]
                    [Validation(Required=false)]
                    public string EngineVersion { get; set; }

                    [NameInMap("LockMode")]
                    [Validation(Required=false)]
                    public int? LockMode { get; set; }

                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public string LockReason { get; set; }

                    [NameInMap("MaintainEndTime")]
                    [Validation(Required=false)]
                    public string MaintainEndTime { get; set; }

                    [NameInMap("MaintainStartTime")]
                    [Validation(Required=false)]
                    public string MaintainStartTime { get; set; }

                    [NameInMap("MaxConnections")]
                    [Validation(Required=false)]
                    public int? MaxConnections { get; set; }

                    [NameInMap("MaxIops")]
                    [Validation(Required=false)]
                    public int? MaxIops { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public int? LockMode { get; set; }

                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
