// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableClassesRequest : TeaModel {
        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   Regular instance
        /// 
        ///     *   **Basic**: RDS Basic Edition
        ///     *   **HighAvailability**: RDS High-availability Edition
        ///     *   **cluster**: RDS Cluster Edition for ApsaraDB RDS for MySQL
        ///     *   **AlwaysOn**: RDS Cluster Edition for ApsaraDB RDS for SQL Server
        ///     *   **Finance**: RDS Enterprise Edition
        /// 
        /// *   Serverless instance
        /// 
        ///     *   **serverless_basic**: RDS Basic Edition. This edition is available only for serverless instances that run MySQL and PostgreSQL.
        ///     *   **serverless_standard**: RDS High-availability Edition for ApsaraDB RDS for MySQL.
        ///     *   **serverless_ha**: RDS High-availability Edition for ApsaraDB RDS for SQL Server.
        /// 
        ///     > If you create a serverless instance, you must specify this parameter.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The commodity code of the instance. Valid values:
        /// 
        /// *   **bards**: The instance is a pay-as-you-go primary instance. This value is available at the China site (aliyun.com).
        /// *   **rds**: The instance is a subscription primary instance. This value is available at the China site (aliyun.com).
        /// *   **rords**: The instance is a pay-as-you-go read-only instance. This value is available at the China site (aliyun.com).
        /// *   **rds_rordspre_public_cn**: The instance is a subscription read-only instance. This value is available at the China site (aliyun.com).
        /// *   **bards_intl**: The instance is a pay-as-you-go primary instance. This value is available at the International site (alibabacloud.com).
        /// *   **rds_intl**: The instance is a subscription primary instance. This value is available at the International site (alibabacloud.com).
        /// *   **rords_intl**: The instance is a pay-as-you-go read-only instance. This value is available at the International site (alibabacloud.com).
        /// *   **rds_rordspre_public_intl**: The instance is a subscription read-only instance. This value is available at the International site (alibabacloud.com).
        /// *   **rds_serverless_public_cn**: The instance is a serverless instance. This value is available at the China site (aliyun.com).
        /// *   **rds_serverless_public_intl**: The instance is a serverless instance. This value is available at the International site (alibabacloud.com).
        /// 
        /// > If you want to query the price of a read-only instance, you must specify this parameter.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **local_ssd**: local SSD. This is the recommended storage type.
        /// *   **cloud_ssd**: standard SSD.
        /// *   **cloud_essd**: enhanced SSDs (ESSDs) of performance level 1 (PL1)
        /// *   **cloud_essd2**: ESSDs of PL2
        /// *   **cloud_essd3**: ESSD of PL3
        /// 
        /// > Serverless instances support only ESSDs of PL 1. For a serverless instance, you must set this parameter to **cloud_essd**.
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// The database engine that is run by the instance. Valid values:
        /// 
        /// * **MySQL**
        /// * **SQLServer**
        /// * **PostgreSQL**
        /// * **MariaDB**
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version of the instance. Valid values:
        /// 
        /// *   Regular instance
        /// 
        ///     *   Valid values if you set Engine to MySQL: **5.5, 5.6, 5.7, and 8.0**
        ///     *   Valid values if you set Engine to SQLServer: **2008r2, 08r2\_ent_ha, 2012, 2012\_ent_ha, 2012\_std_ha, 2012\_web, 2014\_std_ha, 2016\_ent_ha, 2016\_std_ha, 2016\_web, 2017\_std_ha, 2017\_ent, 2019\_std_ha, and 2019\_ent**
        ///     *   Valid values if you set Engine to PostgreSQL: **10.0, 11.0, 12.0, 13.0, 14.0, and 15.0**
        ///     *   Valid value when you set Engine to MariaDB: **10.3**
        /// 
        /// *   Serverless instance
        /// 
        ///     *   Valid values if you set Engine to MySQL: **5.7** and **8.0**
        ///     *   Valid values if you set Engine to SQLServer: **2016\_std_sl**, **2017\_std_sl**, and **2019\_std_sl**
        ///     *   Valid value if you set Engine to PostgreSQL: **14.0**
        /// 
        ///     > ApsaraDB RDS for MariaDB does not support serverless instances.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **Prepaid**: subscription
        /// *   **Postpaid**: pay-as-you-go
        /// *   **Serverless**: serverless
        /// 
        /// > ApsaraDB RDS for MariaDB does not support serverless instances.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The type of the order. Set the value to **BUY**
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the DescribeDBInstanceAttribute operation to query the region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The zone ID of the instance. You can call the DescribeDBInstanceAttribute operation to query the zone ID of the instance.
        /// 
        /// > If the DescribeDBInstanceAttribute operation returns multiple zones, you must specify only one of the returned zones.`` For example, if the DescribeDBInstanceAttribute operation returns `cn-hangzhou-MAZ9(g,h)`, you can set this parameter to `cn-hangzhou-g` or cn-hangzhou-h.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
