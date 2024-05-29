// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConnectionStatusRequest : TeaModel {
        /// <summary>
        /// You must specify this parameter only if the **SourceEndpointEngineName** parameter is set to **Oracle**. Valid values:
        /// 
        /// *   **SID**: non-RAC architecture
        /// *   **RAC**: Real Application Cluster (RAC) architecture
        /// 
        /// >  This parameter is optional. The data type of this parameter is String.
        /// </summary>
        [NameInMap("DestinationEndpointArchitecture")]
        [Validation(Required=false)]
        public string DestinationEndpointArchitecture { get; set; }

        /// <summary>
        /// The name of the destination database or the authentication database.
        /// 
        /// > 
        /// *   You must specify this parameter if the **DestinationEndpointEngineName** parameter is set to **PostgreSQL**, **DRDS**, or **MongoDB**. You must also specify this parameter if the **DestinationEndpointInstanceType** parameter is set to **PolarDB_o**.
        /// *   If the **DestinationEndpointEngineName** parameter is set to **PostgreSQL** or **DRDS**, specify the name of the destination database. If the DestinationEndpointEngineName parameter is set to **MongoDB**, specify the name of the authentication database.
        /// *   If the **DestinationEndpointInstanceType** parameter is set to **PolarDB_o**, specify the name of the destination database.
        /// </summary>
        [NameInMap("DestinationEndpointDatabaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDatabaseName { get; set; }

        /// <summary>
        /// The engine type of the destination database. Valid values: **MySQL**, **DRDS**, **SQLServer**, **PostgreSQL**, **PPAS**, **MongoDB**, and **Redis**.
        /// 
        /// >  You must specify this parameter only if the **DestinationEndpointInstanceType** parameter is set to **RDS**, **DRDS**, **ECS**, **LocalInstance**, or **Express**.
        /// </summary>
        [NameInMap("DestinationEndpointEngineName")]
        [Validation(Required=false)]
        public string DestinationEndpointEngineName { get; set; }

        /// <summary>
        /// The endpoint of the destination database.
        /// 
        /// >  You must specify this parameter only if the **DestinationEndpointInstanceType** parameter is set to **LocalInstance** or **Express**.
        /// </summary>
        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        /// <summary>
        /// The ID of the destination instance.
        /// </summary>
        [NameInMap("DestinationEndpointInstanceID")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceID { get; set; }

        /// <summary>
        /// The instance type of the destination database. Valid values:
        /// 
        /// > 
        /// *   **ECS**: self-managed database that is hosted on Elastic Compute Service (ECS)
        /// *   **LocalInstance**: self-managed database with a public IP address
        /// *   **RDS**: ApsaraDB RDS instance
        /// *   **DRDS**: PolarDB-X instance
        /// *   **MongoDB**: ApsaraDB for MongoDB instance
        /// *   **Redis**: ApsaraDB for Redis instance
        /// *   **PetaData**: HybridDB for MySQL instance
        /// *   **POLARDB**: PolarDB for MySQL cluster
        /// *   **PolarDB_o**: PolarDB for Oracle cluster
        /// *   **AnalyticDB**: AnalyticDB for MySQL cluster V3.0 or V2.0
        /// *   **Greenplum**: AnalyticDB for PostgreSQL instance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationEndpointInstanceType")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceType { get; set; }

        /// <summary>
        /// You must specify this parameter only if the **DestinationEndpointEngineName** parameter is set to **Oracle**. Valid values:
        /// 
        /// *   **SID**: non-RAC architecture
        /// *   **RAC**: RAC architecture
        /// 
        /// >  This parameter is optional. The data type of this parameter is String.
        /// </summary>
        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        /// <summary>
        /// The password of the destination database account.
        /// </summary>
        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        /// <summary>
        /// The service port number of the source database.
        /// 
        /// >  You must specify this parameter only if the **SourceEndpointInstanceType** parameter is set to **ECS**, **LocalInstance**, or **Express**.
        /// </summary>
        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public string DestinationEndpointPort { get; set; }

        /// <summary>
        /// The ID of the region where the destination instance resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// </summary>
        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        /// <summary>
        /// The database account of the destination database.
        /// 
        /// >  The permissions that are required for database accounts vary with the migration or synchronization scenario. For more information, see [Overview of data migration scenarios](https://help.aliyun.com/document_detail/26618.html) and [Overview of data synchronization scenarios](https://help.aliyun.com/document_detail/130744.html).
        /// </summary>
        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        /// <summary>
        /// The ID of the region where the DTS instance resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// You must specify this parameter only if the **SourceEndpointEngineName** parameter is set to **Oracle**. Valid values:
        /// 
        /// *   **SID**: non-RAC architecture
        /// *   **RAC**: RAC architecture
        /// 
        /// >  This parameter is optional.
        /// </summary>
        [NameInMap("SourceEndpointArchitecture")]
        [Validation(Required=false)]
        public string SourceEndpointArchitecture { get; set; }

        /// <summary>
        /// The name of the source database or the authentication database.
        /// 
        /// > 
        /// *   You must specify this parameter if the **SourceEndpointEngineName** parameter is set to **PostgreSQL** or **MongoDB**. You must also specify this parameter if the **SourceEndpointInstanceType** parameter is set to **PolarDB_o**.
        /// *   If the **SourceEndpointEngineName** parameter is set to **PostgreSQL** or **DRDS**, specify the name of the source database. If the SourceEndpointEngineName parameter is set to **MongoDB**, specify the name of the authentication database.
        /// *   If the **SourceEndpointInstanceType** parameter is set to **PolarDB_o**, specify the name of the source database.
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// The engine type of the source database. Valid values: **MySQL**, **TiDB**, **SQLServer**, **PostgreSQL**, **Oracle**, **MongoDB**, and **Redis**.
        /// 
        /// >  Default value: **MySQL**.
        /// </summary>
        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        /// <summary>
        /// The endpoint of the source database.
        /// 
        /// >  You must specify this parameter only if the **SourceEndpointInstanceType** parameter is set to **LocalInstance** or **Express**.
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// The ID of the source instance.
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// The type of the source instance. Valid values:
        /// 
        /// *   **RDS**: ApsaraDB RDS instance
        /// *   **LocalInstance**: self-managed database with a public IP address
        /// *   **ECS**: self-managed database that is hosted on ECS
        /// *   **Express**: self-managed database that is connected over Express Connect
        /// *   **dg**: self-managed database that is connected over Database Gateway
        /// *   **MongoDB**: ApsaraDB for MongoDB instance
        /// *   **POLARDB**: PolarDB for MySQL cluster
        /// *   **PolarDB_o**: PolarDB for Oracle cluster
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        /// <summary>
        /// The SID of the Oracle database.
        /// 
        /// >  You must specify this parameter only if the **SourceEndpointEngineName** parameter is set to **Oracle** and the Oracle database is deployed in a non-RAC architecture.
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// The password of the source database account.
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// The service port number of the source database.
        /// 
        /// >  You must specify this parameter only if the **SourceEndpointInstanceType** parameter is set to **ECS**, **LocalInstance**, or **Express**.
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public string SourceEndpointPort { get; set; }

        /// <summary>
        /// The ID of the region where the source instance resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// The database account of the source database.
        /// 
        /// >  The permissions that are required for database accounts vary with the migration or synchronization scenario. For more information, see [Overview of data migration scenarios](https://help.aliyun.com/document_detail/26618.html) and [Overview of data synchronization scenarios](https://help.aliyun.com/document_detail/130744.html).
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

    }

}
