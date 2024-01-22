// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable or disable the database proxy feature. Valid values:
        /// 
        /// *   **Startup**: enables the database proxy feature.
        /// *   **Shutdown**: disables the database proxy feature.
        /// </summary>
        [NameInMap("ConfigDBProxyService")]
        [Validation(Required=false)]
        public string ConfigDBProxyService { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The number of proxy instances that are enabled. Valid values: **1** to **16**. Default value: **1**.
        /// 
        /// >  The capability of the database proxy to process requests increases with the number of proxy instances that are enabled. You can monitor the load on the instance and specify an appropriate number of proxy instances based on the load monitoring data.
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public string DBProxyInstanceNum { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// The network type of the instance. Set the value to **VPC**.
        /// 
        /// > This parameter is required if you enable the database proxy feature for an ApsaraDB RDS for MySQL instance that uses cloud disks or an ApsaraDB RDS for PostgreSQL instance.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Whether to enable connection keep. Valid values:
        /// 
        /// - Enabled: enables connection keeping
        /// - Disabled: disables connection hold
        /// 
        /// > - This parameter is supported only for an ApsaraDB RDS for MySQL.
        /// > - When you modify the connection persistence state, the value of **ConfigDBProxyService** is modify.
        /// </summary>
        [NameInMap("PersistentConnectionStatus")]
        [Validation(Required=false)]
        public string PersistentConnectionStatus { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the instance belongs. You can call the DescribeDBInstanceAttribute operation to query the VPC ID.
        /// 
        /// >  This parameter is required if you enable the database proxy feature for an ApsaraDB RDS for MySQL instance that uses cloud disks or an ApsaraDB RDS for PostgreSQL instance.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The vSwitch ID of the instance. You can call the DescribeDBInstanceAttribute operation to query the vSwitch ID.
        /// 
        /// >  This parameter is required if you enable the database proxy feature for an ApsaraDB RDS for MySQL instance that uses cloud disks or an ApsaraDB RDS for PostgreSQL instance.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
