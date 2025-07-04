// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the instances.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseBodyItemsDBInstance : TeaModel {
                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                [NameInMap("BlueGreenDeploymentName")]
                [Validation(Required=false)]
                public string BlueGreenDeploymentName { get; set; }

                [NameInMap("BlueInstanceName")]
                [Validation(Required=false)]
                public string BlueInstanceName { get; set; }

                /// <summary>
                /// <para>A deprecated parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BpeEnabled")]
                [Validation(Required=false)]
                public string BpeEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the I/O burst feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The RDS edition of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Basic</b>: RDS Basic Edition</description></item>
                /// <item><description><b>HighAvailability</b>: RDS High-availability Edition</description></item>
                /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only when the <b>InstanceLevel</b> parameter is set to <b>1</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Basic</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ColdDataEnabled")]
                [Validation(Required=false)]
                public bool? ColdDataEnabled { get; set; }

                /// <summary>
                /// <para>The connection mode of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: standard mode</description></item>
                /// <item><description><b>Safe</b>: database proxy mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxx.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The creation time of the instance. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-11-05T11:26:02Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The number of CPU instances.</para>
                /// <para>Returns only when the InstanceLevel parameter is 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DBInstanceCPU")]
                [Validation(Required=false)]
                public string DBInstanceCPU { get; set; }

                /// <summary>
                /// <para>The instance type of the instance. For information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds.mys2.small</para>
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// <para>The instance description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test database</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The memory size of the node. Unit: MB.</para>
                /// <para>Returns only when the InstanceLevel parameter is 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("DBInstanceMemory")]
                [Validation(Required=false)]
                public int? DBInstanceMemory { get; set; }

                /// <summary>
                /// <para>The type of the network connection to the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Internet</b></description></item>
                /// <item><description><b>Intranet</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// <para>The instance status. For more information, see <a href="https://help.aliyun.com/document_detail/26315.html">Instance statuses</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>The storage type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ModuleList.4.ModuleCode</para>
                /// </summary>
                [NameInMap("DBInstanceStorageType")]
                [Validation(Required=false)]
                public string DBInstanceStorageType { get; set; }

                /// <summary>
                /// <para>The type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Primary</b>: primary instance</description></item>
                /// <item><description><b>Readonly</b>: read-only instance</description></item>
                /// <item><description><b>Guard</b>: disaster recovery instance</description></item>
                /// <item><description><b>Temp</b>: temporary instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dhg-7a9xxxxxxxx</para>
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// <para>The name of the dedicated cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testhostgroup</para>
                /// </summary>
                [NameInMap("DedicatedHostGroupName")]
                [Validation(Required=false)]
                public string DedicatedHostGroupName { get; set; }

                /// <summary>
                /// <para>The ID of the host on which the logger instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dh-bpxxxx</para>
                /// </summary>
                [NameInMap("DedicatedHostIdForLog")]
                [Validation(Required=false)]
                public string DedicatedHostIdForLog { get; set; }

                /// <summary>
                /// <para>The ID of the host on which the primary instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dh-bpxxxx</para>
                /// </summary>
                [NameInMap("DedicatedHostIdForMaster")]
                [Validation(Required=false)]
                public string DedicatedHostIdForMaster { get; set; }

                /// <summary>
                /// <para>The ID of the host on which the secondary instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dh-bpxxxx</para>
                /// </summary>
                [NameInMap("DedicatedHostIdForSlave")]
                [Validation(Required=false)]
                public string DedicatedHostIdForSlave { get; set; }

                /// <summary>
                /// <para>The name of the host on which the logger instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testlog</para>
                /// </summary>
                [NameInMap("DedicatedHostNameForLog")]
                [Validation(Required=false)]
                public string DedicatedHostNameForLog { get; set; }

                /// <summary>
                /// <para>The name of the host on which the primary instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testmaster</para>
                /// </summary>
                [NameInMap("DedicatedHostNameForMaster")]
                [Validation(Required=false)]
                public string DedicatedHostNameForMaster { get; set; }

                /// <summary>
                /// <para>The name of the host on which the secondary instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testslave</para>
                /// </summary>
                [NameInMap("DedicatedHostNameForSlave")]
                [Validation(Required=false)]
                public string DedicatedHostNameForSlave { get; set; }

                /// <summary>
                /// <para>The zone ID of the host on which the logger instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("DedicatedHostZoneIdForLog")]
                [Validation(Required=false)]
                public string DedicatedHostZoneIdForLog { get; set; }

                /// <summary>
                /// <para>The zone ID of the host on which the primary instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-c</para>
                /// </summary>
                [NameInMap("DedicatedHostZoneIdForMaster")]
                [Validation(Required=false)]
                public string DedicatedHostZoneIdForMaster { get; set; }

                /// <summary>
                /// <para>The zone ID of the host on which the secondary instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-d</para>
                /// </summary>
                [NameInMap("DedicatedHostZoneIdForSlave")]
                [Validation(Required=false)]
                public string DedicatedHostZoneIdForSlave { get; set; }

                /// <summary>
                /// <para>Indicates whether the release protection feature is enabled for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// <para>The time when the instance was destroyed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-11-05T11:26:02Z</para>
                /// </summary>
                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                /// <summary>
                /// <para>The database engine of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The expiration time of the instance. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// <remarks>
                /// <para> Pay-as-you-go instances never expire.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-27T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The name of the dedicated cluster to which the instance belongs. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestGroup</para>
                /// </summary>
                [NameInMap("GeneralGroupName")]
                [Validation(Required=false)]
                public string GeneralGroupName { get; set; }

                [NameInMap("GreenInstanceName")]
                [Validation(Required=false)]
                public string GreenInstanceName { get; set; }

                /// <summary>
                /// <para>The ID of the disaster recovery instance. This parameter is returned only when the instance is a primary instance and has a disaster recovery instance attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf64zsuxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("GuardDBInstanceId")]
                [Validation(Required=false)]
                public string GuardDBInstanceId { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Classic</b></description></item>
                /// <item><description><b>VPC</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Classic</para>
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// <para>Indicates whether the I/O acceleration feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: enabled</description></item>
                /// <item><description>0: disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IoAccelerationEnabled")]
                [Validation(Required=false)]
                public string IoAccelerationEnabled { get; set; }

                /// <summary>
                /// <para>The lock mode of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The instance is automatically locked due to instance expiration.</description></item>
                /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before the instance is rolled back.</description></item>
                /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked due to exhausted storage capacity.</description></item>
                /// <item><description><b>Released</b>: The instance is released. After an instance is released, the instance cannot be unlocked. You can only restore the backup data of the instance to a new instance. This process requires a long period of time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The reason why the instance was locked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_expired</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The ID of the primary instance. If this parameter is null, the instance is a primary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the multi-zone deployment method is used for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> If the multi-zone deployment method is used for the instance, the zone ID of the instance contains MAZ. Example: <c>cn-hangzhou-MAZ10(h,i)</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MutriORsignle")]
                [Validation(Required=false)]
                public bool? MutriORsignle { get; set; }

                /// <summary>
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
                /// <item><description><b>Prepaid</b>: subscription</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The IDs of the read-only instances. This parameter is returned only when the instance is a primary instance and has the read-only instances attached.</para>
                /// </summary>
                [NameInMap("ReadOnlyDBInstanceIds")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId> ReadOnlyDBInstanceId { get; set; }
                    public class DescribeDBInstancesResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId : TeaModel {
                        /// <summary>
                        /// <para>The read-only instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rr-uf6wjk5xxxxxxx</para>
                        /// </summary>
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The region ID.</para>
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
                /// <para>rg-acfmyxxxxxxx</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance supports weight-based switchovers for high availability. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>100</b>: The instance supports weight-based switchovers for high availability.</description></item>
                /// <item><description><b>0</b>: The instance does not support weight-based switchovers for high availability.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SwitchWeight")]
                [Validation(Required=false)]
                public int? SwitchWeight { get; set; }

                /// <summary>
                /// <para>The ID of the temporary instance. This parameter is returned only when the instance is a primary instance and has a temporary instance attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf64zsuxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("TempDBInstanceId")]
                [Validation(Required=false)]
                public string TempDBInstanceId { get; set; }

                /// <summary>
                /// <para>The information about the exception that is detected on the instance. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Run as expected.</para>
                /// </summary>
                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                /// <summary>
                /// <para>The severity of the exception that is detected on the instance. This parameter is returned only when the instance is created in an ApsaraDB MyBase cluster that runs MySQL on Standard Edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The instance is normal.</description></item>
                /// <item><description><b>2</b>: The specifications of the read-only instances do not match the specifications of the primary instance, and instance performance may be affected. You must adjust the specifications of these instances based on your business requirements.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TipsLevel")]
                [Validation(Required=false)]
                public int? TipsLevel { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf6adz52c2pxxxxxxx</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the instance. This parameter is returned only when the instance resides in a VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxx</para>
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6f7l4fg90xxxxxxx</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The VPC name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-huadong</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-a</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The token that is used to display the next page. If the returned entries are displayed on multiple pages, the next page can be displayed when you call this operation again with <b>NextToken</b> specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>o7PORW5o2TJg**********</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// <remarks>
        /// <para>If you specify <b>MaxResults</b> or <b>NextToken</b>, only the value <b>1</b> is returned. You can ignore the value 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// <remarks>
        /// <para>If you specify <b>MaxResults</b> or <b>NextToken</b>, only the number of entries on the current page is returned. You can ignore the number.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
