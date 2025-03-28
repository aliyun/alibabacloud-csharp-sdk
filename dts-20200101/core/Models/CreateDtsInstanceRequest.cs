// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateDtsInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically renew the DTS instance when it expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: does not automatically renew the DTS instance when it expires. This is the default value.</description></item>
        /// <item><description><b>true</b>: automatically renews the DTS instance when it expires.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically start the task after the DTS instance is purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter can be set to <b>true</b> and take effect only if you specify a valid value for <b>JobId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// <para>The specification of the extract, transform, and load (ETL) instance. The unit is compute unit (CU). One CU is equal to 1 vCPU and 4 GB of memory. The value of this parameter must be an integer greater than or equal to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ComputeUnit")]
        [Validation(Required=false)]
        public int? ComputeUnit { get; set; }

        /// <summary>
        /// <para>The number of custom ApsaraDB RDS instances in the PolarDB-X instance. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para> This parameter is required only if <b>SourceEndpointEngineName</b> is set to <b>drds</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DatabaseCount")]
        [Validation(Required=false)]
        public int? DatabaseCount { get; set; }

        /// <summary>
        /// <para>The database engine of the destination instance.</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: ApsaraDB RDS for MySQL instance or self-managed MySQL database</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster</description></item>
        /// <item><description><b>polardb_o</b>: PolarDB for Oracle cluster</description></item>
        /// <item><description><b>polardb_pg</b>: PolarDB for PostgreSQL cluster</description></item>
        /// <item><description><b>Redis</b>: ApsaraDB for Redis instance or self-managed Redis database</description></item>
        /// <item><description><b>DRDS</b>: PolarDB-X 1.0 or PolarDB-X 2.0 instance</description></item>
        /// <item><description><b>PostgreSQL</b>: self-managed PostgreSQL database</description></item>
        /// <item><description><b>odps</b>: MaxCompute project</description></item>
        /// <item><description><b>oracle</b>: self-managed Oracle database</description></item>
        /// <item><description><b>mongodb</b>: ApsaraDB for MongoDB instance or self-managed MongoDB database</description></item>
        /// <item><description><b>tidb</b>: TiDB database</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL V2.0 cluster</description></item>
        /// <item><description><b>ADB30</b>: AnalyticDB for MySQL V3.0 cluster</description></item>
        /// <item><description><b>Greenplum</b>: AnalyticDB for PostgreSQL instance</description></item>
        /// <item><description><b>MSSQL</b>: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database</description></item>
        /// <item><description><b>kafka</b>: Message Queue for Apache Kafka instance or self-managed Kafka cluster</description></item>
        /// <item><description><b>DataHub</b>: DataHub project</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW database</description></item>
        /// <item><description><b>as400</b>: AS/400</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore instance</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The default value is <b>MySQL</b>.</description></item>
        /// <item><description>For more information about the supported source and destination databases, see <a href="https://help.aliyun.com/document_detail/130744.html">Overview of data synchronization scenarios</a> and <a href="https://help.aliyun.com/document_detail/26618.html">Overview of data migration scenarios</a>.</description></item>
        /// <item><description>You must specify one of this parameter and the <b>JobId</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DestinationEndpointEngineName")]
        [Validation(Required=false)]
        public string DestinationEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the destination instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <remarks>
        /// <para> You must specify one of this parameter and the <b>JobId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationRegion")]
        [Validation(Required=false)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// <para>The region ID of the DTS instance. Set this parameter to the value of <b>RegionId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DtsRegion")]
        [Validation(Required=false)]
        public string DtsRegion { get; set; }

        /// <summary>
        /// <para>The number of DTS units (DUs) that are assigned to a DTS task that is run on a DTS dedicated cluster. Valid values: <b>1</b> to <b>100</b>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The value of this parameter must be within the range of the number of DUs available for the DTS dedicated cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Du")]
        [Validation(Required=false)]
        public int? Du { get; set; }

        /// <summary>
        /// <para>The billing type for a change tracking instance. Valid values: ONLY_CONFIGURATION_FEE and CONFIGURATION_FEE_AND_DATA_FEE. ONLY_CONFIGURATION_FEE: charges only configuration fees. CONFIGURATION_FEE_AND_DATA_FEE: charges configuration fees and data traffic fees.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ONLY_CONFIGURATION_FEE</para>
        /// </summary>
        [NameInMap("FeeType")]
        [Validation(Required=false)]
        public string FeeType { get; set; }

        /// <summary>
        /// <para>The instance class.</para>
        /// <list type="bullet">
        /// <item><description>DTS supports the following instance classes for a data migration instance: <b>xxlarge</b>, <b>xlarge</b>, <b>large</b>, <b>medium</b>, and <b>small</b>.</description></item>
        /// <item><description>DTS supports the following instance classes for a data synchronization instance: <b>large</b>, <b>medium</b>, <b>small</b>, and <b>micro</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about the test performance of each instance class, see <a href="https://help.aliyun.com/document_detail/26606.html">Specifications of data migration instances</a> and <a href="https://help.aliyun.com/document_detail/26605.html">Specifications of data synchronization instances</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxlarge</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the task. You can call the <b>ConfigureDtsJob</b> operation to obtain the task ID from the <b>DtsJobId</b> parameter.</para>
        /// <remarks>
        /// <para> If this parameter is specified, you do not need to specify the <b>SourceRegion</b>, <b>DestinationRegion</b>, <b>Type</b>, <b>SourceEndpointEngineName</b>, or <b>DestinationEndpointEngineName</b> parameter. Even if these parameters are specified, the value of the <b>JobId</b> parameter takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bi6e22ay243****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Upper limit of DU.</para>
        /// <remarks>
        /// <para>Only supported by Serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public double? MaxDu { get; set; }

        /// <summary>
        /// <para>Lower limit of DU.</para>
        /// <remarks>
        /// <para>Only supported by Serverless instances.</para>
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
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter must be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values: <b>Year</b> and <b>Month</b>.</para>
        /// <remarks>
        /// <para> You must specify this parameter only if the <b>PayType</b> parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The number of DTS instances that you want to purchase.</para>
        /// <remarks>
        /// <para> You can purchase only one DTS instance each time you call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The database engine of the source instance.</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: ApsaraDB RDS for MySQL instance or self-managed MySQL database</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster</description></item>
        /// <item><description><b>polardb_o</b>: PolarDB for Oracle cluster</description></item>
        /// <item><description><b>polardb_pg</b>: PolarDB for PostgreSQL cluster</description></item>
        /// <item><description><b>Redis</b>: ApsaraDB for Redis instance or self-managed Redis database</description></item>
        /// <item><description><b>DRDS</b>: PolarDB-X 1.0 or PolarDB-X 2.0 instance</description></item>
        /// <item><description><b>PostgreSQL</b>: self-managed PostgreSQL database</description></item>
        /// <item><description><b>odps</b>: MaxCompute project</description></item>
        /// <item><description><b>oracle</b>: self-managed Oracle database</description></item>
        /// <item><description><b>mongodb</b>: ApsaraDB for MongoDB instance or self-managed MongoDB database</description></item>
        /// <item><description><b>tidb</b>: TiDB database</description></item>
        /// <item><description><b>ADS</b>: AnalyticDB for MySQL V2.0 cluster</description></item>
        /// <item><description><b>ADB30</b>: AnalyticDB for MySQL V3.0 cluster</description></item>
        /// <item><description><b>Greenplum</b>: AnalyticDB for PostgreSQL instance</description></item>
        /// <item><description><b>MSSQL</b>: ApsaraDB RDS for SQL Server instance or self-managed SQL Server database</description></item>
        /// <item><description><b>kafka</b>: Message Queue for Apache Kafka instance or self-managed Kafka cluster</description></item>
        /// <item><description><b>DataHub</b>: DataHub project</description></item>
        /// <item><description><b>DB2</b>: self-managed Db2 for LUW database</description></item>
        /// <item><description><b>as400</b>: AS/400</description></item>
        /// <item><description><b>Tablestore</b>: Tablestore instance</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The default value is <b>MySQL</b>.</description></item>
        /// <item><description>For more information about the supported source and destination databases, see <a href="https://help.aliyun.com/document_detail/130744.html">Overview of data synchronization scenarios</a> and <a href="https://help.aliyun.com/document_detail/26618.html">Overview of data migration scenarios</a>.</description></item>
        /// <item><description>You must specify one of this parameter and the <b>JobId</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the source instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <remarks>
        /// <para> You must specify one of this parameter and the <b>JobId</b> parameter.</para>
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
        /// <para>The type of the DTS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MIGRATION</b>: data migration instance</para>
        /// </description></item>
        /// <item><description><para><b>SYNC</b>: data synchronization instance</para>
        /// </description></item>
        /// <item><description><para><b>SUBSCRIBE</b>: change tracking instance</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify one of this parameter and the <b>JobId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if <b>Period</b> is set to <b>Month</b>: 1, 2, 3, 4, 5, 6, 7, 8, and 9.</description></item>
        /// <item><description>Valid values if <b>Period</b> is set to <b>Year</b>: 1, 2, 3, and 5.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid and required only if <b>PayType</b> is set to <b>PrePaid</b>.</para>
        /// </description></item>
        /// <item><description><para>You can configure <b>Period</b> to specify the unit of the subscription duration.</para>
        /// </description></item>
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
