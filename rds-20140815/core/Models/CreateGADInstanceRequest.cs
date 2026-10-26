// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGADInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the primary instance. You can call the DescribeDBInstances operation to query the ID. This instance serves as the central node (primary node) of the ApsaraDB RDS global active database cluster.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A primary instance ID can serve as the central node of only one ApsaraDB RDS global active database cluster.</description></item>
        /// <item><description>Only primary ApsaraDB RDS for MySQL instances in the China (Hangzhou), China (Shanghai), China (Qingdao), China (Beijing), China (Zhangjiakou), China (Shenzhen), and China (Chengdu) regions can serve as the central node of an ApsaraDB RDS global active database cluster.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("CentralDBInstanceId")]
        [Validation(Required=false)]
        public string CentralDBInstanceId { get; set; }

        /// <summary>
        /// <para>The privileged account of the central node. You can call the DescribeAccounts operation to query the account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CentralRdsDtsAdminAccount")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminAccount { get; set; }

        /// <summary>
        /// <para>The password of the privileged account for the central node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test12345</para>
        /// </summary>
        [NameInMap("CentralRdsDtsAdminPassword")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminPassword { get; set; }

        /// <summary>
        /// <para>The region ID of the central node. You can call the DescribeRegions operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CentralRegionId")]
        [Validation(Required=false)]
        public string CentralRegionId { get; set; }

        /// <summary>
        /// <para>The JSON array of database information in the central node. All database information in the array is used for synchronization to the current unit node (secondary node). Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the database.</description></item>
        /// <item><description><b>all</b>: specifies whether to synchronize all data in the current database or table. Valid values: <b>true</b> and <b>false</b>.</description></item>
        /// <item><description><b>Table</b>: the name of the table. If the <b>all</b> parameter is set to <b>false</b>, you must also include the names of the tables to be synchronized in the JSON array.</description></item>
        /// </list>
        /// <para>Example: <c>{    &quot;testdb&quot;: {     &quot;name&quot;: &quot;testdb&quot;,     &quot;all&quot;: false,     &quot;Table&quot;: {       &quot;order&quot;: {         &quot;name&quot;: &quot;order&quot;,         &quot;all&quot;: true       },       &quot;ordernew&quot;: {         &quot;name&quot;: &quot;ordernew&quot;,         &quot;all&quot;: true       }     }   } }</c></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{    &quot;testdb&quot;: {     &quot;name&quot;: &quot;testdb&quot;,     &quot;all&quot;: false,     &quot;Table&quot;: {       &quot;order&quot;: {         &quot;name&quot;: &quot;order&quot;,         &quot;all&quot;: true       },       &quot;ordernew&quot;: {         &quot;name&quot;: &quot;ordernew&quot;,         &quot;all&quot;: true       }     }   } }</para>
        /// </summary>
        [NameInMap("DBList")]
        [Validation(Required=false)]
        public string DBList { get; set; }

        /// <summary>
        /// <para>The name of the ApsaraDB RDS global active database cluster.</para>
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
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateGADInstanceRequestTag> Tag { get; set; }
        public class CreateGADInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can create up to N tag keys at a time. Valid values of N: <b>1</b> to <b>20</b>. Empty strings are not allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value that corresponds to the tag key. You can create up to N tag values at a time. Valid values of N: <b>1</b> to <b>20</b>. Empty strings are allowed.</para>
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
            /// <para>The name of the new unit node. The name must meet the following rules:</para>
            /// <list type="bullet">
            /// <item><description>The name must be <b>2</b> to <b>255</b> characters in length.</description></item>
            /// <item><description>The name must start with a letter or a Chinese character and can contain letters, Chinese characters, digits, underscores (_), and hyphens (-).</description></item>
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
            /// <para>The storage capacity of the new unit node. Unit: GB. The storage capacity increases in increments of 5 GB. For more information about the valid values, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary instance types</a>. You can also call the DescribeAvailableResource operation to query the available storage capacity range for the target instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public long? DBInstanceStorage { get; set; }

            /// <summary>
            /// <para>The instance storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>local_ssd</b>: Premium Local SSD (recommended).</description></item>
            /// <item><description><b>cloud_ssd</b>: standard SSD (not recommended, and no longer available in some regions).</description></item>
            /// <item><description><b>cloud_essd</b>: PL1 ESSD.</description></item>
            /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
            /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
            /// </list>
            /// <para>The default value of this parameter is automatically determined based on the instance type code specified in the <b>DBInstanceClass</b> parameter:</para>
            /// <list type="bullet">
            /// <item><description>If the instance type code is for a Premium Local SSD, the default value is <b>local_ssd</b>.</description></item>
            /// <item><description>If the instance type code is for a cloud disk, the default value is <b>cloud_essd</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd2</para>
            /// </summary>
            [NameInMap("DBInstanceStorageType")]
            [Validation(Required=false)]
            public string DBInstanceStorageType { get; set; }

            /// <summary>
            /// <para>The instance type of the new unit node. For more information about the valid values, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary instance types</a>. You can also call the DescribeAvailableResource operation to query the available instance types in the target region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds.mysql.t1.small</para>
            /// </summary>
            [NameInMap("DbInstanceClass")]
            [Validation(Required=false)]
            public string DbInstanceClass { get; set; }

            /// <summary>
            /// <para>The resolution policy for primary key conflicts that occur during synchronization on the new unit node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>overwrite</b>: overwrites the conflicting primary keys in the destination node.</description></item>
            /// <item><description><b>interrupt</b>: interrupts the synchronization task, reports an error, and exits.</description></item>
            /// <item><description><b>ignore</b>: ignores the conflicting primary keys in the current node.</description></item>
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
            /// <para>The data synchronization link specification for the new unit node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>small</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>large</b></description></item>
            /// <item><description><b>micro</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about the differences between specifications, see <a href="https://help.aliyun.com/document_detail/26605.html">Data synchronization link specifications</a>.</para>
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
            /// <para>The database engine of the new unit node. Only <b>MySQL</b> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The database engine version of the new unit node. Valid values:</para>
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
            /// <para>The billing method of the new unit node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
            /// <item><description><b>Prepaid</b>: subscription.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The system automatically generates an order and completes the payment. Manual payment confirmation is not required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The region ID of the new unit node. You can call the DescribeRegions operation to query the region ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// <para>The <a href="https://help.aliyun.com/document_detail/43185.html">IP whitelist</a> of the new unit node. Separate multiple entries with commas (,). Duplicate entries are not allowed. A maximum of 1,000 entries are supported. The following two formats are supported:</para>
            /// <list type="bullet">
            /// <item><description>IP address format, such as <c>10.10.10.10</c>.</description></item>
            /// <item><description>CIDR block format, such as <c>10.10.10.10/24</c> (Classless Inter-Domain Routing, where <b>24</b> indicates the length of the prefix in the address, ranging from <b>1</b> to <b>32</b>).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.10</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The vSwitch ID of the new unit node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1tg609m5j85****</para>
            /// </summary>
            [NameInMap("VSwitchID")]
            [Validation(Required=false)]
            public string VSwitchID { get; set; }

            /// <summary>
            /// <para>The VPC ID of the new unit node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp19ame5m1r3o****</para>
            /// </summary>
            [NameInMap("VpcID")]
            [Validation(Required=false)]
            public string VpcID { get; set; }

            /// <summary>
            /// <para>The zone ID of the new unit node. You can call the DescribeRegions operation to query the zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

            /// <summary>
            /// <para>The active zone ID of the secondary node for the new unit node. You can call the DescribeRegions operation to query the active zone ID.</para>
            /// <list type="bullet">
            /// <item><description>If this value is the same as the <b>ZoneId</b> of the current unit node, it is a single-zone deployment.</description></item>
            /// <item><description>If this value is different from the <b>ZoneId</b> of the current unit node, it is a multi-zone deployment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneIDSlave1")]
            [Validation(Required=false)]
            public string ZoneIDSlave1 { get; set; }

            /// <summary>
            /// <para>The active zone ID of the logger node for the new unit node. You can call the DescribeRegions operation to query the active zone ID.</para>
            /// <list type="bullet">
            /// <item><description>If this value is the same as the <b>ZoneId</b> of the current unit node, it is a single-zone deployment.</description></item>
            /// <item><description>If this value is different from the <b>ZoneId</b> of the current unit node, it is a multi-zone deployment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneIDSlave2")]
            [Validation(Required=false)]
            public string ZoneIDSlave2 { get; set; }

        }

    }

}
