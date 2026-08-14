// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateDtsInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal upon expiration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: no. This is the default value.</description></item>
        /// <item><description><b>true</b>: yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically start the task after the purchase is complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: no. This is the default value.</description></item>
        /// <item><description><b>true</b>: yes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>JobId</b> is set to a valid task ID and this parameter is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// <para>The specifications of the ETL instance. Unit: compute unit (CU). 1 CU = 1 vCPU + 4 GB memory. Valid values: integers that are greater than or equal to 2.
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>If you specify this parameter, the <a href="https://help.aliyun.com/document_detail/212324.html">ETL feature</a> is enabled for data cleaning and transformation..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ComputeUnit")]
        [Validation(Required=false)]
        public int? ComputeUnit { get; set; }

        /// <summary>
        /// <para>The number of private custom ApsaraDB RDS instances under PolarDB-X. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>SourceEndpointEngineName</b> is set to <b>drds</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DatabaseCount")]
        [Validation(Required=false)]
        public int? DatabaseCount { get; set; }

        /// <summary>
        /// <para>The database engine type of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: MySQL database, including ApsaraDB RDS for MySQL and self-managed MySQL.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL.</description></item>
        /// <item><description><b>polardb_o</b>: PolarDB for Oracle.</description></item>
        /// <item><description><b>polardb_pg</b>: PolarDB for PostgreSQL.</description></item>
        /// <item><description><b>Redis</b>: Redis database, including Tair (Redis® OSS-Compatible) and self-managed Redis.</description></item>
        /// <item><description><b>DRDS</b>: cloud-native distributed database PolarDB-X 1.0 and 2.0.</description></item>
        /// <item><description><b>PostgreSQL</b>: self-managed PostgreSQL.</description></item>
        /// <item><description><b>odps</b>: MaxCompute.</description></item>
        /// <item><description><b>oracle</b>: self-managed Oracle.</description></item>
        /// <item><description><b>mongodb</b>: MongoDB database, including ApsaraDB for MongoDB and self-managed MongoDB.</description></item>
        /// <item><description><b>tidb</b>: TiDB database.</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL 2.0.</description></item>
        /// <item><description><b>ADB30</b>: AnalyticDB for MySQL 3.0.</description></item>
        /// <item><description><b>Greenplum</b>: AnalyticDB for PostgreSQL.</description></item>
        /// <item><description><b>MSSQL</b>: SQL Server database, including ApsaraDB RDS for SQL Server and self-managed SQL Server.</description></item>
        /// <item><description><b>kafka</b>: Kafka database, including ApsaraMQ for Kafka and self-managed Kafka.</description></item>
        /// <item><description><b>DataHub</b>: Alibaba Cloud DataHub.</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW.</description></item>
        /// <item><description><b>as400</b>: AS/400.</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>MySQL</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the supported source and destination database combinations, see <a href="https://help.aliyun.com/document_detail/130744.html">Databases, initial synchronization types, and synchronization topologies</a> and <a href="https://help.aliyun.com/document_detail/26618.html">Supported databases and migration types</a>.</description></item>
        /// <item><description>You must specify this parameter or <b>JobId</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DestinationEndpointEngineName")]
        [Validation(Required=false)]
        public string DestinationEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The region of the destination instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <remarks>
        /// <para>You must specify this parameter or <b>JobId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationRegion")]
        [Validation(Required=false)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// <para>The region to which the instance belongs. The value must be the same as the value of <b>RegionId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DtsRegion")]
        [Validation(Required=false)]
        public string DtsRegion { get; set; }

        /// <summary>
        /// <para>The number of DU resources to allocate to the DTS task on a DTS dedicated cluster. Valid values: <b>1</b> to <b>100</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value must be within the range of available DUs in the DTS dedicated cluster.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about DTS dedicated clusters, see <a href="https://help.aliyun.com/document_detail/417481.html">What is a DTS dedicated cluster</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Du")]
        [Validation(Required=false)]
        public int? Du { get; set; }

        /// <summary>
        /// <para>The billing type for change tracking. Valid values: ONLY_CONFIGURATION_FEE, which indicates that only configuration fees are charged and data traffic fees are waived. CONFIGURATION_FEE_AND_DATA_FEE, which indicates that data traffic fees are additionally charged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ONLY_CONFIGURATION_FEE</para>
        /// </summary>
        [NameInMap("FeeType")]
        [Validation(Required=false)]
        public string FeeType { get; set; }

        [NameInMap("InsightModule")]
        [Validation(Required=false)]
        public bool? InsightModule { get; set; }

        /// <summary>
        /// <para>The specification of the data migration or data synchronization instance.</para>
        /// <list type="bullet">
        /// <item><description>Specifications supported by data migration instances: <b>xxlarge</b>, <b>xlarge</b>, <b>large</b>, <b>medium</b>, and <b>small</b>.</description></item>
        /// <item><description>Specifications supported by data synchronization instances: <b>large</b>, <b>medium</b>, <b>small</b>, and <b>micro</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the performance of each specification, see <a href="https://help.aliyun.com/document_detail/26606.html">Specifications of data migration instances</a> and <a href="https://help.aliyun.com/document_detail/26605.html">Specifications of data synchronization instances</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxlarge</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The task ID (<b>DtsJobId</b>) obtained by calling the <b>ConfigureDtsJob</b> operation.</para>
        /// <remarks>
        /// <para>If you specify this parameter, you do not need to specify <b>SourceRegion</b>, <b>DestinationRegion</b>, <b>Type</b>, <b>SourceEndpointEngineName</b>, or <b>DestinationEndpointEngineName</b>. Even if you specify these parameters, the configurations in <b>JobId</b> take precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bi6e22ay243****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The maximum number of DUs.</para>
        /// <remarks>
        /// <para>This parameter is supported only for serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public double? MaxDu { get; set; }

        /// <summary>
        /// <para>The minimum number of DUs.</para>
        /// <remarks>
        /// <para>This parameter is supported only for serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDu")]
        [Validation(Required=false)]
        public double? MinDu { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Correction: This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing method of the subscription instance. Valid values: <b>Year</b> and <b>Month</b>.</para>
        /// <remarks>
        /// <para>This parameter is valid and required only when <b>PayType</b> is set to <b>PrePaid</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The number of instances to purchase.</para>
        /// <remarks>
        /// <para>A maximum of one instance can be purchased per call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The database engine type of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: MySQL database, including ApsaraDB RDS for MySQL and self-managed MySQL.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL.</description></item>
        /// <item><description><b>polardb_o</b>: PolarDB for Oracle.</description></item>
        /// <item><description><b>polardb_pg</b>: PolarDB for PostgreSQL.</description></item>
        /// <item><description><b>Redis</b>: Redis database, including Tair (Redis® OSS-Compatible) and self-managed Redis.</description></item>
        /// <item><description><b>DRDS</b>: cloud-native distributed database PolarDB-X 1.0 and 2.0.</description></item>
        /// <item><description><b>PostgreSQL</b>: self-managed PostgreSQL.</description></item>
        /// <item><description><b>odps</b>: MaxCompute.</description></item>
        /// <item><description><b>oracle</b>: self-managed Oracle.</description></item>
        /// <item><description><b>mongodb</b>: MongoDB database, including ApsaraDB for MongoDB and self-managed MongoDB.</description></item>
        /// <item><description><b>tidb</b>: TiDB database.</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL 2.0.</description></item>
        /// <item><description><b>ADB30</b>: AnalyticDB for MySQL 3.0.</description></item>
        /// <item><description><b>Greenplum</b>: AnalyticDB for PostgreSQL.</description></item>
        /// <item><description><b>MSSQL</b>: SQL Server database, including ApsaraDB RDS for SQL Server and self-managed SQL Server.</description></item>
        /// <item><description><b>kafka</b>: Kafka database, including ApsaraMQ for Kafka and self-managed Kafka.</description></item>
        /// <item><description><b>DataHub</b>: Alibaba Cloud DataHub.</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW.</description></item>
        /// <item><description><b>as400</b>: AS/400.</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore.</description></item>
        /// <item><description><b>OceanBase</b>: OceanBase (MySQL). Only data migration instances are supported.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>MySQL</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the supported source and destination database combinations, see <a href="https://help.aliyun.com/document_detail/130744.html">Databases, initial synchronization types, and synchronization topologies</a> and <a href="https://help.aliyun.com/document_detail/26618.html">Supported databases and migration types</a>.</description></item>
        /// <item><description>You must specify this parameter or <b>JobId</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The region of the source instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <remarks>
        /// <para>You must specify this parameter or <b>JobId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The synchronization topology. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oneway</b>: one-way synchronization. This is the default value.</description></item>
        /// <item><description><b>bidirectional</b>: two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oneway</para>
        /// </summary>
        [NameInMap("SyncArchitecture")]
        [Validation(Required=false)]
        public string SyncArchitecture { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIGRATION</b>: data migration.</description></item>
        /// <item><description><b>SYNC</b>: data synchronization.</description></item>
        /// <item><description><b>SUBSCRIBE</b>: change tracking.<remarks>
        /// <para>You must specify this parameter or <b>JobId</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The subscription duration of the subscription instance.</para>
        /// <list type="bullet">
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, valid values are 1, 2, 3, 4, 5, 6, 7, 8, and 9.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, valid values are 1, 2, 3, and 5.<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is valid and required only when <b>PayType</b> is set to <b>PrePaid</b> (subscription).</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>You can set the billing method of the subscription instance by using the <b>Period</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
