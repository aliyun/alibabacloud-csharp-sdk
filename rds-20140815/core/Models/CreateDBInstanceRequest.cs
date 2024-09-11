// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// The number of ApsaraDB RDS for MySQL instances that you want to create. The parameter takes effect only when you create multiple ApsaraDB RDS for MySQL instances at a time by using a single request.
        /// 
        /// Valid values: **1** to **20**. Default value: **1**.
        /// 
        /// > *   If you want to create multiple ApsaraDB RDS for MySQL instances at a time by using a single request, you can add tags to all the instances by using the **Tag.Key** parameter and the **Tag.Value** parameter. After the instances are created, you can manage the instances based on the tags.
        /// > *   After you submit a request to create multiple ApsaraDB RDS for MySQL instances, this operation returns **TaskId**, **RequestId**, and **Message**. You can call the DescribeDBInstanceAttribute operation to query the information about an instance.
        /// > *   If the value of the **Engine** parameter is not **MySQL** and the value of the Amount parameter is greater than **1**, this operation fails and returns an error code `InvalidParam.Engine`.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// Specifies whether to automatically create a database proxy. Valid values:
        /// 
        /// *   **true**: automatically creates a database proxy. By default, a general-purpose database proxy is created.
        /// *   **false**: does not automatically create a database proxy.
        /// </summary>
        [NameInMap("AutoCreateProxy")]
        [Validation(Required=false)]
        public bool? AutoCreateProxy { get; set; }

        /// <summary>
        /// Specifies whether to enable the automatic payment feature. Valid values:
        /// 
        /// *   **true**: enables the feature. You must make sure that your account balance is sufficient.
        /// *   **false**: disables the feature. An unpaid order is generated.
        /// 
        /// >  Default value: true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the instance. You must specify this parameter only if the instance uses the subscription billing method. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// > *   The auto-renewal cycle is one month for a monthly subscription.
        /// > *   The auto-renewal cycle is one year for a yearly subscription.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The configuration of the Babelfish feature for the instance that runs PostgreSQL.
        /// 
        /// Format:{"babelfishEnabled":"true","migrationMode":"xxxxxxx","masterUsername":"xxxxxxx","masterUserPassword":"xxxxxxxx"}
        /// 
        /// The following list describes the fields in the format:
        /// 
        /// *   **babelfishEnabled**: specifies whether to enable Babelfish for the instance. If you set this field to **true**, you enable Babelfish for the instance. If you leave this parameter empty, Babelfish is disabled for the instance.
        /// *   **migrationMode**: The migration mode of the instance. Valid values: **single-db** and **multi-db**.
        /// *   **masterUsername**: The username of the administrator account. The username can contain lowercase letters, digits, and underscores (_). It must start with a letter and end with a letter or digit. It can be up to 63 characters in length and cannot start with pg.
        /// *   **masterUserPassword**: The password of the administrator account. The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. It must be 8 to 32 characters in length. The password can contain any of the following characters: `! @ # $ % ^ & * ( ) _ + - =`.
        /// 
        /// > This parameter applies only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for ApsaraDB RDS for PostgreSQL, see [Introduction to Babelfish](https://help.aliyun.com/document_detail/428613.html).
        /// </summary>
        [NameInMap("BabelfishConfig")]
        [Validation(Required=false)]
        public string BabelfishConfig { get; set; }

        /// <summary>
        /// A deprecated parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("BpeEnabled")]
        [Validation(Required=false)]
        public string BpeEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable the I/O burst feature of general ESSDs. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// >  For more information about the I/O burst feature of general ESSDs, see [What are general ESSDs?](https://help.aliyun.com/document_detail/2340501.html)
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// The additional business information about the instance.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   Regular RDS instance
        /// 
        ///     *   **Basic**: RDS Basic Edition
        ///     *   **HighAvailability**: RDS High-availability Edition
        ///     *   **cluster**: RDS Cluster Edition for ApsaraDB RDS for MySQL or PostgreSQL
        ///     *   **AlwaysOn**: RDS Cluster Edition for ApsaraDB RDS for SQL Server
        ///     *   **Finance**: RDS Basic Edition for serverless instances
        /// 
        /// *   Serverless instance
        /// 
        ///     *   **serverless_basic**: RDS Basic Edition for serverless instances. This edition is available only for instances that run MySQL and PostgreSQL.
        ///     *   **serverless_standard**: RDS High-availability Edition for serverless instances. This edition is available only for instances that run MySQL and PostgreSQL.
        ///     *   **serverless_ha**: RDS High-availability Edition for serverless instances. This edition is available only for instances that run SQL Server.
        /// 
        ///     **
        /// 
        ///     **Note** This parameter is required when you create a serverless instance.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to enable the data archiving feature of general ESSDs. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// >  For more information about the data archiving feature of general ESSDs, see [Use the data archiving feature of general ESSDs](https://help.aliyun.com/document_detail/2701832.html).
        /// </summary>
        [NameInMap("ColdDataEnabled")]
        [Validation(Required=false)]
        public bool? ColdDataEnabled { get; set; }

        /// <summary>
        /// The connection mode of the instance. Valid values:
        /// 
        /// *   **Standard**: standard mode
        /// *   **Safe**: database proxy mode
        /// 
        /// ApsaraDB RDS automatically assigns a connection mode to the instance.
        /// 
        /// > SQL Server 2012, SQL Server 2016, and SQL Server 2017 support only the standard mode.
        /// </summary>
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// The internal endpoint that is used to connect to the instance.
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The policy based on which multiple instances are created. The parameter takes effect only when the value of the **Amount** parameter is greater than 1. Valid values:
        /// 
        /// *   **Atomicity** (default): atomicity. The instances are all created together. If one instance cannot be created, none of the instances are created.
        /// *   **Partial**: non-atomicity. Each instance is independently created. The failure in creating an instance does not affect the creation of the other instances.
        /// </summary>
        [NameInMap("CreateStrategy")]
        [Validation(Required=false)]
        public string CreateStrategy { get; set; }

        /// <summary>
        /// The instance type of the instance. You can specify an instance type of the standard or YiTian product type. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html).
        /// 
        /// To create a serverless instance, set this parameter to one of the following values:
        /// 
        /// *   If you want to create a serverless instance that runs MySQL on RDS Basic Edition, set this parameter to **mysql.n2.serverless.1c**.
        /// *   If you want to create a serverless instance that runs MySQL on RDS High-availability Edition, set this parameter to **mysql.n2.serverless.2c**.
        /// *   If you want to create a serverless instance that runs SQL Server, set this parameter to **mssql.mem2.serverless.s2**.
        /// *   If you want to create a serverless instance that runs PostgreSQL on RDS Basic Edition, set this parameter to **pg.n2.serverless.1c**.
        /// *   If you want to create a serverless instance that runs PostgreSQL on RDS High-availability Edition, set this parameter to **pg.n2.serverless.2c**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The instance name. The name must be 2 to 255 characters in length and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.
        /// 
        /// > The name cannot start with http:// or https://.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// The network connection type of the instance. The value of this parameter is fixed as **Intranet**, indicating an internal network connection.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Unit: GB. The storage capacity increases in increments of 5 GB. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **local_ssd**: local SSD. This is the recommended storage type.
        /// *   **general_essd**: general Enterprise SSD (ESSD). This is the recommended storage type.
        /// *   **cloud_essd**: PL1 ESSD
        /// *   **cloud_essd2**: PL2 ESSD
        /// *   **cloud_essd3**: PL3 ESSD
        /// *   **cloud_ssd**: standard SSD. This storage type is not recommended. Standard SSDs are no longer available for purchase in some Alibaba Cloud regions.
        /// 
        /// The default value of this parameter is determined by the instance type specified by the **DBInstanceClass** parameter.
        /// 
        /// *   If the instance type specifies the local SSD storage type, the default value of this parameter is **local_ssd**.
        /// *   If the instance type specifies the standard SSD or ESSD storage type, the default value of this parameter is **cloud_essd**.
        /// 
        /// >  Serverless instances support only PL1 ESSDs and general ESSDs.
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// Specifies whether the table name is case-sensitive. Valid values:
        /// 
        /// *   **true**: Table names are not case-sensitive. This is the default value.
        /// *   **false**: Table names are case-sensitive.
        /// </summary>
        [NameInMap("DBIsIgnoreCase")]
        [Validation(Required=false)]
        public string DBIsIgnoreCase { get; set; }

        /// <summary>
        /// The parameter template ID. You can call the DescribeParameterGroups operation to query the parameter template ID.
        /// 
        /// >  This parameter is available if you want to create an instance that runs MySQL or PostgreSQL. If you do not configure this parameter, the default parameter template is used. If you want to use a custom parameter template, you can customize a parameter template and set this parameter to the ID of the custom template.
        /// </summary>
        [NameInMap("DBParamGroupId")]
        [Validation(Required=false)]
        public string DBParamGroupId { get; set; }

        /// <summary>
        /// The time zone of the instance. This parameter takes effect only when you set the **Engine** parameter to **MySQL** or **PostgreSQL**.
        /// 
        /// *   If you set **Engine** to **MySQL**:
        /// 
        ///     *   The time zone of the instance is in UTC. Valid values: **-12:59** to **+13:00**.
        ///     *   If the instance uses local SSDs, you can specify the name of the time zone. Example: Asia/Hong_Kong. For more information, see [Time zones](https://help.aliyun.com/document_detail/297356.html).
        /// 
        /// *   If you set **Engine** to **PostgreSQL**:
        /// 
        ///     *   The time zone of the instance is not in UTC. For more information, see [Time zones](https://help.aliyun.com/document_detail/297356.html).
        ///     *   You can specify this parameter only when the instance runs PostgreSQL with standard SSDs or ESSDs.
        /// 
        /// > *   You can specify the time zone when you create a primary instance. You cannot specify the time zone when you create a read-only instance. Read-only instances inherit the time zone of their primary instance.
        /// > *   If you do not specify this parameter, the system automatically assigns the default time zone of the region in which the instance resides.
        /// </summary>
        [NameInMap("DBTimeZone")]
        [Validation(Required=false)]
        public string DBTimeZone { get; set; }

        /// <summary>
        /// The ID of the dedicated cluster to which the instance belongs.
        /// 
        /// If you create the instance in a dedicated cluster, you must specify this parameter.
        /// 
        /// *   You can call the DescribeDedicatedHostGroups operation to query the information about the dedicated cluster.
        /// *   If no dedicated clusters are created, you can call the CreateDedicatedHostGroup operation to create a dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// Specifies whether to enable the release protection feature for the instance. This feature is available only for pay-as-you-go instances. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run but does not create the instance. The system checks items such as the request parameters, request format, service limits, and available resources.
        /// *   **false** (default): performs a dry run and sends the request. If the request passes the dry run, the instance is created.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the key that is used for cloud disk encryption in the region in which the instance is deployed. If this parameter is specified, cloud disk encryption is enabled and you must also specify the **RoleARN** parameter. Cloud disk encryption cannot be disabled after it is enabled.
        /// 
        /// You can obtain the ID of the key in the Key Management Service (KMS) console or create a key. For more information, see [Create a key](https://help.aliyun.com/document_detail/181610.html).
        /// 
        /// > *   This parameter is not required when you create an instance that runs MySQL, PostgreSQL, or SQL Server. You need to only specify the **RoleARN** parameter to create an instance that has cloud disk encryption enabled by using the obtained key ID.
        /// > *   You can configure RAM authorization to require a RAM user to enable cloud disk encryption when the RAM user is used to create an instance. If cloud disk encryption is disabled during the instance creation, the creation operation fails. To complete the configuration, you can attach the following policy to the RAM user: `{"Version":"1","Statement":[{"Effect":"Deny","Action":"rds:CreateDBInstance","Resource":"*","Condition":{"StringEquals":{"rds:DiskEncryptionRequired":"false"}}}]}`
        /// 
        /// 
        /// >Warning: The configuration also affects the CreateOrder operation that is called to create instances in the console.
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// The database engine of the instance. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **SQLServer**
        /// *   **PostgreSQL**
        /// *   **MariaDB**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version of the instance. Valid values:
        /// 
        /// *   Regular instance
        /// 
        ///     *   Valid values when you set Engine to MySQL: **5.5**, **5.6**, **5.7**, and **8.0**
        ///     *   Valid values when you set Engine to SQLServer: **08r2_ent_ha** (cloud disks, discontinued), **2008r2** (local disks, discontinued), **2012** (SQL Server EE Basic), **2012_ent_ha**, **2012_std_ha**, **2012_web**, **2014_ent_ha**, **2014_std_ha**, **2016_ent_ha**, **2016_std_ha**, **2016_web**, **2017_ent**, **2017_std_ha**, **2017_web**, **2019_ent**, **2019_std_ha**, **2019_web**, **2022_ent**, **2022_std_ha**, and **2022_web**
        ///     *   Valid values when you set Engine to PostgreSQL: **10.0**, **11.0**, **12.0**, **13.0**, **14.0**, **15.0**, and **16.0**
        ///     *   Valid value if you set Engine to MariaDB: **10.3**
        /// 
        /// *   Serverless instance
        /// 
        ///     *   Valid values when you set Engine to MySQL: **5.7** and **8.0**
        ///     *   Valid values when you set Engine to SQLServer: **2016_std_sl**, **2017_std_sl**, and **2019_std_sl**
        ///     *   Valid values when you set Engine to PostgreSQL: **14.0**, **15.0**, and **16.0**
        /// 
        /// > 
        /// 
        /// *   ApsaraDB RDS for MariaDB does not support serverless instances.
        /// 
        /// *   RDS instances that run SQL Server: `_ent` specifies SQL Server EE (Always On), `_ent_ha` specifies SQL Server EE, `_std_ha` specifies SQL Server SE, and `_web` specifies SQL Server Web.
        /// 
        /// *   RDS instances that run SQL Server 2014 are not available for purchase on the international site (alibabacloud.com).
        /// 
        /// *   Babelfish is supported only for RDS instances that run PostgreSQL 15.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **VPC**: virtual private cloud (VPC)
        /// *   **Classic**: the classic network
        /// 
        /// > 
        /// 
        /// *   If the instance runs MySQL and uses cloud disks, you must set this parameter to **VPC**.
        /// 
        /// *   If the instance runs PostgreSQL or MariaDB, you must set this parameter to **VPC**.
        /// 
        /// *   If the instance runs SQL Server Basic or SQL Server Web, you can set this parameter to VPC or Classic. If the instance runs other database engine, you must set this parameter to **VPC**.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// Specifies whether to enable the I/O acceleration feature of general ESSDs. Valid values:
        /// 
        /// *   **1**: enabled
        /// *   **0**: disabled
        /// 
        /// >  For more information about the I/O acceleration feature of general ESSDs, see [Introduction](https://help.aliyun.com/document_detail/2527067.html).
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go.
        /// *   **Prepaid**: subscription.
        /// *   **Serverless**: serverless. This value is not supported for instances that run MariaDB. For more information, see [Overview of serverless ApsaraDB RDS for MySQL instances](https://help.aliyun.com/document_detail/411291.html), [Overview of serverless ApsaraDB RDS for SQL Server instances](https://help.aliyun.com/document_detail/604344.html), and [Overview of serverless ApsaraDB RDS for PostgreSQL instances](https://help.aliyun.com/document_detail/607742.html).
        /// 
        /// > The system automatically generates a purchase order and completes the payment.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The unit of the subscription duration. Valid values:
        /// 
        /// *   **Year**
        /// *   **Month**
        /// 
        /// >  If you set the PayType parameter to **Prepaid**, you must also specify this parameter.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The port. You can initialize the port when you create the instance.
        /// 
        /// *   Valid values if the instance runs MySQL: 1000 to 65534
        /// *   Valid values if the instance runs PostgreSQL, SQL Server, or MariaDB: 1000 to 5999
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The private IP address of the instance. The private IP address must be within the CIDR block that is supported by the specified vSwitch. ApsaraDB RDS automatically assigns a private IP address to the instance based on the values of the **VPCId** and **vSwitchId** parameters.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// 
        /// This parameter is required.
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

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) that is provided by your Alibaba Cloud account for RAM users. RAM users can use the ARN to connect ApsaraDB RDS to KMS. You can call the CheckCloudResourceAuthorized operation to query the ARN.
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// The IP address whitelist of the instance. For more information, see [Use a database client or the CLI to connect to an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/43185.html). If the IP address whitelist contains more than one entry, separate the entries with commas (,). Each entry must be unique. The IP address whitelist can contain up to 1,000 entries. The entries in the IP address whitelist must be in one of the following formats:
        /// 
        /// *   IP addresses, such as 10.10.XX.XX.
        /// *   CIDR blocks, such as 10.10.XX.XX/24. In this example, 24 indicates that the prefix of each IP address in the IP address whitelist is 24 bits in length. You can replace 24 with a value within the range of 1 to 32.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// The settings of the serverless instance. This parameter is required when you create a serverless instance.
        /// 
        /// >  ApsaraDB RDS for MariaDB does not support serverless instances.
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public CreateDBInstanceRequestServerlessConfig ServerlessConfig { get; set; }
        public class CreateDBInstanceRequestServerlessConfig : TeaModel {
            /// <summary>
            /// Specifies whether to enable the automatic startup and stop feature for the serverless instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// >  This parameter is required only for serverless instances that run MySQL and PostgreSQL. After the automatic start and stop feature is enabled, if no connections to the instance are established within 10 minutes, the instance is suspended. After a connection to the instance is established, the instance is resumed.
            /// </summary>
            [NameInMap("AutoPause")]
            [Validation(Required=false)]
            public bool? AutoPause { get; set; }

            /// <summary>
            /// The maximum number of RDS Capacity Units (RCUs). Valid values:
            /// 
            /// *   Serverless ApsaraDB RDS for MySQL instances: **1 to 32**
            /// *   Serverless ApsaraDB RDS for SQL Server instances: **2 to 8**
            /// *   Serverless ApsaraDB RDS for PostgreSQL instances: **1 to 14**
            /// 
            /// >  The value of this parameter must be greater than or equal to the value of the **MinCapacity** parameter and can be set only to an **integer**.
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public double? MaxCapacity { get; set; }

            /// <summary>
            /// The minimum number of RCUs. Valid values:
            /// 
            /// *   Serverless ApsaraDB RDS for MySQL instances: **0.5 to 32**.
            /// *   Serverless ApsaraDB RDS for SQL Server instances: **2 to 8**. Only integers are supported.
            /// *   Serverless ApsaraDB RDS for PostgreSQL instances: **0.5 to 14**.
            /// 
            /// >  The value of this parameter must be less than or equal to the value of the **MaxCapacity** parameter.
            /// </summary>
            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public double? MinCapacity { get; set; }

            /// <summary>
            /// Specifies whether to enable the forced scaling feature for the serverless instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > 
            /// 
            /// *   This parameter is required only for serverless instances that run MySQL and PostgreSQL. If you set this parameter to true, a service interruption that lasts approximately 30 to 120 seconds occurs during forced scaling. Process with caution.
            /// 
            /// *   The RCU scaling for a serverless instance immediately takes effect. In some cases, such as the execution of large transactions, the scaling does not immediately take effect. In this case, you can enable this feature to forcefully scale the RCUs of the instance.
            /// </summary>
            [NameInMap("SwitchForce")]
            [Validation(Required=false)]
            public bool? SwitchForce { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable the automatic storage expansion feature for the instance. If the instance runs MySQL or PostgreSQL, this feature is supported. Valid values:
        /// 
        /// *   **Enable**
        /// *   **Disable** (default)
        /// 
        /// >  After the instance is created, you can call the ModifyDasInstanceConfig operation to adjust the settings. For more information, see [Configure automatic storage expansion](https://help.aliyun.com/document_detail/173826.html).
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// The threshold in percentage based on which automatic storage expansion is triggered. Valid values:
        /// 
        /// *   **10**
        /// *   **20**
        /// *   **30**
        /// *   **40**
        /// *   **50**
        /// 
        /// >  If you set the **StorageAutoScale** parameter to **Enable**, you must also specify this parameter.
        /// </summary>
        [NameInMap("StorageThreshold")]
        [Validation(Required=false)]
        public int? StorageThreshold { get; set; }

        /// <summary>
        /// The maximum storage capacity that is allowed for automatic storage expansion. The storage capacity of the instance cannot exceed the maximum storage capacity. Unit: GB.
        /// 
        /// > *   Valid values: an integer greater than or equal to 0.
        /// > *   If you set **StorageAutoScale** to **Enable**, you must specify this parameter.
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public int? StorageUpperBound { get; set; }

        /// <summary>
        /// A deprecated parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("SystemDBCharset")]
        [Validation(Required=false)]
        public string SystemDBCharset { get; set; }

        /// <summary>
        /// The tags that are added to instances.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// The tag key. You can use this parameter to add tags to the instance.
            /// 
            /// *   If the specified tag key is an existing key, the system directly adds the tag key to the instance. You can call the ListTagResources to query the existing tag.
            /// *   If the specified tag key does not exist, the system creates the tag key and adds the tag key to the instance.
            /// *   The value cannot be an empty string.
            /// *   This parameter must be used together with the **Tag.Value** parameter.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. You can use this parameter to add tags to the instance.
            /// 
            /// *   If the specified tag value is found in the specified tag key, the system directly adds the tag value to the instance. You can call the ListTagResources to query the existing tag.
            /// *   If the specified tag value is not found in the specified tag key, the system creates the tag value and adds the tag value to the instance.
            /// *   This parameter must be used together with the **Tag.Key** parameter.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the host to which the logger instance belongs in the specified dedicated cluster.
        /// 
        /// If you want to create an instance that runs RDS Enterprise Edition in a dedicated cluster, you must specify this parameter. If you do not specify this parameter, the system automatically assigns a host.
        /// 
        /// *   You can call the DescribeDedicatedHosts operation to query the host in the dedicated cluster.
        /// *   If no hosts are created, you can call the CreateDedicatedHost operation to create a host.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForLog")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForLog { get; set; }

        /// <summary>
        /// The ID of the host to which the instance belongs in the specified dedicated cluster.
        /// 
        /// If you create the instance in a dedicated cluster, you must specify this parameter. If you do not specify this parameter, the system automatically assigns a host.
        /// 
        /// *   You can call the DescribeDedicatedHosts operation to query the host in the dedicated cluster.
        /// *   If no hosts are created, you can call the CreateDedicatedHost operation to create a host.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// The ID of the host to which the secondary instance belongs in the specified dedicated cluster.
        /// 
        /// If you want to create an instance that runs RDS High-availability Edition or RDS Enterprise Edition in a dedicated cluster, you must specify this parameter. If you do not specify this parameter, the system automatically assigns a host.
        /// 
        /// *   You can call the DescribeDedicatedHosts operation to query the host in the dedicated cluster.
        /// *   If no hosts are created, you can call the CreateDedicatedHost operation to create a host.
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// The minor engine version of the instance. This parameter is required only when you create an instance that runs MySQL or PostgreSQL. The value format varies based on the database engine of the instance.
        /// 
        /// *   If you create an instance that runs MySQL, the value is in the following format: `<RDS edition>_<Minor engine version>`. Examples: `rds_20200229`, `xcluster_20200229`, and `xcluster80_20200229`.
        /// 
        ///     *   rds: The instance runs RDS Basic Edition or RDS High-availability Edition.
        ///     *   xcluster: The instance runs MySQL 5.7 on RDS Enterprise Edition.
        ///     *   xcluster80: The instance runs MySQL 8.0 on RDS Enterprise Edition.
        /// 
        ///     > You can call the DescribeDBMiniEngineVersions operation to query the minor engine version. For more information about the differences between minor engine versions of AliSQL, see [Release notes](https://help.aliyun.com/document_detail/96060.html).
        /// 
        /// *   If you create an instance that runs PostgreSQL, the value is in the following format: `rds_postgres_<Major engine version>00_<Minor engine version>`. Example: `rds_postgres_1400_20220830`.
        /// 
        ///     *   1400: The major engine version is PostgreSQL 14.
        ///     *   20220830: the AliPG version. You can call the DescribeDBMiniEngineVersions operation to query the AliPG version. For more information about minor engine versions, see [Release notes for AliPG](https://help.aliyun.com/document_detail/126002.html).
        /// 
        ///     > If you configure the **BabelfishConfig** parameter for your instance that runs PostgreSQL and set the babelfishEnabled field to true, the value of this parameter is in the following format: `rds_postgres_Major engine version00_AliPG version_babelfish`.
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// The subscription duration of the instance. Valid values:
        /// 
        /// *   If you set the **Period** parameter to **Year**, the value of the **UsedTime** parameter ranges from **1 to 5**.
        /// *   If you set the **Period** parameter to **Month**, the value of the **UsedTime** parameter ranges from **1 to 11**.
        /// 
        /// >  If you set the PayType parameter to **Prepaid**, you must also specify this parameter.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The ID of the full backup file. You can call the ListUserBackupFiles operation to query the ID of the full backup file. If you want to create an instance by using the data of a backup file, you must specify this parameter.
        /// 
        /// This parameter is supported only when the following requirements are met:
        /// 
        /// *   The **PayType** parameter is set to **Postpaid**.
        /// *   The **Engine** parameter is set to **MySQL**.
        /// *   The **EngineVersion** parameter is set to **5.7**.
        /// *   The **Category** parameter is set to **Basic**.
        /// </summary>
        [NameInMap("UserBackupId")]
        [Validation(Required=false)]
        public string UserBackupId { get; set; }

        /// <summary>
        /// The ID of the VPC to which the instance belongs.
        /// 
        /// > This parameter is available when you set the **InstanceNetworkType** parameter to **VPC**.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The ID of the vSwitch. The vSwitch must belong to the zone that is specified by **ZoneId**.
        /// 
        /// *   If you set **InstanceNetworkType** to **VPC**, you must also specify this parameter.
        /// *   If you specify the ZoneSlaveId1 parameter, you must specify the IDs of two vSwitches for this parameter and separate the IDs with a comma (,).
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The entries in the whitelist. If you enter multiple IP addresses or CIDR blocks, you must separate the IP addresses or CIDR blocks with commas (,). Do not add spaces preceding or following the commas. Example: `192.168.0.1,172.16.213.9`.
        /// </summary>
        [NameInMap("WhitelistTemplateList")]
        [Validation(Required=false)]
        public string WhitelistTemplateList { get; set; }

        /// <summary>
        /// The zone ID of the primary instance.
        /// 
        /// *   If you specify a virtual private cloud (VPC) and a vSwitch, you must specify the ID of the zone to which the specified vSwitch belongs. Otherwise, the instance cannot be created.
        /// *   If the instance runs RDS High-availability Edition, you must specify the **ZoneIdSlave1** parameter. The ZoneIdSlave1 parameter specifies whether to use the single-zone deployment method or the multi-zone deployment method.
        /// *   If the instance runs RDS Enterprise Edition, you must specify the **ZoneIdSlave1** and **ZoneIdSlave2** parameters. The ZoneIdSlave1 and ZoneIdSlave2 parameters specify whether to use the single-zone deployment method or the multi-zone deployment method.
        /// *   If the instance runs MySQL on RDS Cluster Edition, you must specify the **ZoneIdSlave1** parameter for the RDS cluster that has two nodes and the **ZoneIdSlave1** and **ZoneIdSlave2** parameters for the RDS cluster that has three nodes.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// The zone ID of the secondary instance.
        /// 
        /// *   If you set this parameter to **Auto**, the multi-zone deployment method is used and the zone of the secondary instance is automatically configured.
        /// *   If you set this parameter to the same value as the **ZoneId** parameter, the single-zone deployment method is used.
        /// *   If you set this parameter to a value that is different from the value of the **ZoneId** parameter, the multiple-zone deployment method is used.
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
