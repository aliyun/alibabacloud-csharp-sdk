// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGadInstanceMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the central node. You can call DescribeGadInstances to query the central node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp190h8y69tad****</para>
        /// </summary>
        [NameInMap("CentralDBInstanceId")]
        [Validation(Required=false)]
        public string CentralDBInstanceId { get; set; }

        /// <summary>
        /// <para>The privileged account of the central node. You can call DescribeAccounts to query the account.</para>
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
        /// <para>The region ID of the central node (primary node). You can call DescribeRegions to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CentralRegionId")]
        [Validation(Required=false)]
        public string CentralRegionId { get; set; }

        /// <summary>
        /// <para>A JSON array of database information from the central node. All databases in the array are synchronized to the current unit node. Metric description:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the database name.</description></item>
        /// <item><description><b>all</b>: specifies whether to synchronize all data in the current database or table. Valid values: <b>true</b> | <b>false</b>.</description></item>
        /// <item><description><b>Table</b>: the table name. If the <b>all</b> parameter is set to <b>false</b>, you must also specify the table names to be synchronized in the JSON array.</description></item>
        /// </list>
        /// <para>Example: <c>{    &quot;testdb&quot;: {     &quot;name&quot;: &quot;testdb&quot;,     &quot;all&quot;: false,     &quot;Table&quot;: {       &quot;order&quot;: {         &quot;name&quot;: &quot;order&quot;,         &quot;all&quot;: true       },       &quot;ordernew&quot;: {         &quot;name&quot;: &quot;ordernew&quot;,         &quot;all&quot;: true       }     }   } }</c></para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/209545.html">Objects for migration, synchronization, or subscribe</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{    &quot;testdb&quot;: {     &quot;name&quot;: &quot;testdb&quot;,     &quot;all&quot;: false,     &quot;Table&quot;: {       &quot;order&quot;: {         &quot;name&quot;: &quot;order&quot;,         &quot;all&quot;: true       },       &quot;ordernew&quot;: {         &quot;name&quot;: &quot;ordernew&quot;,         &quot;all&quot;: true       }     }   } }</para>
        /// </summary>
        [NameInMap("DBList")]
        [Validation(Required=false)]
        public string DBList { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraDB RDS global active database cluster. You can call DescribeGadInstances to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gad-rm-bp1npi2j8****</para>
        /// </summary>
        [NameInMap("GadInstanceId")]
        [Validation(Required=false)]
        public string GadInstanceId { get; set; }

        /// <summary>
        /// <para>The list of unit node (secondary node) information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UnitNode")]
        [Validation(Required=false)]
        public List<CreateGadInstanceMemberRequestUnitNode> UnitNode { get; set; }
        public class CreateGadInstanceMemberRequestUnitNode : TeaModel {
            /// <summary>
            /// <para>The name of the new unit node. The name must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description>The name must be <b>2 to 255</b> characters in length.</description></item>
            /// <item><description>The name must start with a Chinese character or a letter. It can contain digits, Chinese characters, letters, underscores (_), and hyphens (-).</description></item>
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
            /// <para>The storage capacity of the new unit node. Unit: GB. The value is incremented in steps of 5 GB. For the value range, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>. You can also call the DescribeAvailableResource operation to query the available storage capacity range for the target instance type.</para>
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
            /// <item><description><b>local_ssd</b>: local SSD</description></item>
            /// <item><description><b>cloud_ssd</b>: standard SSD cloud disk</description></item>
            /// <item><description><b>cloud_essd</b>: PL1 ESSD cloud disk</description></item>
            /// <item><description><b>cloud_essd2</b>: PL2 ESSD cloud disk</description></item>
            /// <item><description><b>cloud_essd3</b>: PL3 ESSD cloud disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("DBInstanceStorageType")]
            [Validation(Required=false)]
            public string DBInstanceStorageType { get; set; }

            /// <summary>
            /// <para>The instance type of the new unit node. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary instance types</a>. You can also call the DescribeAvailableResource operation to query the available instance types in the target region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds.mysql.t1.small</para>
            /// </summary>
            [NameInMap("DbInstanceClass")]
            [Validation(Required=false)]
            public string DbInstanceClass { get; set; }

            /// <summary>
            /// <para>The conflict resolution policy used when a primary key conflict occurs during data synchronization for the new unit node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>overwrite</b>: Overwrites the conflicting primary key on the destination node.</description></item>
            /// <item><description><b>interrupt</b>: Stops the synchronization task and reports an error.</description></item>
            /// <item><description><b>ignore</b>: Overwrites the conflicting primary key on the current node.</description></item>
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
            /// <para>The specification of the data synchronization link for the new unit node. Valid values:</para>
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
            /// <para>The region ID of the new unit node (secondary node). You can call DescribeRegions to query the region ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// <para>The <a href="https://help.aliyun.com/document_detail/43185.html">IP whitelist</a> of the new unit node. Separate multiple entries with commas (,). Entries cannot be duplicated. A maximum of 1,000 entries are allowed. The following two formats are supported:</para>
            /// <list type="bullet">
            /// <item><description>IP address format, such as <c>10.10.XX.XX</c>.</description></item>
            /// <item><description>CIDR format, such as <c>10.10.XX.XX/24</c> (Classless Inter-Domain Routing, where <b>24</b> indicates the prefix length, ranging from <b>1 to 32</b>).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.XX.XX</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The vSwitch ID of the new unit node.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1tg609m5j85****</para>
            /// </summary>
            [NameInMap("VSwitchID")]
            [Validation(Required=false)]
            public string VSwitchID { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID of the new unit node.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp19ame5m1r3o****</para>
            /// </summary>
            [NameInMap("VpcID")]
            [Validation(Required=false)]
            public string VpcID { get; set; }

            /// <summary>
            /// <para>The zone ID of the new unit node. You can call DescribeRegions to query the zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

            /// <summary>
            /// <para>The zone ID of the secondary node for the new unit node. You can call DescribeRegions to query the zone ID.</para>
            /// <list type="bullet">
            /// <item><description>If this value is the same as the <b>ZoneId</b> of the current unit node, the single-zone deployment is used.</description></item>
            /// <item><description>If this value is different from the <b>ZoneId</b> of the current unit node, the multi-zone deployment is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneIDSlave1")]
            [Validation(Required=false)]
            public string ZoneIDSlave1 { get; set; }

            /// <summary>
            /// <para>The zone ID of the logger node for the new unit node. You can call DescribeRegions to query the zone ID.</para>
            /// <list type="bullet">
            /// <item><description>If this value is the same as the <b>ZoneId</b> of the current unit node, the single-zone deployment is used.</description></item>
            /// <item><description>If this value is different from the <b>ZoneId</b> of the current unit node, the multi-zone deployment is used.</description></item>
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
