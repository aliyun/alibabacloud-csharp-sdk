// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and can be up to 64 ASCII characters in length. The value cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity code of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bards</b>: pay-as-you-go primary instance (Chinese site)</description></item>
        /// <item><description><b>rds</b> (default): subscription primary instance (Chinese site)</description></item>
        /// <item><description><b>rords</b>: pay-as-you-go read-only instance (Chinese site)</description></item>
        /// <item><description><b>rds_rordspre_public_cn</b>: subscription read-only instance (Chinese site)</description></item>
        /// <item><description><b>bards_intl</b>: pay-as-you-go primary instance (International site)</description></item>
        /// <item><description><b>rds_intl</b>: subscription primary instance (International site)</description></item>
        /// <item><description><b>rords_intl</b>: pay-as-you-go read-only instance (International site)</description></item>
        /// <item><description><b>rds_rordspre_public_intl</b>: subscription read-only instance (International site)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you query the pricing of a read-only instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.x2.medium.xc</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance for which you want to change the specifications or renew the subscription.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when you query the price for changing the specifications or renewing the subscription of an instance.</description></item>
        /// <item><description>If the instance is a read-only instance, you must specify instance ID of its primary instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Instance storage capacity of the instance. Unit: GB. Instance storage capacity increases in increments of 5 GB. For more information about the valid values, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The instance storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>general_essd</b>: Premium ESSD</description></item>
        /// <item><description><b>local_ssd</b>: Premium Local SSD</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The node information.</para>
        /// <remarks>
        /// <para>This parameter is applicable to ApsaraDB RDS for MySQL Cluster Edition instances.</para>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<DescribePriceRequestDBNode> DBNode { get; set; }
        public class DescribePriceRequestDBNode : TeaModel {
            /// <summary>
            /// <para>The node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.x2.medium.xc</para>
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <para>The zone ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

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
        /// <para>&lt;props=&quot;china&quot;&gt;The database engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: <b>5.5</b>, <b>5.6</b>, <b>5.7</b>, and <b>8.0</b></description></item>
        /// <item><description><b>SQL Server</b>: <b>08r2_ent_ha</b> (cloud disk edition, discontinued), <b>2008r2</b> (high-performance local disk, discontinued), <b>2012</b> (Enterprise Edition Basic), <b>2012_ent_ha</b>, <b>2012_std_ha</b>, <b>2012_web</b>, <b>2014_ent_ha</b>, <b>2014_std_ha</b>, <b>2016_ent_ha</b>, <b>2016_std_ha</b>, <b>2016_web</b>, <b>2017_ent</b>, <b>2017_std_ha</b>, <b>2017_web</b>, <b>2019_ent</b>, <b>2019_std_ha</b>, <b>2019_web</b>, <b>2022_ent</b>, <b>2022_std_ha</b>, and <b>2022_web</b></description></item>
        /// <item><description><b>PostgreSQL</b>: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, and <b>15.0</b></description></item>
        /// <item><description><b>MariaDB</b>: <b>10.3</b></description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;The database engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: <b>5.5</b>, <b>5.6</b>, <b>5.7</b>, and <b>8.0</b></description></item>
        /// <item><description><b>SQL Server</b>: <b>08r2_ent_ha</b> (cloud disk edition, discontinued), <b>2008r2</b> (high-performance local disk, discontinued), <b>2012</b> (Enterprise Edition Basic), <b>2012_ent_ha</b>, <b>2012_std_ha</b>, <b>2012_web</b>, <b>2016_ent_ha</b>, <b>2016_std_ha</b>, <b>2016_web</b>, <b>2017_ent</b>, <b>2017_std_ha</b>, <b>2017_web</b>, <b>2019_ent</b>, <b>2019_std_ha</b>, <b>2019_web</b>, <b>2022_ent</b>, <b>2022_std_ha</b>, and <b>2022_web</b></description></item>
        /// <item><description><b>PostgreSQL</b>: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, and <b>15.0</b></description></item>
        /// <item><description><b>MariaDB</b>: <b>10.3</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>For an ApsaraDB RDS for SQL Server instance, <c>_ent</c> indicates the Enterprise Cluster Edition, <c>_ent_ha</c> indicates the Enterprise Edition, <c>_std_ha</c> indicates the Standard Edition, and <c>_web</c> indicates the Web Edition.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The instance role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: primary instance</description></item>
        /// <item><description><b>3</b>: read-only instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InstanceUsedType")]
        [Validation(Required=false)]
        public int? InstanceUsedType { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BUY</b>: purchase</description></item>
        /// <item><description><b>RENEW</b>: renewal</description></item>
        /// <item><description><b>UPGRADE</b>: upgrade</description></item>
        /// <item><description><b>DOWNGRADE</b>: downgrade</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
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
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Prepaid</b>: subscription</description></item>
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The number of instances that you want to purchase. Valid values: <b>0</b> to <b>30</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to obtain the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The settings of the serverless ApsaraDB RDS instance.</para>
        /// <remarks>
        /// <para>ApsaraDB RDS for MariaDB does not support serverless instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public DescribePriceRequestServerlessConfig ServerlessConfig { get; set; }
        public class DescribePriceRequestServerlessConfig : TeaModel {
            /// <summary>
            /// <para>The maximum number of RDS capacity units (RCUs) allowed for automatic scaling of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public double? MaxCapacity { get; set; }

            /// <summary>
            /// <para>The minimum number of RCUs allowed for automatic scaling of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public double? MinCapacity { get; set; }

        }

        /// <summary>
        /// <para>The subscription period unit. This parameter is required when the <b>CommodityCode</b> parameter is set to <b>rds</b>, <b>rds_rordspre_public_cn</b>, <b>rds_intl</b>, or <b>rds_rordspre_public_intl</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: year</description></item>
        /// <item><description><b>Month</b>: month</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public string TimeType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the <b>TimeType</b> parameter is set to <b>Year</b>, the value of the UsedTime parameter ranges from <b>1</b> to <b>100</b>.</description></item>
        /// <item><description>If the <b>TimeType</b> parameter is set to <b>Month</b>, the value of the UsedTime parameter ranges from <b>1</b> to <b>999</b>.</description></item>
        /// </list>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary node. You can call the DescribeRegions operation to query the zone ID.</para>
        /// <remarks>
        /// <para>If you specify a VPC and a vSwitch, this parameter is required to match the zone of the vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
