// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableClassesRequest : TeaModel {
        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Regular instances</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: high-availability series</description></item>
        /// <item><description><b>cluster</b>: Cluster Edition (applicable only to MySQL and PostgreSQL)</description></item>
        /// <item><description><b>AlwaysOn</b>: SQL Server Cluster Edition</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instances</para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: Serverless Basic Edition (applicable only to MySQL and PostgreSQL)</description></item>
        /// <item><description><b>serverless_standard</b>: Serverless high availability series (applicable only to MySQL and PostgreSQL)</description></item>
        /// <item><description><b>serverless_ha</b>: SQL Server Serverless high availability series</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you create a serverless instance.</para>
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
        /// <item><description><b>bards</b>: pay-as-you-go primary instance (China site)</description></item>
        /// <item><description><b>rds</b>: subscription primary instance (China site)</description></item>
        /// <item><description><b>rords</b>: pay-as-you-go read-only instance (China site)</description></item>
        /// <item><description><b>rds_rordspre_public_cn</b>: subscription read-only instance (China site)</description></item>
        /// <item><description><b>bards_intl</b>: pay-as-you-go primary instance (international site)</description></item>
        /// <item><description><b>rds_intl</b>: subscription primary instance (international site)</description></item>
        /// <item><description><b>rords_intl</b>: pay-as-you-go read-only instance (international site)</description></item>
        /// <item><description><b>rds_rordspre_public_intl</b>: subscription read-only instance (international site)</description></item>
        /// <item><description><b>rds_serverless_public_cn</b>: serverless (China site)</description></item>
        /// <item><description><b>rds_serverless_public_intl</b>: serverless (international site)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you query a read-only instance.</para>
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
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The instance storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>general_essd</b>: premium performance disk</description></item>
        /// <item><description><b>local_ssd</b>: local SSD</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
        /// <item><description><b>cloud_essd0</b>: PL0 ESSD cloud disk</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD cloud disk</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD cloud disk</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD cloud disk</description></item>
        /// </list>
        /// <remarks>
        /// <para>Serverless instances support only PL1 ESSD cloud disks. Set this parameter to <b>cloud_essd</b>.</para>
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
        /// <para>The database engine of the instance. Valid values:</para>
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
        /// <item><description><para>Regular instances</para>
        /// <list type="bullet">
        /// <item><description>MySQL: <b>5.5, 5.6, 5.7, 8.0</b></description></item>
        /// <item><description>SQL Server: <b>2008r2, 08r2_ent_ha, 2012, 2012_ent_ha, 2012_std_ha, 2012_web, 2014_std_ha, 2016_ent_ha, 2016_std_ha, 2016_web, 2017_std_ha, 2017_ent, 2019_std_ha, 2019_ent</b></description></item>
        /// <item><description>PostgreSQL: <b>10.0, 11.0, 12.0, 13.0, 14.0, 15.0, 16.0, 17.0</b></description></item>
        /// <item><description>MariaDB: <b>10.3</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instances</para>
        /// <list type="bullet">
        /// <item><description>MySQL: <b>5.7</b>, <b>8.0</b></description></item>
        /// <item><description>SQL Server: <b>2016_std_sl</b>, <b>2017_std_sl</b>, <b>2019_std_sl</b></description></item>
        /// <item><description>PostgreSQL: <b>14.0, 15.0, 16.0, 17.0</b></description></item>
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
        /// <para>The order type. The only valid value is <b>BUY</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the DescribeDBInstanceAttribute operation to query the region ID.</para>
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
        /// <para>The zone ID of the instance. You can call the DescribeDBInstanceAttribute operation to query the zone ID.</para>
        /// <remarks>
        /// <para>If DescribeDBInstanceAttribute returns a multi-zone value (such as <c>cn-hangzhou-MAZ9(g,h)</c>), specify a single zone. Example: <c>cn-hangzhou-g</c> or <c>cn-hangzhou-j</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
