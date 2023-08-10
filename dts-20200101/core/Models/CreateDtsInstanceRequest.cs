// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateDtsInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically renew the DTS instance when it expires. Valid values:
        /// 
        /// *   **false**: does not automatically renew the DTS instance when it expires. This is the default value.
        /// *   **true**: automatically renews the DTS instance when it expires.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to automatically start the task after the DTS instance is purchased. Valid values:
        /// 
        /// *   **false**: does not automatically start the task after the DTS instance is purchased. This is the default value.
        /// *   **true**: automatically starts the task after the DTS instance is purchased.
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// The specifications of the extract, transform, and load (ETL) instance. The unit is compute unit (CU). One CU is equal to 1 vCPU and 4 GB of memory. The value of this parameter must be an integer greater than or equal to 2.
        /// </summary>
        [NameInMap("ComputeUnit")]
        [Validation(Required=false)]
        public int? ComputeUnit { get; set; }

        /// <summary>
        /// The number of private custom ApsaraDB RDS instances in a PolarDB-X instance. Default value: **1**.
        /// 
        /// >  You must specify this parameter only if the **SourceEndpointEngineName** parameter is set to **drds**.
        /// </summary>
        [NameInMap("DatabaseCount")]
        [Validation(Required=false)]
        public int? DatabaseCount { get; set; }

        /// <summary>
        /// The database engine of the destination instance.
        /// 
        /// *   **MySQL**: ApsaraDB RDS for MySQL instance or self-managed MySQL database
        /// *   **PolarDB**: PolarDB for MySQL cluster
        /// *   **polardb_o**: PolarDB for Oracle cluster
        /// *   **polardb_pg**: PolarDB for PostgreSQL cluster
        /// *   **Redis**: ApsaraDB for Redis instance or self-managed Redis database
        /// *   **DRDS**: PolarDB-X 1.0 or PolarDB-X 2.0 instance
        /// *   **PostgreSQL**: self-managed PostgreSQL database
        /// *   **odps**: MaxCompute project
        /// *   **oracle**: self-managed Oracle database
        /// *   **mongodb**: ApsaraDB for MongoDB instance or self-managed MongoDB database
        /// *   **tidb**: TiDB database
        /// *   **ADS**: AnalyticDB for MySQL V2.0 cluster
        /// *   **ADB30**: AnalyticDB for MySQL V3.0 cluster
        /// *   **Greenplum**: AnalyticDB for PostgreSQL instance
        /// *   **MSSQL**: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database
        /// *   **kafka**: Message Queue for Apache Kafka instance or self-managed Kafka cluster
        /// *   **DataHub**: DataHub project
        /// *   **DB2**: self-managed Db2 for LUW database
        /// *   **as400**: AS/400
        /// *   **Tablestore**: Tablestore instance
        /// 
        /// > 
        /// *   The default value is **MySQL**.
        /// *   For more information about the supported source and destination databases, see [Overview of data synchronization scenarios](~~130744~~) and [Overview of data migration scenarios](~~26618~~).
        /// *   You must specify one of this parameter and the **JobId** parameter.
        /// </summary>
        [NameInMap("DestinationEndpointEngineName")]
        [Validation(Required=false)]
        public string DestinationEndpointEngineName { get; set; }

        /// <summary>
        /// The ID of the region in which the destination instance resides. For more information, see [List of supported regions](~~141033~~).
        /// 
        /// >  You must specify one of this parameter and the **JobId** parameter.
        /// </summary>
        [NameInMap("DestinationRegion")]
        [Validation(Required=false)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// The number of DTS units (DUs) that are assigned to a DTS task that is run on a DTS dedicated cluster. Valid values: **1** to **100**.
        /// 
        /// > 
        /// *   The value of this parameter must be within the range of the number of DUs available for the DTS dedicated cluster.
        /// </summary>
        [NameInMap("Du")]
        [Validation(Required=false)]
        public int? Du { get; set; }

        /// <summary>
        /// The billing type for a change tracking instance. Valid values: ONLY_CONFIGURATION_FEE and CONFIGURATION_FEE_AND_DATA_FEE. ONLY_CONFIGURATION_FEE: charges only configuration fees. CONFIGURATION_FEE_AND_DATA_FEE: charges configuration fees and data traffic fees.
        /// </summary>
        [NameInMap("FeeType")]
        [Validation(Required=false)]
        public string FeeType { get; set; }

        /// <summary>
        /// The instance class.
        /// 
        /// *   DTS supports the following instance classes for a data migration instance: **xxlarge**, **xlarge**, **large**, **medium**, and **small**.
        /// *   DTS supports the following instance classes for a data synchronization instance: **large**, **medium**, **small**, and **micro**.
        /// 
        /// >  For more information about the test performance of each instance class, see [Specifications of data migration instances](~~26606~~) and [Specifications of data synchronization instances](~~26605~~).
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The ID of the task. You can call the **ConfigureDtsJob** operation to obtain the task ID from the **DtsJobId** parameter.
        /// 
        /// >  If this parameter is specified, you do not need to specify the **SourceRegion**, **DestinationRegion**, **Type**, **SourceEndpointEngineName**, or **DestinationEndpointEngineName** parameter. Even if these parameters are specified, the value of the **JobId** parameter takes precedence.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// 
        /// >  This parameter must be specified.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The unit of the subscription duration. Valid values: **Year** and **Month**.
        /// 
        /// >  You must specify this parameter only if the **PayType** parameter is set to **PrePaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The number of DTS instances that you want to purchase.
        /// 
        /// >  Only a single instance can be purchased each time.
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The ID of the region in which the DTS instance resides. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The database engine of the source instance.
        /// 
        /// *   **MySQL**: ApsaraDB RDS for MySQL instance or self-managed MySQL database
        /// *   **PolarDB**: PolarDB for MySQL cluster
        /// *   **polardb_o**: PolarDB for Oracle cluster
        /// *   **polardb_pg**: PolarDB for PostgreSQL cluster
        /// *   **Redis**: ApsaraDB for Redis instance or self-managed Redis database
        /// *   **DRDS**: PolarDB-X 1.0 or PolarDB-X 2.0 instance
        /// *   **PostgreSQL**: self-managed PostgreSQL database
        /// *   **odps**: MaxCompute project
        /// *   **oracle**: self-managed Oracle database
        /// *   **mongodb**: ApsaraDB for MongoDB instance or self-managed MongoDB database
        /// *   **tidb**: TiDB database
        /// *   **ADS**: AnalyticDB for MySQL V2.0 cluster
        /// *   **ADB30**: AnalyticDB for MySQL V3.0 cluster
        /// *   **Greenplum**: AnalyticDB for PostgreSQL instance
        /// *   **MSSQL**: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database
        /// *   **kafka**: Message Queue for Apache Kafka instance or self-managed Kafka cluster
        /// *   **DataHub**: DataHub project
        /// *   **DB2**: self-managed Db2 for LUW database
        /// *   **as400**: AS/400
        /// *   **Tablestore**: Tablestore instance
        /// 
        /// > 
        /// *   The default value is **MySQL**.
        /// *   For more information about the supported source and destination databases, see [Overview of data synchronization scenarios](~~130744~~) and [Overview of data migration scenarios](~~26618~~).
        /// *   You must specify one of this parameter and the **JobId** parameter.
        /// </summary>
        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        /// <summary>
        /// The ID of the region in which the source instance resides. For more information, see [List of supported regions](~~141033~~).
        /// 
        /// >  You must specify one of this parameter and the **JobId** parameter.
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// The synchronization topology. Valid values:
        /// 
        /// *   **oneway**: one-way synchronization. This is the default value.
        /// *   **bidirectional**: two-way synchronization.
        /// </summary>
        [NameInMap("SyncArchitecture")]
        [Validation(Required=false)]
        public string SyncArchitecture { get; set; }

        /// <summary>
        /// The type of the DTS instance. Valid values:
        /// 
        /// *   **MIGRATION**: data migration instance
        /// 
        /// *   **SYNC**: data synchronization instance
        /// 
        /// *   **SUBSCRIBE**: change tracking instance
        /// 
        /// > You must specify one of this parameter and the **JobId** parameter.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The subscription duration.
        /// 
        /// *   Valid values if the **Period** parameter is set to **Month**: 1, 2, 3, 4, 5, 6, 7, 8, and 9.
        /// 
        /// *   Valid values if the **Period** parameter is set to **Year**: 1, 2, 3, and 5.
        /// 
        /// > *   You must specify this parameter only if the **PayType** parameter is set to **PrePaid**.
        ///    *   You can set the **Period** parameter to specify the unit of the subscription duration.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
