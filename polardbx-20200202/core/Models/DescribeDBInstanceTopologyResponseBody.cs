// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceTopologyResponseBodyData Data { get; set; }
        public class DescribeDBInstanceTopologyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The topology information.</para>
            /// </summary>
            [NameInMap("LogicInstanceTopology")]
            [Validation(Required=false)]
            public DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopology LogicInstanceTopology { get; set; }
            public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopology : TeaModel {
                /// <summary>
                /// <para>Indicates that LVS is used for load balancing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lvs</para>
                /// </summary>
                [NameInMap("DBInstanceConnType")]
                [Validation(Required=false)]
                public string DBInstanceConnType { get; set; }

                /// <summary>
                /// <para>The time when the instance was created. The format is yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-21T10:30:45Z 04:00:00</para>
                /// </summary>
                [NameInMap("DBInstanceCreateTime")]
                [Validation(Required=false)]
                public string DBInstanceCreateTime { get; set; }

                /// <summary>
                /// <para>The instance description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-sprcym7******</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>304726047</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-sprcym7g7w****</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <para>The instance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public int? DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>The instance status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TDE_MODIFYING</para>
                /// </summary>
                [NameInMap("DBInstanceStatusDescription")]
                [Validation(Required=false)]
                public string DBInstanceStatusDescription { get; set; }

                /// <summary>
                /// <para>The number of storage nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                /// <summary>
                /// <para>The engine. Default value: polarx.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polarx</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The DPI engine version. Default value: 2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The list of historical nodes.</para>
                /// </summary>
                [NameInMap("HistoryItems")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyHistoryItems> HistoryItems { get; set; }
                public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyHistoryItems : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the node is enabled. In the compute layer, only the nodes in the primary zone are enabled. After a primary/secondary switchover is performed on the instance, the secondary nodes in the compute layer are switched to primary nodes. All nodes in the storage layer are enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    /// <summary>
                    /// <para>The zone to which the node belongs. If the node is an ApsaraDB RDS node, the zones of multiple child nodes are separated by semicolons (;).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-a</para>
                    /// </summary>
                    [NameInMap("Azone")]
                    [Validation(Required=false)]
                    public string Azone { get; set; }

                    /// <summary>
                    /// <para>The node attribute. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>polarx_cn</b>: Compute node.</description></item>
                    /// <item><description><b>polarx_store</b>: Data node.</description></item>
                    /// <item><description><b>polarx_gms</b>: GMS node.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Node role</para>
                    /// </summary>
                    [NameInMap("CharacterType")]
                    [Validation(Required=false)]
                    public string CharacterType { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>304726049</para>
                    /// </summary>
                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-sprcym7g7w****</para>
                    /// </summary>
                    [NameInMap("DBInstanceName")]
                    [Validation(Required=false)]
                    public string DBInstanceName { get; set; }

                    /// <summary>
                    /// <para>The name of the physical instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-unrbk8oyz**********</para>
                    /// </summary>
                    [NameInMap("PhyInstanceName")]
                    [Validation(Required=false)]
                    public string PhyInstanceName { get; set; }

                    /// <summary>
                    /// <para>The region to which the node belongs. If the node is an ApsaraDB RDS node, the regions of multiple child nodes are separated by semicolons (;).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The node role. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>master</b>: Primary node.</description></item>
                    /// <item><description><b>standby</b>: Secondary node.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>master</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                }

                /// <summary>
                /// <para>The list of nodes.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItems> Items { get; set; }
                public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItems : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the node is enabled. In the compute layer, only the nodes in the primary zone are enabled. After a primary/secondary switchover is performed on the instance, the secondary nodes in the compute layer are switched to primary nodes. All nodes in the storage layer are enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    /// <summary>
                    /// <para>The zone to which the node belongs. If the node is an ApsaraDB RDS node, the zones of multiple child nodes are separated by semicolons (;).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-a</para>
                    /// </summary>
                    [NameInMap("Azone")]
                    [Validation(Required=false)]
                    public string Azone { get; set; }

                    /// <summary>
                    /// <para>The list of data information for the three-node ApsaraDB RDS deployment.</para>
                    /// </summary>
                    [NameInMap("AzoneRoleList")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsAzoneRoleList> AzoneRoleList { get; set; }
                    public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsAzoneRoleList : TeaModel {
                        /// <summary>
                        /// <para>The zone to which a specific node in the three-node ApsaraDB RDS deployment belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-a</para>
                        /// </summary>
                        [NameInMap("Azone")]
                        [Validation(Required=false)]
                        public string Azone { get; set; }

                        /// <summary>
                        /// <para>The role of a specific node in the three-node ApsaraDB RDS deployment. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>leader</b>: Primary node.</description></item>
                        /// <item><description><b>follower</b>: Secondary node.</description></item>
                        /// <item><description><b>logger</b>: Logger node.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>leader</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                    }

                    /// <summary>
                    /// <para>The node attribute. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>polarx_cn</b>: Compute node.</description></item>
                    /// <item><description><b>polarx_store</b>: Data node.</description></item>
                    /// <item><description><b>polarx_gms</b>: GMS node.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Node role</para>
                    /// </summary>
                    [NameInMap("CharacterType")]
                    [Validation(Required=false)]
                    public string CharacterType { get; set; }

                    /// <summary>
                    /// <para>The data structure.</para>
                    /// </summary>
                    [NameInMap("ConnectionIp")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsConnectionIp> ConnectionIp { get; set; }
                    public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsConnectionIp : TeaModel {
                        /// <summary>
                        /// <para>The connection information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pxc-xdb-m-pxcdym7g7w********.mysql.singapore.rds.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ConnectionString")]
                        [Validation(Required=false)]
                        public string ConnectionString { get; set; }

                        /// <summary>
                        /// <para>The internal connection type. The value is fixed to 1, which indicates the classic network.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("DBInstanceNetType")]
                        [Validation(Required=false)]
                        public int? DBInstanceNetType { get; set; }

                        /// <summary>
                        /// <para>The port.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3306</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                    }

                    /// <summary>
                    /// <para>The connection type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not displayed</para>
                    /// </summary>
                    [NameInMap("DBInstanceConnType")]
                    [Validation(Required=false)]
                    public int? DBInstanceConnType { get; set; }

                    /// <summary>
                    /// <para>The time when the instance was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-10-21T10:30:45Z</para>
                    /// </summary>
                    [NameInMap("DBInstanceCreateTime")]
                    [Validation(Required=false)]
                    public string DBInstanceCreateTime { get; set; }

                    /// <summary>
                    /// <para>The instance description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not displayed</para>
                    /// </summary>
                    [NameInMap("DBInstanceDescription")]
                    [Validation(Required=false)]
                    public string DBInstanceDescription { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>304726049</para>
                    /// </summary>
                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-i-tk6t4z****</para>
                    /// </summary>
                    [NameInMap("DBInstanceName")]
                    [Validation(Required=false)]
                    public string DBInstanceName { get; set; }

                    /// <summary>
                    /// <para>The instance status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("DBInstanceStatus")]
                    [Validation(Required=false)]
                    public int? DBInstanceStatus { get; set; }

                    /// <summary>
                    /// <para>The instance status description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not displayed</para>
                    /// </summary>
                    [NameInMap("DBInstanceStatusDescription")]
                    [Validation(Required=false)]
                    public string DBInstanceStatusDescription { get; set; }

                    /// <summary>
                    /// <para>The disk size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3145728</para>
                    /// </summary>
                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public long? DiskSize { get; set; }

                    /// <summary>
                    /// <para>The DPI engine version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>mysql</b></description></item>
                    /// <item><description><b>polarx_cdc</b></description></item>
                    /// <item><description><b>polarx_dn</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql</para>
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// <para>The DPI engine version. Default value: 2.0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.7</para>
                    /// </summary>
                    [NameInMap("EngineVersion")]
                    [Validation(Required=false)]
                    public string EngineVersion { get; set; }

                    /// <summary>
                    /// <para>The name of the CN cluster for the instance, such as default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("InstanceClusterName")]
                    [Validation(Required=false)]
                    public string InstanceClusterName { get; set; }

                    /// <summary>
                    /// <para>The lock status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: Unlocked.</description></item>
                    /// <item><description><b>1</b>: Locked.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LockMode")]
                    [Validation(Required=false)]
                    public int? LockMode { get; set; }

                    /// <summary>
                    /// <para>The lock reason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not displayed</para>
                    /// </summary>
                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public string LockReason { get; set; }

                    /// <summary>
                    /// <para>The end time of the O&amp;M window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not displayed</para>
                    /// </summary>
                    [NameInMap("MaintainEndTime")]
                    [Validation(Required=false)]
                    public string MaintainEndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the O&amp;M window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not displayed</para>
                    /// </summary>
                    [NameInMap("MaintainStartTime")]
                    [Validation(Required=false)]
                    public string MaintainStartTime { get; set; }

                    /// <summary>
                    /// <para>The maximum number of connections.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4000</para>
                    /// </summary>
                    [NameInMap("MaxConnections")]
                    [Validation(Required=false)]
                    public int? MaxConnections { get; set; }

                    /// <summary>
                    /// <para>The maximum IOPS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7000</para>
                    /// </summary>
                    [NameInMap("MaxIops")]
                    [Validation(Required=false)]
                    public int? MaxIops { get; set; }

                    /// <summary>
                    /// <para>The node specifications. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>polarx.x4.medium.2e</b>: 2 vCPUs and 8 GB of memory.</description></item>
                    /// <item><description><b>polarx.x4.large.2e</b>: 4 vCPUs and 16 GB of memory.</description></item>
                    /// <item><description><b>polarx.x8.large.2e</b>: 4 vCPUs and 32 GB of memory.</description></item>
                    /// <item><description><b>polarx.x4.xlarge.2e</b>: 8 vCPUs and 32 GB of memory.</description></item>
                    /// <item><description><b>polarx.x8.xlarge.2e</b>: 8 vCPUs and 64 GB of memory.</description></item>
                    /// <item><description><b>polarx.x4.2xlarge.2e</b>: 16 vCPUs and 64 GB of memory.</description></item>
                    /// <item><description><b>polarx.x8.2xlarge.2e</b>: 16 vCPUs and 128 GB of memory.</description></item>
                    /// <item><description><b>polarx.x4.4xlarge.2e</b>: 32 vCPUs and 128 GB of memory.</description></item>
                    /// <item><description><b>polarx.x8.4xlarge.2e</b>: 32 vCPUs and 256 GB of memory.</description></item>
                    /// <item><description><b>polarx.st.8xlarge.2e</b>: 60 vCPUs and 470 GB of memory.</description></item>
                    /// <item><description><b>polarx.st.12xlarge.2e</b>: 90 vCPUs and 720 GB of memory.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>polarx.x4.large.2e</para>
                    /// </summary>
                    [NameInMap("NodeClass")]
                    [Validation(Required=false)]
                    public string NodeClass { get; set; }

                    /// <summary>
                    /// <para>The name of the physical instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-unrbk8oyz**********</para>
                    /// </summary>
                    [NameInMap("PhyInstanceName")]
                    [Validation(Required=false)]
                    public string PhyInstanceName { get; set; }

                    /// <summary>
                    /// <para>The read/write type, such as ReadWrite.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ReadWrite</para>
                    /// </summary>
                    [NameInMap("ReadType")]
                    [Validation(Required=false)]
                    public string ReadType { get; set; }

                    /// <summary>
                    /// <para>The region to which the node belongs. If the node is an ApsaraDB RDS node, the regions of multiple child nodes are separated by semicolons (;).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The node role. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>master</b>: Primary node.</description></item>
                    /// <item><description><b>standby</b>: Secondary node.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>master</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para>The node status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: Running.</description></item>
                    /// <item><description><b>1</b>: Creating.</description></item>
                    /// <item><description><b>2</b>: Abnormal.</description></item>
                    /// <item><description><b>3</b>: Expired.</description></item>
                    /// <item><description><b>4</b>: Releasing.</description></item>
                    /// <item><description><b>5</b>: Released.</description></item>
                    /// <item><description><b>6</b>: Locked.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The amount of used storage space. Unit: MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16681</para>
                    /// </summary>
                    [NameInMap("StorageUsed")]
                    [Validation(Required=false)]
                    public string StorageUsed { get; set; }

                    /// <summary>
                    /// <para>The version of the logger node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>polarx-cdc-kernel-2.0.0-3985896</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The lock status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Unlocked.</description></item>
                /// <item><description><b>1</b>: Locked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public int? LockMode { get; set; }

                /// <summary>
                /// <para>The lock reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Overdue payment</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The end time of the O&amp;M window. The format is HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>05:00:00</para>
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the O&amp;M window. The format is HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>04:00:00</para>
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
