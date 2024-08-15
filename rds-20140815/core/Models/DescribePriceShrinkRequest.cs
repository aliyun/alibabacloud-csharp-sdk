// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePriceShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The commodity code of the instance. Valid values:
        /// 
        /// *   **bards**: The instance is a pay-as-you-go primary instance. This value is available at the China site (aliyun.com).
        /// *   **rds** (default): The instance is a subscription primary instance. This value is available on the China site (aliyun.com).
        /// *   **rords**: The instance is a pay-as-you-go read-only instance. This value is available at the China site (aliyun.com).
        /// *   **rds_rordspre_public_cn**: The instance is a subscription read-only instance. This value is available at the China site (aliyun.com).
        /// *   **bards_intl**: The instance is a pay-as-you-go primary instance. This value is available at the international site (alibabacloud.com).
        /// *   **rds_intl**: The instance is a subscription primary instance. This value is available at the international site (alibabacloud.com).
        /// *   **rords_intl**: The instance is a pay-as-you-go read-only instance. This value is available at the international site (alibabacloud.com).
        /// *   **rds_rordspre_public_intl**: The instance is a subscription read-only instance. This value is available on the international site (alibabacloud.com).
        /// 
        /// >  If you want to query the price of a read-only instance, you must specify this parameter.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The instance type of the instance. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The ID of the instance for which you want to change the specifications or the instance that you want to renew.
        /// 
        /// > *   If you want to query the price of a specification change order or a renewal order, you must specify this parameter.
        /// > *   If the instance is a read-only instance, you must set this parameter to the ID of its primary instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Unit: GB. You can increase the storage capacity at a step size of 5 GB. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **local_ssd**: local SSD
        /// *   **cloud_ssd**: standard SSD
        /// *   **cloud_essd**: PL1 ESSD
        /// *   **cloud_essd2**: PL2 ESSD
        /// *   **cloud_essd3**: PL3 ESSD
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// The information about the node.
        /// 
        /// >  This parameter is supported for ApsaraDB RDS for MySQL instances that run RDS Cluster Edition.
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public string DBNodeShrink { get; set; }

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
        /// The database engine version of the instance.
        /// 
        /// *   Valid values if you set Engine to **MySQL**: **5.5**, **5.6**, **5.7**, and **8.0**
        /// *   Valid values if you set Engine to **SQLServer**: **08r2_ent_ha** (cloud disks, discontinued), **2008r2**(local disks, discontinued), **2012** (SQL Server EE Basic), **2012_ent_ha**, **2012_std_ha**, **2012_web**, **2016_ent_ha**, **2016_std_ha**, **2016_web**, **2017_ent**, **2017_std_ha**, **2017_web**, **2019_ent**, **2019_std_ha**, **2019_web**, **2022_ent**, **2022_std_ha**, and **2022_web**
        /// *   Valid values if you set Engine to **PostgreSQL**: **10.0**, **11.0**, **12.0**, **13.0**, **14.0**, and **15.0**
        /// *   Valid value if you set Engine to **MariaDB**: **10.3**
        /// 
        /// >  The following information describes the valid values when you set Engine to SQLServer: `_ent` specifies SQL Server EE on RDS Cluster Edition, `_ent_ha` specifies SQL Server EE, `_std_ha` specifies SQL Server SE, and `_web` specifies SQL Server Web.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The role of the instance. Valid values:
        /// 
        /// *   **0**: primary instance
        /// *   **3**: read-only instance
        /// </summary>
        [NameInMap("InstanceUsedType")]
        [Validation(Required=false)]
        public int? InstanceUsedType { get; set; }

        /// <summary>
        /// The order type. Valid values:
        /// 
        /// *   **BUY**: purchase order
        /// *   **UPGRADE**: specification change order
        /// *   **RENEW**: renewal order
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **Prepaid**: subscription
        /// *   **Postpaid**: pay-as-you-go
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The number of instances that you want to purchase. Valid values: **0 to 30**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The settings of the serverless instance.
        /// 
        /// > ApsaraDB RDS for MariaDB does not support serverless instances.
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public string ServerlessConfigShrink { get; set; }

        /// <summary>
        /// The billing cycle of the subscription instance. This parameter is required when **CommodityCode** is set to **rds**, **rds_rordspre_public_cn**, **rds_intl**, or **rds_rordspre_public_intl**. Valid values:
        /// 
        /// *   **Year**
        /// *   **Month**
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public string TimeType { get; set; }

        /// <summary>
        /// The subscription duration of the instance.
        /// 
        /// *   If you set the **TimeType** parameter to **Year**, the value of the UsedTime parameter ranges from **1 to 100**.
        /// *   If you set the **TimeType** parameter to **Month**, the value of the UsedTime parameter ranges from **1 to 999**.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// The zone ID of the primary instance. You can call the DescribeRegions operation to query the most recent zone list.
        /// 
        /// >  If you specify a virtual private cloud (VPC) and a vSwitch, this parameter is required to identify the zone for the vSwitch.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
