// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The database instance information.</para>
        /// </summary>
        [NameInMap("DBInstance")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyDBInstance DBInstance { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBInstance : TeaModel {
            /// <summary>
            /// <para>Indicates whether the In-Memory Column Index feature is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanNotCreateColumnar")]
            [Validation(Required=false)]
            public bool? CanNotCreateColumnar { get; set; }

            /// <summary>
            /// <para>The CN node specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>polarx.x4.medium.2e</b>: 2 cores, 8 GB</description></item>
            /// <item><description><b>polarx.x4.large.2e</b>: 4 cores, 16 GB</description></item>
            /// <item><description><b>polarx.x8.large.2e</b>: 4 cores, 32 GB</description></item>
            /// <item><description><b>polarx.x4.xlarge.2e</b>: 8 cores, 32 GB</description></item>
            /// <item><description><b>polarx.x8.xlarge.2e</b>: 8 cores, 64 GB</description></item>
            /// <item><description><b>polarx.x4.2xlarge.2e</b>: 16 cores, 64 GB</description></item>
            /// <item><description><b>polarx.x8.2xlarge.2e</b>: 16 cores, 128 GB</description></item>
            /// <item><description><b>polarx.x4.4xlarge.2e</b>: 32 cores, 128 GB</description></item>
            /// <item><description><b>polarx.x8.4xlarge.2e</b>: 32 cores, 256 GB</description></item>
            /// <item><description><b>polarx.st.8xlarge.2e</b>: 60 cores, 470 GB</description></item>
            /// <item><description><b>polarx.st.12xlarge.2e</b>: 90 cores, 720 GB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>polarx.x4.xlarge.2e</para>
            /// </summary>
            [NameInMap("CnNodeClassCode")]
            [Validation(Required=false)]
            public string CnNodeClassCode { get; set; }

            /// <summary>
            /// <para>The number of CN nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CnNodeCount")]
            [Validation(Required=false)]
            public int? CnNodeCount { get; set; }

            /// <summary>
            /// <para>The name of the column store engine instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("ColumnarInstanceName")]
            [Validation(Required=false)]
            public string ColumnarInstanceName { get; set; }

            /// <summary>
            /// <para>The column store read-only instance information.</para>
            /// </summary>
            [NameInMap("ColumnarReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ColumnarReadDBInstances { get; set; }

            /// <summary>
            /// <para>The commodity code of the instance. The value is fixed as drds_polarxpost_public_cn.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drds_polarxpost_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The endpoint information.</para>
            /// </summary>
            [NameInMap("ConnAddrs")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceConnAddrs> ConnAddrs { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceConnAddrs : TeaModel {
                /// <summary>
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polardbx-xxx.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The connection port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// <para>The connection type. <b>VPC</b> indicates an internal network connection. <b>PUBLIC</b> indicates a public network connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>VPC ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxxxxx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-*********</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The internal CloudInstanceId within the VPC. You can ignore this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-zkralxpc5d****</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// <para>The internal network connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-sprpx766vo****.polarx.singapore.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            [NameInMap("CpuType")]
            [Validation(Required=false)]
            public string CpuType { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-31T08:56:25.000+0000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ReadWrite</b>: primary instance.</description></item>
            /// <item><description><b>ReadOnly</b>: read-only instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ReadWrite</para>
            /// </summary>
            [NameInMap("DBInstanceType")]
            [Validation(Required=false)]
            public string DBInstanceType { get; set; }

            /// <summary>
            /// <para>The node specifications of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx.x4.large.2e</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The number of instance nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DBNodeCount")]
            [Validation(Required=false)]
            public int? DBNodeCount { get; set; }

            /// <summary>
            /// <para>The database node information.</para>
            /// </summary>
            [NameInMap("DBNodes")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceDBNodes> DBNodes { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceDBNodes : TeaModel {
                /// <summary>
                /// <para>The name of the compute node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-i-********</para>
                /// </summary>
                [NameInMap("ComputeNodeId")]
                [Validation(Required=false)]
                public string ComputeNodeId { get; set; }

                /// <summary>
                /// <para>The name of the storage node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-xdb-xxxxxx</para>
                /// </summary>
                [NameInMap("DataNodeId")]
                [Validation(Required=false)]
                public string DataNodeId { get; set; }

                /// <summary>
                /// <para>The logical node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxi-*********</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polarx.x4.large.2e</para>
                /// </summary>
                [NameInMap("NodeClass")]
                [Validation(Required=false)]
                public string NodeClass { get; set; }

                /// <summary>
                /// <para>The region ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The zone in which the node resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-a</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The database type. The value is fixed as polarx.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The database engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.5</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test instance</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the DN nodes of the instance have different specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The specifications are different.</description></item>
            /// <item><description>false: The specifications are the same.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DifferentDNSpec")]
            [Validation(Required=false)]
            public bool? DifferentDNSpec { get; set; }

            /// <summary>
            /// <para>The DN node specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>mysql.n2.medium.25</b>: 2 cores, 4 GB</description></item>
            /// <item><description><b>mysql.n4.medium.25</b>: 2 cores, 8 GB</description></item>
            /// <item><description><b>mysql.x8.medium.25</b>: 2 cores, 16 GB</description></item>
            /// <item><description><b>mysql.n2.large.25</b>: 4 cores, 8 GB</description></item>
            /// <item><description><b>mysql.n4.large.25</b>: 4 cores, 16 GB</description></item>
            /// <item><description><b>mysql.x8.large.25</b>: 4 cores, 32 GB</description></item>
            /// <item><description><b>mysql.n2.xlarge.25</b>: 8 cores, 16 GB</description></item>
            /// <item><description><b>mysql.n4.xlarge.25</b>: 8 cores, 32 GB</description></item>
            /// <item><description><b>mysql.x8.xlarge.25</b>: 8 cores, 64 GB</description></item>
            /// <item><description><b>mysql.n4.2xlarge.25</b>: 16 cores, 64 GB</description></item>
            /// <item><description><b>mysql.x8.2xlarge.25</b>: 16 cores, 128 GB</description></item>
            /// <item><description><b>mysql.x4.4xlarge.25</b>: 32 cores, 128 GB</description></item>
            /// <item><description><b>mysql.x8.4xlarge.25</b>: 32 cores, 256 GB</description></item>
            /// <item><description><b>mysql.st.8xlarge.25</b>: 60 cores, 470 GB</description></item>
            /// <item><description><b>mysql.st.12xlarge.25</b>: 90 cores, 720 GB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.x8.large.25</para>
            /// </summary>
            [NameInMap("DnNodeClassCode")]
            [Validation(Required=false)]
            public string DnNodeClassCode { get; set; }

            /// <summary>
            /// <para>The number of DN nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DnNodeCount")]
            [Validation(Required=false)]
            public int? DnNodeCount { get; set; }

            /// <summary>
            /// <para>The disk space of the DN data nodes, in GB.</para>
            /// </summary>
            [NameInMap("DnStorageSpace")]
            [Validation(Required=false)]
            public string DnStorageSpace { get; set; }

            /// <summary>
            /// <para>The database type. The value is fixed as polarx.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The expiration time. The time is in the yyyy-MM-ddTHH:mm:ss.sss+0000 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-31T16:00:00.000+0000</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The instance has expired.</description></item>
            /// <item><description><b>false</b>: The instance is running normally.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }

            [NameInMap("GdnInstanceName")]
            [Validation(Required=false)]
            public string GdnInstanceName { get; set; }

            [NameInMap("GdnMemberList")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceGdnMemberList> GdnMemberList { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceGdnMemberList : TeaModel {
                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("GdnRole")]
            [Validation(Required=false)]
            public string GdnRole { get; set; }

            /// <summary>
            /// <para>The ID of the primary instance. If this parameter is not returned, the instance is a primary instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-zkralxpc5d****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instance DPI engine version code. This is an internal parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("KindCode")]
            [Validation(Required=false)]
            public int? KindCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LTSVersions")]
            [Validation(Required=false)]
            public List<string> LTSVersions { get; set; }

            /// <summary>
            /// <para>The latest kernel version supported by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx-kernel_5.4.11-16301083_xcluster-20210805</para>
            /// </summary>
            [NameInMap("LatestMinorVersion")]
            [Validation(Required=false)]
            public string LatestMinorVersion { get; set; }

            /// <summary>
            /// <para>The lock mode of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unlock</b>: The instance is running normally.</description></item>
            /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
            /// <item><description><b>LockByExpiration</b>: The instance is automatically locked due to expiration.</description></item>
            /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before a rollback.</description></item>
            /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked because the storage is full.</description></item>
            /// <item><description><b>LockReadInstanceByDiskQuota</b>: The read-only instance is automatically locked because the storage is full.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The end time of the maintenance window. The time is in UTC. Add 8 hours to obtain the maintenance window displayed in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>06:00</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window. The time is in UTC. Add 8 hours to obtain the maintenance window displayed in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>06:00</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The current kernel version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx-kernel_5.4.11-16301083_xcluster-20210805</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>The network type of the instance. Only VPC is supported, which indicates a virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
            /// <item><description><b>Prepaid</b>: subscription.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The internal network connection port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("PrimaryInstanceId")]
            [Validation(Required=false)]
            public string PrimaryInstanceId { get; set; }

            /// <summary>
            /// <para>The primary zone.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen-e</para>
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// <para>The list of read-only instance names.</para>
            /// </summary>
            [NameInMap("ReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ReadDBInstances { get; set; }

            /// <summary>
            /// <para>The region in which the instance resides.</para>
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
            /// <para>rg-*********</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The three-role mode status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RightsSeparationEnabled")]
            [Validation(Required=false)]
            public bool? RightsSeparationEnabled { get; set; }

            /// <summary>
            /// <para>The three-role mode status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b>: Disabled.</description></item>
            /// <item><description><b>enabled</b>: Enabled.</description></item>
            /// <item><description><b>processing</b>: Being processed.</description></item>
            /// <item><description><b>unknown</b>: Unknown. The instance may be disconnected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("RightsSeparationStatus")]
            [Validation(Required=false)]
            public string RightsSeparationStatus { get; set; }

            /// <summary>
            /// <para>The secondary zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen-a</para>
            /// </summary>
            [NameInMap("SecondaryZone")]
            [Validation(Required=false)]
            public string SecondaryZone { get; set; }

            /// <summary>
            /// <para>The instance edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enterprise</b>: Enterprise Edition.</description></item>
            /// <item><description><b>standard</b>: Standard Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            [NameInMap("SpecCategory")]
            [Validation(Required=false)]
            public string SpecCategory { get; set; }

            /// <summary>
            /// <para>The instance status. For more information, see <a href="https://help.aliyun.com/document_detail/339826.html">Instance status table</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The used storage space, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17042505728</para>
            /// </summary>
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }

            /// <summary>
            /// <para>The tag set.</para>
            /// </summary>
            [NameInMap("TagSet")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceTagSet> TagSet { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceTagSet : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key2</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value2</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The third zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen-e</para>
            /// </summary>
            [NameInMap("TertiaryZone")]
            [Validation(Required=false)]
            public string TertiaryZone { get; set; }

            /// <summary>
            /// <para>The topology type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3azones</b>: three-zone deployment.</description></item>
            /// <item><description><b>1azone</b>: single-zone deployment.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3azones</para>
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ReadWrite</b>: primary instance.</description></item>
            /// <item><description><b>ReadOnly</b>: read-only instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ReadWrite</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxxxx</para>
            /// </summary>
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-********</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone in which the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
