// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesForCloneResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details about the instances.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesForCloneResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesForCloneResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesForCloneResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesForCloneResponseBodyItemsDBInstance : TeaModel {
                /// <summary>
                /// <para>The RDS edition of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Basic</b>: RDS Basic Edition</description></item>
                /// <item><description><b>HighAvailability</b>: RDS High-availability Edition</description></item>
                /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HighAvailability</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

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
                /// <para>The time when the instance was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-11-05T11:26:02Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The instance type of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql.n1.micro.1</para>
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// <para>The name of the instance. It must be 2 to 256 characters in length. The value can contain letters, digits, underscores (_), and hyphens (-). The value must start with a letter.</para>
                /// <remarks>
                /// <para>The value cannot start with http:// or https://.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The network connection type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Internet</b></description></item>
                /// <item><description><b>Intranet</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Intranet</para>
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// <para>The status of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/26315.html">Instance state table</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>The storage type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>local_ssd/ephemeral_ssd</b>: local SSD</description></item>
                /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
                /// <item><description><b>cloud_essd</b>: enhanced SSD (ESSD)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>local_ssd</para>
                /// </summary>
                [NameInMap("DBInstanceStorageType")]
                [Validation(Required=false)]
                public string DBInstanceStorageType { get; set; }

                /// <summary>
                /// <para>The role of the instance. Valid values:</para>
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
                /// <para>The time when the instance was destroyed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-12-05T11:26:02Z</para>
                /// </summary>
                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

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
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The time when the instance expired. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-11-28T11:26:02Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The ID of the disaster recovery instance. This parameter is returned only when the instance is a primary instance and has a disaster recovery instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf64zsuxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("GuardDBInstanceId")]
                [Validation(Required=false)]
                public string GuardDBInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the instance role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InsId")]
                [Validation(Required=false)]
                public int? InsId { get; set; }

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
                /// <para>The lock method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The instance is automatically locked after it expires.</description></item>
                /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before a rollback.</description></item>
                /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked because its storage capacity is exhausted and the instance is inaccessible.</description></item>
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
                /// <para>The ID of the primary instance. If the value of this parameter is null, the instance is a primary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("MasterInstanceId")]
                [Validation(Required=false)]
                public string MasterInstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether multi-region deployment is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Multi-region deployment is used.</description></item>
                /// <item><description><b>false</b>: Multi-region deployment is not used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
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
                /// <para>An array consisting of the IDs of the read-only instances that are attached to the primary instance.</para>
                /// </summary>
                [NameInMap("ReadOnlyDBInstanceIds")]
                [Validation(Required=false)]
                public DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIds ReadOnlyDBInstanceIds { get; set; }
                public class DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIds : TeaModel {
                    [NameInMap("ReadOnlyDBInstanceId")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId> ReadOnlyDBInstanceId { get; set; }
                    public class DescribeDBInstancesForCloneResponseBodyItemsDBInstanceReadOnlyDBInstanceIdsReadOnlyDBInstanceId : TeaModel {
                        /// <summary>
                        /// <para>The ID of the read-only instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rm-bpxxxxxxxxx</para>
                        /// </summary>
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>None.</para>
                /// 
                /// <b>Example:</b>
                /// <para>N/A</para>
                /// </summary>
                [NameInMap("ReplicateId")]
                [Validation(Required=false)]
                public string ReplicateId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmyxxxxx</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the temporary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sub138xxxxx_rm-xxxxx</para>
                /// </summary>
                [NameInMap("TempDBInstanceId")]
                [Validation(Required=false)]
                public string TempDBInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf6adz52c2pxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the instance in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1opxu1zkhxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
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
        /// <para>1E43AAE0-BEE8-43DA-860D-EAF2AA0724DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
