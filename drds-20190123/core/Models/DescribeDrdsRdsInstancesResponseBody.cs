// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsRdsInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about the custom ApsaraDB RDS for MySQL instances at the storage layer.
        /// </summary>
        [NameInMap("DbInstances")]
        [Validation(Required=false)]
        public DescribeDrdsRdsInstancesResponseBodyDbInstances DbInstances { get; set; }
        public class DescribeDrdsRdsInstancesResponseBodyDbInstances : TeaModel {
            [NameInMap("DbInstance")]
            [Validation(Required=false)]
            public List<DescribeDrdsRdsInstancesResponseBodyDbInstancesDbInstance> DbInstance { get; set; }
            public class DescribeDrdsRdsInstancesResponseBodyDbInstancesDbInstance : TeaModel {
                /// <summary>
                /// The internal endpoint of the custom ApsaraDB RDS for MySQL instance at the storage layer.
                /// </summary>
                [NameInMap("ConnectUrl")]
                [Validation(Required=false)]
                public string ConnectUrl { get; set; }

                /// <summary>
                /// The number of CPU cores of the custom ApsaraDB RDS for MySQL instance at the storage layer.
                /// </summary>
                [NameInMap("DBInstanceCPU")]
                [Validation(Required=false)]
                public string DBInstanceCPU { get; set; }

                /// <summary>
                /// The instance family of the custom ApsaraDB RDS for MySQL instance at the storage layer. Valid values:
                /// 
                /// *   **x**: general-purpose instance family
                /// *   **d**: dedicated instance family
                /// *   **h**: dedicated host instance family
                /// </summary>
                [NameInMap("DBInstanceClassType")]
                [Validation(Required=false)]
                public string DBInstanceClassType { get; set; }

                /// <summary>
                /// The ID of the custom ApsaraDB RDS for MySQL instance at the storage layer.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// The memory size of the custom ApsaraDB RDS for MySQL instance at the storage layer. Unit: MB.
                /// </summary>
                [NameInMap("DBInstanceMemory")]
                [Validation(Required=false)]
                public long? DBInstanceMemory { get; set; }

                /// <summary>
                /// The status of the custom ApsaraDB RDS for MySQL instance at the storage layer. Valid values:
                /// 
                /// *   0: The instance is being created.
                /// *   1: The instance is running.
                /// *   3: The instance is being deleted.
                /// *   5: The instance is being restarted.
                /// *   6: The instance is being upgraded or downgraded.
                /// *   7: The instance is being backed up.
                /// *   8: The network type of the instance is being changed.
                /// *   9: The instance is being migrated.
                /// *   11: The data stored on the instance is being migrated.
                /// *   12: A disaster recovery instance is being generated.
                /// *   13: Data is being imported to the instance.
                /// *   14: Data is being imported from another RDS instance to the instance.
                /// *   15: A switchover is being performed.
                /// *   16: A temporary instance is being created.
                /// *   17: The network of the instance is being created.
                /// *   18: The instance is being cloned.
                /// *   19: The link is being changed.
                /// *   20: The read-only RDS instances of the instance are being migrated.
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// The storage space of the custom ApsaraDB RDS for MySQL instance at the storage layer. Unit: GB.
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public long? DBInstanceStorage { get; set; }

                /// <summary>
                /// The type of the instance at the storage layer. The value is RDS.
                /// </summary>
                [NameInMap("DbInstType")]
                [Validation(Required=false)]
                public string DbInstType { get; set; }

                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("DmInstanceId")]
                [Validation(Required=false)]
                public string DmInstanceId { get; set; }

                /// <summary>
                /// The engine type of the custom ApsaraDB RDS for MySQL instance at the storage layer. The value is MySQL.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The engine version of the custom ApsaraDB RDS for MySQL instance at the storage layer. The value is 8.0.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The lock mode of the RDS instance. Valid values:
                /// 
                /// 0: The instance is not locked.
                /// 
                /// 1: The instance is manually locked.
                /// 
                /// 2: The instance is automatically locked if the instance expires.
                /// 
                /// 3: The instance is automatically locked if the instance is rolled back.
                /// 
                /// 4: The instance is automatically locked if the storage space of the instance reaches the upper limit.
                /// 
                /// 5: The instance is automatically locked if the storage space of the read-only instances reaches the upper limit.
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public int? LockMode { get; set; }

                /// <summary>
                /// The reason why the RDS instance is locked.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The network type of the custom ApsaraDB RDS for MySQL instance at the storage layer. The value is VPC.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The billing method of the custom ApsaraDB RDS for MySQL instance at the storage layer. Valid values:
                /// 
                /// *   Postpaid: pay-as-you-go
                /// *   Prepaid: subscription
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The port used to connect to the instance over an internal network.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The type of the custom ApsaraDB RDS for MySQL instance at the storage layer. Valid values:
                /// 
                /// *   Primary: primary instance
                /// *   Readonly: read-only instance
                /// </summary>
                [NameInMap("RdsInstType")]
                [Validation(Required=false)]
                public string RdsInstType { get; set; }

                /// <summary>
                /// The read and write weights of the custom ApsaraDB RDS for MySQL instance at the storage layer.
                /// </summary>
                [NameInMap("ReadWeight")]
                [Validation(Required=false)]
                public int? ReadWeight { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
