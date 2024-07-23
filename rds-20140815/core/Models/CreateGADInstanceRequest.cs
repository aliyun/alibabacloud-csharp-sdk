// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGADInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the primary instance. You can call the DescribeDBInstances operation to query the instance ID. The primary instance serves as the central node of the global active database cluster.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A primary instance can serve only as the central node of a single global active database cluster.</description></item>
        /// <item><description>The primary instance can serve as the central node of the global active database cluster only in the following regions: China (Hangzhou), China (Shanghai), China (Qingdao), China (Beijing), China (Zhangjiakou), China (Shenzhen), and China (Chengdu).</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*******</para>
        /// </summary>
        [NameInMap("CentralDBInstanceId")]
        [Validation(Required=false)]
        public string CentralDBInstanceId { get; set; }

        /// <summary>
        /// <para>The username of the privileged account of the central node. You can call the DescribeAccounts operation to query the privileged account of the central node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CentralRdsDtsAdminAccount")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminAccount { get; set; }

        /// <summary>
        /// <para>The password of the privileged account of the central node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test12345</para>
        /// </summary>
        [NameInMap("CentralRdsDtsAdminPassword")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminPassword { get; set; }

        /// <summary>
        /// <para>The region ID of the central node. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CentralRegionId")]
        [Validation(Required=false)]
        public string CentralRegionId { get; set; }

        /// <summary>
        /// <para>A JSON array that consists of the information about a specified database on the central node. All database information that you specify in this array is synchronized to the unit nodes of the global active database cluster. The JSON array contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the database.</description></item>
        /// <item><description><b>all</b>: specifies whether to synchronize all data in the database or the table. Valid values: <b>true</b> and <b>false</b>.</description></item>
        /// <item><description><b>Table</b>: the name of the table. If you set the <b>all</b> field to <b>false</b>, you must nest the name of the table that you want to synchronize into the JSON array.</description></item>
        /// </list>
        /// <para>Example: <c>{ &quot;testdb&quot;: { &quot;name&quot;: &quot;testdb&quot;, &quot;all&quot;: false, &quot;Table&quot;: { &quot;order&quot;: { &quot;name&quot;: &quot;order&quot;, &quot;all&quot;: true }, &quot;ordernew&quot;: { &quot;name&quot;: &quot;ordernew&quot;, &quot;all&quot;: true } } } }</c></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{    &quot;testdb&quot;: {     &quot;name&quot;: &quot;testdb&quot;,     &quot;all&quot;: false,     &quot;Table&quot;: {       &quot;order&quot;: {         &quot;name&quot;: &quot;order&quot;,         &quot;all&quot;: true       },       &quot;ordernew&quot;: {         &quot;name&quot;: &quot;ordernew&quot;,         &quot;all&quot;: true       }     }   } }</para>
        /// </summary>
        [NameInMap("DBList")]
        [Validation(Required=false)]
        public string DBList { get; set; }

        /// <summary>
        /// <para>The name of the global active database cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>An array that consists of the details about the tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateGADInstanceRequestTag> Tag { get; set; }
        public class CreateGADInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. You can create N tag keys at a time. Valid values of N: <b>1 to 20</b>. The value of this parameter cannot be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. You can create N tag values at a time. Valid values of N: <b>1 to 20</b>. The value of this parameter can be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The information about the unit node.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UnitNode")]
        [Validation(Required=false)]
        public List<CreateGADInstanceRequestUnitNode> UnitNode { get; set; }
        public class CreateGADInstanceRequestUnitNode : TeaModel {
            /// <summary>
            /// <para>The name of the unit node that you want to create. The name must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description>The name must be <b>2 to 255</b> characters in length.</description></item>
            /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-) and must start with a letter.</description></item>
            /// <item><description>The name cannot start with <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            /// <summary>
            /// <para>The storage capacity of the unit node that you want to create. Unit: GB You can adjust the storage capacity in increments of 5 GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>. You can also call the DescribeAvailableResource operation to query the storage capacity range that is supported by the new instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public long? DBInstanceStorage { get; set; }

            /// <summary>
            /// <para>The storage type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>local_ssd</b>: local SSD. This is the recommended storage type.</description></item>
            /// <item><description><b>cloud_ssd</b>: standard SSD. This storage type is not recommended. Standard SSDs are no longer available for purchase in some Alibaba Cloud regions.</description></item>
            /// <item><description><b>cloud_essd</b>: PL1 ESSD</description></item>
            /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
            /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
            /// </list>
            /// <para>The default value of this parameter is determined by the instance type specified by the <b>DBInstanceClass</b> parameter.</para>
            /// <list type="bullet">
            /// <item><description>If the instance type specifies the local SSD storage type, the default value of this parameter is <b>local_ssd</b>.</description></item>
            /// <item><description>If the instance type specifies the cloud disk storage type, the default value of this parameter is <b>cloud_essd</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd2</para>
            /// </summary>
            [NameInMap("DBInstanceStorageType")]
            [Validation(Required=false)]
            public string DBInstanceStorageType { get; set; }

            /// <summary>
            /// <para>The instance type of the unit node that you want to create. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>. You can call the DescribeAvailableResource operation to query the available instance types in a region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds.mysql.t1.small</para>
            /// </summary>
            [NameInMap("DbInstanceClass")]
            [Validation(Required=false)]
            public string DbInstanceClass { get; set; }

            /// <summary>
            /// <para>The conflict resolution policy based on which Data Transmission Service (DTS) responds to primary key conflicts during data synchronization to the unit node that you want to create. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>overwrite</b>: DTS overwrites the conflicting primary key on the destination node.</description></item>
            /// <item><description><b>interrupt</b>: DTS stops the synchronization task, reports an error, and then exits.</description></item>
            /// <item><description><b>ignore</b>: DTS hides the conflicting primary key on the node.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>overwrite</para>
            /// </summary>
            [NameInMap("DtsConflict")]
            [Validation(Required=false)]
            public string DtsConflict { get; set; }

            /// <summary>
            /// <para>The specifications of the data synchronization task for the unit node that you want to create. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>small</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>large</b></description></item>
            /// <item><description><b>micro</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/26605.html">Specifications of data synchronization tasks</a>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("DtsInstanceClass")]
            [Validation(Required=false)]
            public string DtsInstanceClass { get; set; }

            /// <summary>
            /// <para>The database engine of the unit node that you want to create. Set the value to <b>MySQL</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The database engine version of the unit node that you want to create. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>8.0</b></description></item>
            /// <item><description><b>5.7</b></description></item>
            /// <item><description><b>5.6</b></description></item>
            /// <item><description><b>5.5</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The billing method of the unit node that you want to create. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
            /// <item><description><b>Prepaid</b>: subscription</description></item>
            /// </list>
            /// <remarks>
            /// <para> The system automatically generates a purchase order and completes the payment. You do not need to manually confirm the purchase order or complete the payment.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The region ID of the unit node that you want to create. You can call the DescribeRegions operation to query the most recent region list.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// <para>The <a href="https://help.aliyun.com/document_detail/43185.html">IP address whitelist</a> of the unit node that you want to create. If you want to add more than one entry to the IP address whitelist, separate the entries with commas (,). Each entry must be unique. The IP address whitelist can contain up to 1,000 entries. The entries in the IP address whitelist must be in one of the following formats:</para>
            /// <list type="bullet">
            /// <item><description>IP addresses, such as <c>10.10.10.10</c>.</description></item>
            /// <item><description>CIDR blocks, such as <c>10.10.10.10/24</c>. In this example, <b>24</b> indicates that the prefix of the IP address in the whitelist is 24 bits in length. You can replace 24 with a value within the range of <b>1 to 32</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.10</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The vSwitch ID of the unit node that you want to create.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1tg609m5j85********</para>
            /// </summary>
            [NameInMap("VSwitchID")]
            [Validation(Required=false)]
            public string VSwitchID { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID of the unit node that you want to create.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp19ame5m1r3o********</para>
            /// </summary>
            [NameInMap("VpcID")]
            [Validation(Required=false)]
            public string VpcID { get; set; }

            /// <summary>
            /// <para>The zone ID of the unit node that you want to create. You can call the DescribeRegions operation to query the zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

            /// <summary>
            /// <para>The zone ID of the secondary node of the unit node that you want to create. You can call the DescribeRegions operation to query the zone ID.</para>
            /// <list type="bullet">
            /// <item><description>If the value of this parameter is the same as the <b>zone ID</b> of the unit node that you want to create, the single-zone deployment method is used.</description></item>
            /// <item><description>If the value of this parameter is different from the <b>zone ID</b> of the unit node that you want to create, the multiple-zone deployment method is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneIDSlave1")]
            [Validation(Required=false)]
            public string ZoneIDSlave1 { get; set; }

            /// <summary>
            /// <para>The zone ID of the logger node of the unit node that you want to create. You can call the DescribeRegions operation to query the zone ID.</para>
            /// <list type="bullet">
            /// <item><description>If the value of this parameter is the same as the <b>zone ID</b> of the unit node that you want to create, the single-zone deployment method is used.</description></item>
            /// <item><description>If the value of this parameter is different from the <b>zone ID</b> of the unit node that you want to create, the multiple-zone deployment method is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneIDSlave2")]
            [Validation(Required=false)]
            public string ZoneIDSlave2 { get; set; }

        }

    }

}
