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
            /// <para>Specifies whether the AI gateway is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AiGatewayEnabled")]
            [Validation(Required=false)]
            public string AiGatewayEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the In-Memory Column Index (IMCI) feature is supported.</para>
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
            /// <item><description><b>polarx.st.12xlarge.2e</b>: 90 cores, 720 GB</description></item>
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
            /// <para>The commodity type of the instance. The value is fixed as drds_polarxpost_public_cn.</para>
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
                /// <para>The connection type. <b>VPC</b> indicates an internal network connection, and <b>PUBLIC</b> indicates a public network connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
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
                /// <para>The internal CloudInstanceId in the VPC. You can ignore this parameter.</para>
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

            /// <summary>
            /// <para>The processor type. Default value: intel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intel | hygon</para>
            /// </summary>
            [NameInMap("CpuType")]
            [Validation(Required=false)]
            public string CpuType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
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
            /// <item><description><b>ReadWrite</b>: Primary instance.</description></item>
            /// <item><description><b>ReadOnly</b>: Read-only instance.</description></item>
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
            /// <para>The number of nodes in the instance.</para>
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
                /// <para>The name of the zone where the node is deployed.</para>
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
            /// <para>The database version.</para>
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
            /// <para>Indicates whether the specifications of the DN nodes in the instance are different. Valid values:</para>
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
            /// <item><description><b>mysql.st.12xlarge.25</b>: 90 cores, 720 GB</description></item>
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
            /// <para>The disk space of the storage node. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
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

            /// <summary>
            /// <para>The database engine version. Default value: 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0 | 3.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The expiration time. The format is yyyy-MM-ddTHH:mm:ss.sss+0000 (UTC).</para>
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
            /// <item><description><b>true</b>: Expired.</description></item>
            /// <item><description><b>false</b>: Normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }

            /// <summary>
            /// <para>The GDN instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gdn-zkrkuykqglbizdhm</para>
            /// </summary>
            [NameInMap("GdnInstanceName")]
            [Validation(Required=false)]
            public string GdnInstanceName { get; set; }

            /// <summary>
            /// <para>The GDN member list.</para>
            /// </summary>
            [NameInMap("GdnMemberList")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstanceGdnMemberList> GdnMemberList { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstanceGdnMemberList : TeaModel {
                /// <summary>
                /// <para>The name of the member, which is the name of the PolarDB-X instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc</para>
                /// </summary>
                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <para>The role of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>master</b>: The primary node.</description></item>
                /// <item><description><b>standby</b>: The secondary node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>polarx_cn</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The role in the global database network (GDN).</para>
            /// 
            /// <b>Example:</b>
            /// <para>master | standby</para>
            /// </summary>
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
            /// <para>The database engine version of the instance DPI engine. This is an internal parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("KindCode")]
            [Validation(Required=false)]
            public int? KindCode { get; set; }

            /// <summary>
            /// <para>The instance version.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LTSVersions")]
            [Validation(Required=false)]
            public List<string> LTSVersions { get; set; }

            /// <summary>
            /// <para>The latest kernel Milvus version supported by the instance.</para>
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
            /// <item><description><b>Unlock</b>: Normal.</description></item>
            /// <item><description><b>ManualLock</b>: Manually locked.</description></item>
            /// <item><description><b>LockByExpiration</b>: Automatically locked due to expiration.</description></item>
            /// <item><description><b>LockByRestoration</b>: Automatically locked before a rollback.</description></item>
            /// <item><description><b>LockByDiskQuota</b>: Automatically locked due to full storage space.</description></item>
            /// <item><description><b>LockReadInstanceByDiskQuota</b>: Automatically locked due to full storage space of the read-only instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The end time of the maintenance window for the instance. The time is in UTC. Add 8 hours to obtain the maintenance window displayed in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>06:00</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window for the instance. The time is in UTC. Add 8 hours to obtain the maintenance window displayed in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>06:00</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The current kernel Milvus version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx-kernel_5.4.11-16301083_xcluster-20210805</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>The network type of the instance. Only VPC is supported, which indicates a virtual private cloud.</para>
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
            /// <item><description><b>Postpaid</b>: Pay-as-you-go.</description></item>
            /// <item><description><b>Prepaid</b>: Subscription.</description></item>
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

            /// <summary>
            /// <para>The primary instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-hzrof9vitnu8uu</para>
            /// </summary>
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
            /// <para>rg-*********</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the three-role mode is enabled. Valid values:</para>
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
            /// <item><description><b>processing</b>: Processing.</description></item>
            /// <item><description><b>unknown</b>: Unknown. This may be caused by a connection failure to the instance.</description></item>
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

            /// <summary>
            /// <para>The specification category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>exclusive: Dedicated.</description></item>
            /// <item><description>general: General-purpose.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exclusive | general</para>
            /// </summary>
            [NameInMap("SpecCategory")]
            [Validation(Required=false)]
            public string SpecCategory { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom_local_ssd | cloud_auto</para>
            /// </summary>
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
            /// <para>The third zone in a Three-zone deployment.</para>
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
            /// <item><description><b>3azones</b>: Three-zone deployment.</description></item>
            /// <item><description><b>1azone</b>: Single-zone deployment.</description></item>
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
            /// <item><description><b>ReadWrite</b>: Primary instance.</description></item>
            /// <item><description><b>ReadOnly</b>: Read-only instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ReadWrite</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
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
            /// <para>The zone where the instance is deployed.</para>
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
