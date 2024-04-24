// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDbInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDbInstancesResponseBodyItems Items { get; set; }
        public class DescribeDbInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDbInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDbInstancesResponseBodyItemsDBInstance : TeaModel {
                [NameInMap("AllowAllCategory")]
                [Validation(Required=false)]
                public bool? AllowAllCategory { get; set; }

                /// <summary>
                /// The description of the storage instance.
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// The ID of the storage instance.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// Storage layer instance status. Valid values:
                /// 
                /// *   **0**: creating
                /// *   **1**: In use
                /// *   **3**: Deleting
                /// *   **5**: restarting
                /// *   **6**: upgrading /Downgrading
                /// *   **7**: Recovering
                /// *   **8**: switching the Internet and intranet
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public int? DBInstanceStatus { get; set; }

                /// <summary>
                /// The storage layer instance type.
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// The engine of the storage instance.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The version of the engine for the storage instance.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The network type of the storage layer. Valid values:
                /// 
                /// *   **VPC**: VPC
                /// *   **CLASSIC **: Classic Network
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// The details about a read-only storage instance.
                /// </summary>
                [NameInMap("ReadOnlyDBInstanceId")]
                [Validation(Required=false)]
                public DescribeDbInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceId ReadOnlyDBInstanceId { get; set; }
                public class DescribeDbInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceId : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<string> ReadOnlyDBInstanceId { get; set; }

                }

                /// <summary>
                /// The ID of the region where the storage instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the zone where the storage instance resides.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
