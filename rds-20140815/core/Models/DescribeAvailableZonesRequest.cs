// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableZonesRequest : TeaModel {
        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Regular instances<list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: high-availability (active) series</description></item>
        /// <item><description><b>cluster</b>: Cluster Edition for MySQL</description></item>
        /// <item><description><b>AlwaysOn</b>: Cluster Edition for SQL Server</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Serverless instances<list type="bullet">
        /// <item><description><b>serverless_basic</b>: Serverless Basic Edition (only applicable to MySQL and PostgreSQL)</description></item>
        /// <item><description><b>serverless_standard</b>: MySQL Serverless high-availability (active) series</description></item>
        /// <item><description><b>serverless_ha</b>: SQL Server Serverless high-availability (active) series</description></item>
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
        /// <para>The commodity code of the instance. The available resources are queried based on the specified commodity code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bards</b>: pay-as-you-go primary instances on the China site</description></item>
        /// <item><description><b>rds</b>: subscription primary instances on the China site</description></item>
        /// <item><description><b>rords</b>: pay-as-you-go read-only instances on the China site</description></item>
        /// <item><description><b>rds_rordspre_public_cn</b>: subscription read-only instances on the China site</description></item>
        /// <item><description><b>bards_intl</b>: pay-as-you-go primary instances on the international site</description></item>
        /// <item><description><b>rds_intl</b>: subscription primary instances on the international site</description></item>
        /// <item><description><b>rords_intl</b>: pay-as-you-go read-only instances on the international site</description></item>
        /// <item><description><b>rds_rordspre_public_intl</b>: subscription read-only instances on the international site</description></item>
        /// <item><description><b>rds_serverless_public_cn</b>: Serverless instances on the China site</description></item>
        /// <item><description><b>rds_serverless_public_intl</b>: Serverless instances on the international site</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bards</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The instance ID of the primary instance. This parameter is used to query the available read-only instance resources under the primary instance.</para>
        /// <para>This parameter is required when the <b>CommodityCode</b> parameter is set to one of the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>rords_intl</b></description></item>
        /// <item><description><b>rds_rordspre_public_intl</b></description></item>
        /// <item><description><b>rords</b></description></item>
        /// <item><description><b>rds_rordspre_public_cn</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the list of zones that support single-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b> (default): Returns the list.</description></item>
        /// <item><description><b>0</b>: Does not return the list.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The single-zone deployment feature allows you to deploy RDS Enterprise Edition instances in a single zone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DispenseMode")]
        [Validation(Required=false)]
        public string DispenseMode { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
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
        /// <item><description><para>Regular instances</para>
        /// <list type="bullet">
        /// <item><description>MySQL: <b>5.5</b>, <b>5.6</b>, <b>5.7</b>, and <b>8.0</b></description></item>
        /// <item><description>SQL Server: <b>2008r2</b>, <b>08r2_ent_ha</b>, <b>2012</b>, <b>2012_ent_ha</b>, <b>2012_std_ha</b>, <b>2012_web</b>, <b>2014_std_ha</b>, <b>2016_ent_ha</b>, <b>2016_std_ha</b>, <b>2016_web</b>, <b>2017_std_ha</b>, <b>2017_ent</b>, <b>2019_std_ha</b>, and <b>2019_ent</b></description></item>
        /// <item><description>PostgreSQL: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, and <b>15.0</b></description></item>
        /// <item><description>MariaDB: <b>10.3</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instances</para>
        /// <list type="bullet">
        /// <item><description>MySQL: <b>5.7</b> and <b>8.0</b></description></item>
        /// <item><description>SQL Server: <b>2016_std_sl</b>, <b>2017_std_sl</b>, and <b>2019_std_sl</b></description></item>
        /// <item><description>PostgreSQL: <b>14.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>ApsaraDB RDS for MariaDB does not support Serverless instances.</para>
        /// </remarks>
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
        /// <para>The region ID. You can call the DescribeRegions operation to query the region ID.</para>
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
        /// <para>The zone ID. The format of a multi-zone ID is different from that of a single-zone ID and contains <c>MAZ</c>, such as <c>cn-hangzhou-MAZ6(b,f)</c> and <c>cn-hangzhou-MAZ5(b,e,f)</c>. You can call the DescribeRegions operation to query the zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
