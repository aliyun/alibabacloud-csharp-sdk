// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class RegisterInstanceRequest : TeaModel {
        /// <summary>
        /// The name of the data link for cross-database query.
        /// 
        /// > 
        /// *   This parameter is required if the UseDsql parameter is set to 1.
        /// *   The name can contain only lowercase letters and underscores (\_).
        /// *   The name must be unique within a tenant.
        /// </summary>
        [NameInMap("DataLinkName")]
        [Validation(Required=false)]
        public string DataLinkName { get; set; }

        /// <summary>
        /// The password that is used to log on to the database.
        /// </summary>
        [NameInMap("DatabasePassword")]
        [Validation(Required=false)]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// The account that is used to log on to the database.
        /// </summary>
        [NameInMap("DatabaseUser")]
        [Validation(Required=false)]
        public string DatabaseUser { get; set; }

        /// <summary>
        /// The ID of the user who assumes the DBA role of the database instance. You can call the [ListUsers](~~141938~~) or [GetInstance](~~141567~~) operation to obtain the user ID.
        /// </summary>
        [NameInMap("DbaUid")]
        [Validation(Required=false)]
        public long? DbaUid { get; set; }

        /// <summary>
        /// Specifies whether to enable the lock-free schema change feature for the database instance. Valid values:
        /// 
        /// *   0: The feature is disabled.
        /// *   1: The native online DDL feature takes precedence.
        /// *   2: The lock-free schema change feature of DMS takes precedence.
        /// 
        /// >  Supported database types: ApsaraDB RDS for MySQL, PolarDB for MySQL, ApsaraDB MyBase for MySQL, and MySQL databases from other sources.
        /// </summary>
        [NameInMap("DdlOnline")]
        [Validation(Required=false)]
        public int? DdlOnline { get; set; }

        /// <summary>
        /// The ID of the ECS instance.
        /// 
        /// >  This parameter is required if the InstanceSource parameter is set to ECS_OWN.
        /// </summary>
        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region in which the database instance resides.
        /// 
        /// >  This parameter is required if the InstanceSource parameter is set to RDS, ECS_OWN, or VPC_IDC.
        /// </summary>
        [NameInMap("EcsRegion")]
        [Validation(Required=false)]
        public string EcsRegion { get; set; }

        [NameInMap("EnableSellSitd")]
        [Validation(Required=false)]
        public string EnableSellSitd { get; set; }

        /// <summary>
        /// The type of the environment to which the database instance belongs. Valid values:
        /// 
        /// *   product: production environment
        /// *   dev: development environment
        /// *   pre: staging environment
        /// *   test: test environment
        /// *   sit: system integration testing (SIT) environment
        /// *   uat: user acceptance testing (UAT) environment
        /// *   pet: stress testing environment
        /// *   stag: STAG environment
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// The timeout period for exporting data from the database instance. Unit: seconds.
        /// </summary>
        [NameInMap("ExportTimeout")]
        [Validation(Required=false)]
        public int? ExportTimeout { get; set; }

        /// <summary>
        /// The host address that is used to connect to the database instance.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The alias of the database instance. Specify an alias that can help you identify the database instance in DMS.
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// The source of the database instance. Valid values:
        /// 
        /// *   **PUBLIC_OWN**: a self-managed database instance that is deployed on the Internet
        /// *   **RDS**: an ApsaraDB RDS instance
        /// *   **ECS_OWN**: a self-managed database that is deployed on an Elastic Compute Service (ECS) instance
        /// *   **VPC_IDC**: a self-managed database instance that is deployed in a data center connected over a virtual private cloud (VPC)
        /// </summary>
        [NameInMap("InstanceSource")]
        [Validation(Required=false)]
        public string InstanceSource { get; set; }

        /// <summary>
        /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The network type of the database instance. Valid values:
        /// 
        /// *   **CLASSIC**: classic network
        /// *   **VPC**: VPC
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The port number that is used to connect to the database instance.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The timeout period for querying data in the database instance. Unit: seconds.
        /// </summary>
        [NameInMap("QueryTimeout")]
        [Validation(Required=false)]
        public int? QueryTimeout { get; set; }

        /// <summary>
        /// The name of the security rule set for the database. You can call the [ListStandardGroups](~~417891~~) or [GetInstance](~~141567~~) operation to obtain the name of the security rule set that you want to use.
        /// </summary>
        [NameInMap("SafeRule")]
        [Validation(Required=false)]
        public string SafeRule { get; set; }

        /// <summary>
        /// The system ID (SID) of the database.
        /// 
        /// >  This parameter is required if the InstanceType parameter is set to ORACLE.
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// Specifies whether to skip connectivity test. Valid values:
        /// 
        /// *   **true**: The connectivity test is skipped.
        /// *   **false**: The connectivity test is not skipped.
        /// </summary>
        [NameInMap("SkipTest")]
        [Validation(Required=false)]
        public bool? SkipTest { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// Specifies whether to enable the cross-database query feature for the database instance. Valid values:
        /// 
        /// *   0: The feature is disabled.
        /// *   1: The feature is enabled.
        /// 
        /// >  Supported database types: MySQL, SQL Server, PostgreSQL, PolarDB for Oracle, and ApsaraDB for Redis.
        /// </summary>
        [NameInMap("UseDsql")]
        [Validation(Required=false)]
        public int? UseDsql { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// 
        /// >  This parameter is required if the InstanceSource parameter is set to VPC_IDC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
