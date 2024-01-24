// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbInstancesResponseBody : TeaModel {
        /// <summary>
        /// Indicates information about the ApsaraDB RDS for MySQL instances that are used to store the data of the specified database.
        /// </summary>
        [NameInMap("DbInstances")]
        [Validation(Required=false)]
        public DescribeDrdsDbInstancesResponseBodyDbInstances DbInstances { get; set; }
        public class DescribeDrdsDbInstancesResponseBodyDbInstances : TeaModel {
            [NameInMap("DbInstance")]
            [Validation(Required=false)]
            public List<DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstance> DbInstance { get; set; }
            public class DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstance : TeaModel {
                /// <summary>
                /// Indicates the endpoint that is used to connect to an ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.
                /// </summary>
                [NameInMap("ConnectUrl")]
                [Validation(Required=false)]
                public string ConnectUrl { get; set; }

                /// <summary>
                /// Indicates the ID of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// Indicates the state of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. Valid values:
                /// 
                /// *   **0**: The ApsaraDB RDS for MySQL instance is being created.
                /// *   **1**: The ApsaraDB RDS for MySQL instance is running.
                /// *   **3**: The ApsaraDB RDS for MySQL instance is being deleted.
                /// *   **5**: The ApsaraDB RDS for MySQL instance is being restarted.
                /// *   **6**: The ApsaraDB RDS for MySQL instance is being upgraded or downgraded.
                /// *   **7**: The ApsaraDB RDS for MySQL instance is being backed up.
                /// *   **8**: The network type of the ApsaraDB RDS for MySQL instance is being changed.
                /// *   **9**: The ApsaraDB RDS for MySQL instance is being migrated.
                /// *   **11**: The data of the ApsaraDB RDS for MySQL instance is being migrated.
                /// *   **12**: A disaster-recovery instance is being generated.
                /// *   **13**: Data is being imported to the ApsaraDB RDS for MySQL instance.
                /// *   **14**: Data is being imported to the ApsaraDB RDS for MySQL instance from an another ApsaraDB RDS for MySQL instance.
                /// *   **15**: A failover is being performed.
                /// *   **16**: A temporary instance is being created.
                /// *   **17**: A network is being created for the ApsaraDB RDS for MySQL instance.
                /// *   **18**: The ApsaraDB RDS for MySQL instance is being cloned.
                /// *   **19**: The link is being changed.
                /// *   **20**: The read-only instances of the ApsaraDB RDS for MySQL instance are being migrated.
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// Indicates the type of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. The value is set to RDS.
                /// </summary>
                [NameInMap("DbInstType")]
                [Validation(Required=false)]
                public string DbInstType { get; set; }

                /// <summary>
                /// Indicates the ID of a resource.
                /// </summary>
                [NameInMap("DmInstanceId")]
                [Validation(Required=false)]
                public string DmInstanceId { get; set; }

                /// <summary>
                /// Indicates the engine of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// Indicates the engine version of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// Indicates the point in time when the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database expires.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// Indicates the network type of the ApsaraDB RDS for MySQL instance.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// Indicates the billing method of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. Valid values:
                /// 
                /// *   **drdsPre**: The instance uses the subscription billing method.
                /// *   **drdsPost**: The instance uses the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// Indicates the port that is used to connect to the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// Indicates whether the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database is a primary instance or a read-only instance.
                /// 
                /// *   **Primary**: The instance is a primary instance.
                /// *   **Readonly**: The instance is a read-only instance.
                /// </summary>
                [NameInMap("RdsInstType")]
                [Validation(Required=false)]
                public string RdsInstType { get; set; }

                /// <summary>
                /// Indicates information about the read-only instances of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.
                /// </summary>
                [NameInMap("ReadOnlyInstances")]
                [Validation(Required=false)]
                public DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstances ReadOnlyInstances { get; set; }
                public class DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstances : TeaModel {
                    [NameInMap("ReadOnlyInstance")]
                    [Validation(Required=false)]
                    public List<DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstancesReadOnlyInstance> ReadOnlyInstance { get; set; }
                    public class DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstancesReadOnlyInstance : TeaModel {
                        /// <summary>
                        /// Indicates the endpoint that is used to connect to the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.
                        /// </summary>
                        [NameInMap("ConnectUrl")]
                        [Validation(Required=false)]
                        public string ConnectUrl { get; set; }

                        /// <summary>
                        /// Indicates the state of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. Valid values:
                        /// 
                        /// *   **0**: The ApsaraDB RDS for MySQL instance is being created.
                        /// *   **1**: The ApsaraDB RDS for MySQL instance is running.
                        /// *   **3**: The ApsaraDB RDS for MySQL instance is being deleted.
                        /// *   **5**: The ApsaraDB RDS for MySQL instance is being restarted.
                        /// *   **6**: The ApsaraDB RDS for MySQL instance is being upgraded or downgraded.
                        /// *   **7**: The ApsaraDB RDS for MySQL instance is being backed up.
                        /// *   **8**: The network type of the ApsaraDB RDS for MySQL instance is being changed.
                        /// *   **9**: The ApsaraDB RDS for MySQL instance is being migrated.
                        /// *   **11**: The data of the ApsaraDB RDS for MySQL instance is being migrated.
                        /// *   **12**: A disaster-recovery instance is being generated.
                        /// *   **13**: Data is being imported to the ApsaraDB RDS for MySQL instance.
                        /// *   **14**: Data is being imported to the ApsaraDB RDS for MySQL instance from an another ApsaraDB RDS for MySQL instance.
                        /// *   **15**: A failover is being performed.
                        /// *   **16**: A temporary instance is being created.
                        /// *   **17**: A network is being created for the ApsaraDB RDS for MySQL instance.
                        /// *   **18**: The ApsaraDB RDS for MySQL instance is being cloned.
                        /// *   **19**: The link is being changed.
                        /// *   **20**: The read-only instances of the ApsaraDB RDS for MySQL instance are being migrated.
                        /// </summary>
                        [NameInMap("DBInstanceStatus")]
                        [Validation(Required=false)]
                        public string DBInstanceStatus { get; set; }

                        /// <summary>
                        /// Indicates the type of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. The value is set to RDS.
                        /// </summary>
                        [NameInMap("DbInstType")]
                        [Validation(Required=false)]
                        public string DbInstType { get; set; }

                        /// <summary>
                        /// Indicates the ID of a resource.
                        /// </summary>
                        [NameInMap("DmInstanceId")]
                        [Validation(Required=false)]
                        public string DmInstanceId { get; set; }

                        /// <summary>
                        /// Indicates the engine of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.
                        /// </summary>
                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        /// <summary>
                        /// Indicates the engine version of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.
                        /// </summary>
                        [NameInMap("EngineVersion")]
                        [Validation(Required=false)]
                        public string EngineVersion { get; set; }

                        /// <summary>
                        /// Indicates the timestamp when the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database expires.
                        /// </summary>
                        [NameInMap("ExpireTime")]
                        [Validation(Required=false)]
                        public string ExpireTime { get; set; }

                        /// <summary>
                        /// Indicates the name of a read-only instance.
                        /// </summary>
                        [NameInMap("InstanceName")]
                        [Validation(Required=false)]
                        public string InstanceName { get; set; }

                        /// <summary>
                        /// Indicates the network type of the read-only instance.
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// Indicates the billing method of the read-only instance.
                        /// 
                        /// *   **drdsPre**: The instance uses the subscription billing method.
                        /// *   **drdsPost**: The instance uses the pay-as-you-go billing method.
                        /// </summary>
                        [NameInMap("PayType")]
                        [Validation(Required=false)]
                        public string PayType { get; set; }

                        /// <summary>
                        /// Indicates the port that is used to connect to the read-only instance.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// Indicates the type of the read-only instance.
                        /// </summary>
                        [NameInMap("RdsInstType")]
                        [Validation(Required=false)]
                        public string RdsInstType { get; set; }

                        /// <summary>
                        /// Indicates the read weight of the read-only instance.
                        /// </summary>
                        [NameInMap("ReadWeight")]
                        [Validation(Required=false)]
                        public int? ReadWeight { get; set; }

                        /// <summary>
                        /// Indicates the number of remaining days before the read-only instance expires.
                        /// </summary>
                        [NameInMap("RemainDays")]
                        [Validation(Required=false)]
                        public int? RemainDays { get; set; }

                    }

                }

                /// <summary>
                /// Indicates the read weight of the read-only instance.
                /// </summary>
                [NameInMap("ReadWeight")]
                [Validation(Required=false)]
                public int? ReadWeight { get; set; }

                /// <summary>
                /// Indicates the number of remaining days before a subscription instance expires.
                /// </summary>
                [NameInMap("RemainDays")]
                [Validation(Required=false)]
                public int? RemainDays { get; set; }

            }

        }

        /// <summary>
        /// Indicates the page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// Indicates the number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Indicates the number of primary ApsaraDB RDS for MySQL instances.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
