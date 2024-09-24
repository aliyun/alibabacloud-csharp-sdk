// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMarketingActivityResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1979008652307170</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>China site: 26842</description></item>
        /// <item><description>International site: 26888</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>26842</para>
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// <para>The activity parameters</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeMarketingActivityResponseBodyItems> Items { get; set; }
        public class DescribeMarketingActivityResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The RDS edition of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Basic</b>: RDS Basic Edition</description></item>
            /// <item><description><b>HighAvailability</b>: RDS High-availability Edition</description></item>
            /// <item><description><b>AlwaysOn</b>: RDS Cluster Edition</description></item>
            /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Basic</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The payment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>POSTPAY: pay-as-you-go</description></item>
            /// <item><description>PREPAY: subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a> and <a href="https://help.aliyun.com/document_detail/145759.html">Read-only ApsaraDB RDS instance types</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds.mysql.s3.large</para>
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <para>The instance family. For more information, see <a href="https://help.aliyun.com/document_detail/57184.html">Overview of instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x</para>
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// <para>The number of CPU cores that are supported by the instance type. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The disk capacity per node. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            /// <summary>
            /// <para>The database engine of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MySQL</description></item>
            /// <item><description>SQLServer</description></item>
            /// <item><description>PostgreSQL</description></item>
            /// <item><description>PPAS</description></item>
            /// <item><description>MariaDB</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The version of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-uf62br2491p5l****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-uf62br2491p5l****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public int? MaxConnections { get; set; }

            /// <summary>
            /// <para>The maximum I/O throughput. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxIombps")]
            [Validation(Required=false)]
            public int? MaxIombps { get; set; }

            /// <summary>
            /// <para>The maximum IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MaxIops")]
            [Validation(Required=false)]
            public int? MaxIops { get; set; }

            /// <summary>
            /// <para>The memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The storage type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>local_ssd</b>: local SSD</description></item>
            /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
            /// <item><description><b>cloud_essd</b>: performance level 1 (PL1) enhanced SSD (ESSD)</description></item>
            /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
            /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The RDS edition after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HighAvailability</para>
            /// </summary>
            [NameInMap("UpgradeCategory")]
            [Validation(Required=false)]
            public string UpgradeCategory { get; set; }

            /// <summary>
            /// <para>The instance type after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds.mysql.s3.large</para>
            /// </summary>
            [NameInMap("UpgradeClassCode")]
            [Validation(Required=false)]
            public string UpgradeClassCode { get; set; }

            /// <summary>
            /// <para>The instance family after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d</para>
            /// </summary>
            [NameInMap("UpgradeClassGroup")]
            [Validation(Required=false)]
            public string UpgradeClassGroup { get; set; }

            /// <summary>
            /// <para>The number of CPU cores after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("UpgradeCpu")]
            [Validation(Required=false)]
            public string UpgradeCpu { get; set; }

            /// <summary>
            /// <para>The description of the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UpgradeDescContent")]
            [Validation(Required=false)]
            public string UpgradeDescContent { get; set; }

            /// <summary>
            /// <para>The disk capacity after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("UpgradeDiskSize")]
            [Validation(Required=false)]
            public int? UpgradeDiskSize { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("UpgradeMaxConnections")]
            [Validation(Required=false)]
            public int? UpgradeMaxConnections { get; set; }

            /// <summary>
            /// <para>The maximum I/O throughput after the upgrade. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("UpgradeMaxIombps")]
            [Validation(Required=false)]
            public int? UpgradeMaxIombps { get; set; }

            /// <summary>
            /// <para>The maximum IOPS after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("UpgradeMaxIops")]
            [Validation(Required=false)]
            public int? UpgradeMaxIops { get; set; }

            /// <summary>
            /// <para>The memory size after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("UpgradeMemory")]
            [Validation(Required=false)]
            public long? UpgradeMemory { get; set; }

            /// <summary>
            /// <para>The reference price of the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23333.1</para>
            /// </summary>
            [NameInMap("UpgradeReferencePrice")]
            [Validation(Required=false)]
            public string UpgradeReferencePrice { get; set; }

            /// <summary>
            /// <para>The storage type after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("UpgradeStorageType")]
            [Validation(Required=false)]
            public string UpgradeStorageType { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D8F09DB-1124-5D78-A520-FF88FAF4351B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
