// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableClassesRequest : TeaModel {
        /// <summary>
        /// <para>The RDS edition of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Regular instance</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: RDS Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: RDS High-availability Edition</description></item>
        /// <item><description><b>cluster</b>: RDS Cluster Edition for ApsaraDB RDS for MySQL</description></item>
        /// <item><description><b>AlwaysOn</b>: RDS Cluster Edition for ApsaraDB RDS for SQL Server</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instance</para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: RDS Basic Edition. This edition is available only for serverless instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_standard</b>: RDS High-availability Edition for ApsaraDB RDS for MySQL.</description></item>
        /// <item><description><b>serverless_ha</b>: RDS High-availability Edition for ApsaraDB RDS for SQL Server.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a serverless instance, you must specify this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The commodity code of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bards</b>: The instance is a pay-as-you-go primary instance. This value is available at the China site (aliyun.com).</description></item>
        /// <item><description><b>rds</b>: The instance is a subscription primary instance. This value is available at the China site (aliyun.com).</description></item>
        /// <item><description><b>rords</b>: The instance is a pay-as-you-go read-only instance. This value is available at the China site (aliyun.com).</description></item>
        /// <item><description><b>rds_rordspre_public_cn</b>: The instance is a subscription read-only instance. This value is available at the China site (aliyun.com).</description></item>
        /// <item><description><b>bards_intl</b>: The instance is a pay-as-you-go primary instance. This value is available at the International site (alibabacloud.com).</description></item>
        /// <item><description><b>rds_intl</b>: The instance is a subscription primary instance. This value is available at the International site (alibabacloud.com).</description></item>
        /// <item><description><b>rords_intl</b>: The instance is a pay-as-you-go read-only instance. This value is available at the International site (alibabacloud.com).</description></item>
        /// <item><description><b>rds_rordspre_public_intl</b>: The instance is a subscription read-only instance. This value is available at the International site (alibabacloud.com).</description></item>
        /// <item><description><b>rds_serverless_public_cn</b>: The instance is a serverless instance. This value is available at the China site (aliyun.com).</description></item>
        /// <item><description><b>rds_serverless_public_intl</b>: The instance is a serverless instance. This value is available at the International site (alibabacloud.com).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you want to query the price of a read-only instance, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bards</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: local SSD. This is the recommended storage type.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>cloud_essd</b>: enhanced SSDs (ESSDs) of performance level 1 (PL1)</description></item>
        /// <item><description><b>cloud_essd2</b>: ESSDs of PL2</description></item>
        /// <item><description><b>cloud_essd3</b>: ESSD of PL3</description></item>
        /// </list>
        /// <remarks>
        /// <para>Serverless instances support only ESSDs of PL 1. For a serverless instance, you must set this parameter to <b>cloud_essd</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The database engine that is run by the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>MariaDB</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Regular instance</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set Engine to MySQL: <b>5.5, 5.6, 5.7, and 8.0</b></description></item>
        /// <item><description>Valid values if you set Engine to SQLServer: <b>2008r2, 08r2_ent_ha, 2012, 2012_ent_ha, 2012_std_ha, 2012_web, 2014_std_ha, 2016_ent_ha, 2016_std_ha, 2016_web, 2017_std_ha, 2017_ent, 2019_std_ha, and 2019_ent</b></description></item>
        /// <item><description>Valid values if you set Engine to PostgreSQL: <b>10.0, 11.0, 12.0, 13.0, 14.0, and 15.0</b></description></item>
        /// <item><description>Valid value when you set Engine to MariaDB: <b>10.3</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instance</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set Engine to MySQL: <b>5.7</b> and <b>8.0</b></description></item>
        /// <item><description>Valid values if you set Engine to SQLServer: <b>2016_std_sl</b>, <b>2017_std_sl</b>, and <b>2019_std_sl</b></description></item>
        /// <item><description>Valid value if you set Engine to PostgreSQL: <b>14.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>ApsaraDB RDS for MariaDB does not support serverless instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Prepaid</b>: subscription</description></item>
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Serverless</b>: serverless</description></item>
        /// </list>
        /// <remarks>
        /// <para>ApsaraDB RDS for MariaDB does not support serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The type of the order. Set the value to <b>BUY</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the DescribeDBInstanceAttribute operation to query the region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the DescribeDBInstanceAttribute operation to query the zone ID of the instance.</para>
        /// <remarks>
        /// <para> If the DescribeDBInstanceAttribute operation returns multiple zones, you must specify only one of the returned zones. For example, if the DescribeDBInstanceAttribute operation returns <c>cn-hangzhou-MAZ9(g,h)</c>, you can set this parameter to <c>cn-hangzhou-g</c> or <c>cn-hangzhou-h</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
