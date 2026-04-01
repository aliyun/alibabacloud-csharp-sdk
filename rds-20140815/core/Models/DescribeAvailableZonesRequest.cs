// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableZonesRequest : TeaModel {
        /// <summary>
        /// <para>The RDS edition of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Regular instance</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: RDS Basic Edition.</description></item>
        /// <item><description><b>HighAvailability</b>: RDS High-availability Edition.</description></item>
        /// <item><description><b>cluster</b>: RDS Cluster Edition for ApsaraDB RDS for MySQL.</description></item>
        /// <item><description><b>AlwaysOn</b>: RDS Cluster Edition for ApsaraDB RDS for SQL Server.</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instance</para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: RDS Basic Edition. This edition is available only for instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_standard</b>: RDS High-availability Edition for ApsaraDB RDS for MySQL.</description></item>
        /// <item><description><b>serverless_ha</b>: RDS High-availability Edition for ApsaraDB RDS for SQL Server.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The commodity code of the instance. This operation can return the resources that you can purchase based on the specified commodity code. Valid values:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>bards</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The ID of the primary instance. If you want to query the read-only instances that you can purchase for a primary instance, you can specify this parameter.</para>
        /// <para>If you set <b>CommodityCode</b> to one of the following values, you must specify this parameter:</para>
        /// <list type="bullet">
        /// <item><description><b>rords_intl</b></description></item>
        /// <item><description><b>rds_rordspre_public_intl</b></description></item>
        /// <item><description><b>rords</b></description></item>
        /// <item><description><b>rds_rordspre_public_cn</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the zones in which the single-zone deployment method is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b> (default): returns the zones.</description></item>
        /// <item><description><b>0</b>: does not return the zones.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The single-zone deployment method allows you to deploy an instance that runs RDS Enterprise Edition in a single zone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DispenseMode")]
        [Validation(Required=false)]
        public string DispenseMode { get; set; }

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
        /// <para>The database engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Regular instance</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set Engine to MySQL: <b>5.5</b>, <b>5.6</b>, <b>5.7</b>, and <b>8.0</b></description></item>
        /// <item><description>Valid values if you set Engine to SQLServer: <b>2008r2</b>, <b>08r2_ent_ha</b>, <b>2012</b>, <b>2012_ent_ha</b>, <b>2012_std_ha</b>, <b>2012_web</b>, <b>2014_std_ha</b>, <b>2016_ent_ha</b>, <b>2016_std_ha</b>, <b>2016_web</b>, <b>2017_std_ha</b>, <b>2017_ent</b>, <b>2019_std_ha</b>, and <b>2019_ent</b></description></item>
        /// <item><description>Valid values if you set Engine to PostgreSQL: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, and <b>15.0</b></description></item>
        /// <item><description>Valid value when you set Engine to MariaDB: <b>10.3</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instance</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set Engine to MySQL: <b>5.7</b> and <b>8.0</b></description></item>
        /// <item><description>Valid values if you set Engine to SQLServer: <b>2016_std_sl</b>, <b>2017_std_sl</b>, and <b>2019_std_sl</b></description></item>
        /// <item><description>Valid value if you set Engine to PostgreSQL: <b>14.0</b></description></item>
        /// </list>
        /// <para>**</para>
        /// <para><b>Note</b>ApsaraDB RDS for MariaDB does not support serverless instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>The zone ID. If the instance spans more than one zone, the value of this parameter contains an <c>MAZ</c> part, such as <c>cn-hangzhou-MAZ6(b,f)</c> and <c>cn-hangzhou-MAZ5(b,e,f)</c>. You can call the DescribeRegions operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
