// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableZonesRequest : TeaModel {
        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   Regular instance
        /// 
        ///     *   **Basic**: RDS Basic Edition.
        ///     *   **HighAvailability**: RDS High-availability Edition.
        ///     *   **cluster**: RDS Cluster Edition for ApsaraDB RDS for MySQL.
        ///     *   **AlwaysOn**: RDS Cluster Edition for ApsaraDB RDS for SQL Server.
        ///     *   **Finance**: RDS Enterprise Edition.
        /// 
        /// *   Serverless instance
        /// 
        ///     *   **serverless_basic**: RDS Basic Edition. This edition is available only for instances that run MySQL and PostgreSQL.
        ///     *   **serverless_standard**: RDS High-availability Edition for ApsaraDB RDS for MySQL.
        ///     *   **serverless_ha**: RDS High-availability Edition for ApsaraDB RDS for SQL Server.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The commodity code of the instance. This operation can return the resources that you can purchase based on the specified commodity code. Valid values:
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
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The ID of the primary instance. If you want to query the read-only instances that you can purchase for a primary instance, you can specify this parameter.
        /// 
        /// If you set **CommodityCode** to one of the following values, you must specify this parameter:
        /// 
        /// *   **rords_intl**
        /// *   **rds_rordspre_public_intl**
        /// *   **rords**
        /// *   **rds_rordspre_public_cn**
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// Specifies whether to return the zones in which the single-zone deployment method is supported. Valid values:
        /// 
        /// *   **1** (default): returns the zones.
        /// *   **0**: does not return the zones.
        /// 
        /// >  The single-zone deployment method allows you to deploy an instance that runs RDS Enterprise Edition in a single zone.
        /// </summary>
        [NameInMap("DispenseMode")]
        [Validation(Required=false)]
        public string DispenseMode { get; set; }

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
        /// The database engine version. Valid values:
        /// 
        /// *   Regular instance
        /// 
        ///     *   Valid values if you set Engine to MySQL: **5.5**, **5.6**, **5.7**, and **8.0**
        ///     *   Valid values if you set Engine to SQLServer: **2008r2**, **08r2_ent_ha**, **2012**, **2012_ent_ha**, **2012_std_ha**, **2012_web**, **2014_std_ha**, **2016_ent_ha**, **2016_std_ha**, **2016_web**, **2017_std_ha**, **2017_ent**, **2019_std_ha**, and **2019_ent**
        ///     *   Valid values if you set Engine to PostgreSQL: **10.0**, **11.0**, **12.0**, **13.0**, **14.0**, and **15.0**
        ///     *   Valid value when you set Engine to MariaDB: **10.3**
        /// 
        /// *   Serverless instance
        /// 
        ///     *   Valid values if you set Engine to MySQL: **5.7** and **8.0**
        ///     *   Valid values if you set Engine to SQLServer: **2016_std_sl**, **2017_std_sl**, and **2019_std_sl**
        ///     *   Valid value if you set Engine to PostgreSQL: **14.0**
        /// 
        ///     **
        /// 
        ///     **Note**ApsaraDB RDS for MariaDB does not support serverless instances.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The zone ID. If the instance spans more than one zone, the value of this parameter contains an `MAZ` part, such as `cn-hangzhou-MAZ6(b,f)` and `cn-hangzhou-MAZ5(b,e,f)`. You can call the DescribeRegions operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
