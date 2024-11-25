// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePriceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity code of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bards</b>: The instance is a pay-as-you-go primary instance. This value is available at the China site (aliyun.com).</description></item>
        /// <item><description><b>rds</b> (default): The instance is a subscription primary instance. This value is available on the China site (aliyun.com).</description></item>
        /// <item><description><b>rords</b>: The instance is a pay-as-you-go read-only instance. This value is available at the China site (aliyun.com).</description></item>
        /// <item><description><b>rds_rordspre_public_cn</b>: The instance is a subscription read-only instance. This value is available at the China site (aliyun.com).</description></item>
        /// <item><description><b>bards_intl</b>: The instance is a pay-as-you-go primary instance. This value is available at the international site (alibabacloud.com).</description></item>
        /// <item><description><b>rds_intl</b>: The instance is a subscription primary instance. This value is available at the international site (alibabacloud.com).</description></item>
        /// <item><description><b>rords_intl</b>: The instance is a pay-as-you-go read-only instance. This value is available at the international site (alibabacloud.com).</description></item>
        /// <item><description><b>rds_rordspre_public_intl</b>: The instance is a subscription read-only instance. This value is available on the international site (alibabacloud.com).</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you want to query the price of a read-only instance, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The instance type of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.mysql.s1.small</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the instance for which you want to change the specifications or the instance that you want to renew.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you want to query the price of a specification change order or a renewal order, you must specify this parameter.</description></item>
        /// <item><description>If the instance is a read-only instance, you must set this parameter to the ID of its primary instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance. Unit: GB. You can increase the storage capacity at a step size of 5 GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: local SSD</description></item>
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
        /// <para>The information about the node.</para>
        /// <remarks>
        /// <para> This parameter is supported for ApsaraDB RDS for MySQL instances that run RDS Cluster Edition.</para>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public string DBNodeShrink { get; set; }

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
        /// <para>The database engine version of the instance.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if you set Engine to <b>MySQL</b>: <b>5.5</b>, <b>5.6</b>, <b>5.7</b>, and <b>8.0</b></description></item>
        /// <item><description>Valid values if you set Engine to <b>SQLServer</b>: <b>08r2_ent_ha</b> (cloud disks, discontinued), <b>2008r2</b>(local disks, discontinued), <b>2012</b> (SQL Server EE Basic), <b>2012_ent_ha</b>, <b>2012_std_ha</b>, <b>2012_web</b>, <b>2016_ent_ha</b>, <b>2016_std_ha</b>, <b>2016_web</b>, <b>2017_ent</b>, <b>2017_std_ha</b>, <b>2017_web</b>, <b>2019_ent</b>, <b>2019_std_ha</b>, <b>2019_web</b>, <b>2022_ent</b>, <b>2022_std_ha</b>, and <b>2022_web</b></description></item>
        /// <item><description>Valid values if you set Engine to <b>PostgreSQL</b>: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, and <b>15.0</b></description></item>
        /// <item><description>Valid value if you set Engine to <b>MariaDB</b>: <b>10.3</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> The following information describes the valid values when you set Engine to SQLServer: <c>_ent</c> specifies SQL Server EE on RDS Cluster Edition, <c>_ent_ha</c> specifies SQL Server EE, <c>_std_ha</c> specifies SQL Server SE, and <c>_web</c> specifies SQL Server Web.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.5</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The role of the instance. Valid values:</para>
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
        /// <para>The type of the order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BUY</b>: purchase order</description></item>
        /// <item><description><b>UPGRADE</b>: specification change order</description></item>
        /// <item><description><b>RENEW</b>: renewal order</description></item>
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
        /// <para>The number of instances that you want to purchase. Valid values: <b>0 to 30</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>The settings of the serverless instance.</para>
        /// <remarks>
        /// <para>ApsaraDB RDS for MariaDB does not support serverless instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public string ServerlessConfigShrink { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription instance. This parameter is required when <b>CommodityCode</b> is set to <b>rds</b>, <b>rds_rordspre_public_cn</b>, <b>rds_intl</b>, or <b>rds_rordspre_public_intl</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public string TimeType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set the <b>TimeType</b> parameter to <b>Year</b>, the value of the UsedTime parameter ranges from <b>1 to 100</b>.</description></item>
        /// <item><description>If you set the <b>TimeType</b> parameter to <b>Month</b>, the value of the UsedTime parameter ranges from <b>1 to 999</b>.</description></item>
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
        /// <para>The zone ID of the primary instance. You can call the DescribeRegions operation to query the most recent zone list.</para>
        /// <remarks>
        /// <para> If you specify a virtual private cloud (VPC) and a vSwitch, this parameter is required to identify the zone for the vSwitch.</para>
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
