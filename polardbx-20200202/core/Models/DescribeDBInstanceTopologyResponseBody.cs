// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The data struct.</para>
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
                /// <para>The time when the instance was created. Format: yyyy-MM-dd HH:mm:ss.</para>
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
                /// <para>The description of the instance status.</para>
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
                /// <para>The engine type. Default value: polarx.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polarx</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The engine version. Default value: 2.0.</para>
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
                    /// <para>Indicates whether the node is activated. For the compute layer, only the node in the primary zone is activated. After a primary/secondary switchover is performed on the instance, the standby compute node becomes the primary node. All storage layer nodes are activated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    /// <summary>
                    /// <para>The zone of the node. If the node is an RDS node, the zones of multiple child nodes are separated with a delimiter (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-a</para>
                    /// </summary>
                    [NameInMap("Azone")]
                    [Validation(Required=false)]
                    public string Azone { get; set; }

                    /// <summary>
                    /// <para>The node type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>polarx_cn</b>: compute node.</description></item>
                    /// <item><description><b>polarx_store</b>: data node.</description></item>
                    /// <item><description><b>polarx_gms</b>: GMS node.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>节点角色</para>
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
                    /// <para>The physical instance name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-unrbk8oyz**********</para>
                    /// </summary>
                    [NameInMap("PhyInstanceName")]
                    [Validation(Required=false)]
                    public string PhyInstanceName { get; set; }

                    /// <summary>
                    /// <para>The region of the node. If the node is an RDS node, the regions of multiple child nodes are separated with a delimiter (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The role of the node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>master</b>: primary node</description></item>
                    /// <item><description><b>standby</b>: secondary node.</description></item>
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
                    /// <para>Indicates whether the node is activated. For the compute layer, only the node in the primary zone is activated. After a primary/secondary switchover is performed on the instance, the standby compute node becomes the primary node. All storage layer nodes are activated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    /// <summary>
                    /// <para>The zone of the node. If the node is an RDS node, the zones of multiple child nodes are separated with a delimiter (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-a</para>
                    /// </summary>
                    [NameInMap("Azone")]
                    [Validation(Required=false)]
                    public string Azone { get; set; }

                    /// <summary>
                    /// <para>The data information list of the RDS three-node cluster.</para>
                    /// </summary>
                    [NameInMap("AzoneRoleList")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsAzoneRoleList> AzoneRoleList { get; set; }
                    public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsAzoneRoleList : TeaModel {
                        /// <summary>
                        /// <para>The zone of a node in the RDS three-node cluster.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-a</para>
                        /// </summary>
                        [NameInMap("Azone")]
                        [Validation(Required=false)]
                        public string Azone { get; set; }

                        /// <summary>
                        /// <para>The role of a node in the RDS three-node cluster. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>leader</b>: primary node</description></item>
                        /// <item><description><b>follower</b>: secondary node</description></item>
                        /// <item><description><b>logger</b>: logger node.</description></item>
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
                    /// <para>The node type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>polarx_cn</b>: compute node.</description></item>
                    /// <item><description><b>polarx_store</b>: data node.</description></item>
                    /// <item><description><b>polarx_gms</b>: GMS node.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>节点角色</para>
                    /// </summary>
                    [NameInMap("CharacterType")]
                    [Validation(Required=false)]
                    public string CharacterType { get; set; }

                    /// <summary>
                    /// <para>The data struct.</para>
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
                    /// <para>不展示</para>
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
                    /// <para>不展示</para>
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
                    /// <para>The description of the instance status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>不展示</para>
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
                    /// <para>The engine type. Valid values:</para>
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
                    /// <para>The engine version. Default value: 2.0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.7</para>
                    /// </summary>
                    [NameInMap("EngineVersion")]
                    [Validation(Required=false)]
                    public string EngineVersion { get; set; }

                    [NameInMap("InstanceClusterName")]
                    [Validation(Required=false)]
                    public string InstanceClusterName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the node is locked. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: Not locked.</description></item>
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
                    /// <para>The reason why the instance is locked.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>不展示</para>
                    /// </summary>
                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public string LockReason { get; set; }

                    /// <summary>
                    /// <para>The end time of the O&amp;M window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>不展示</para>
                    /// </summary>
                    [NameInMap("MaintainEndTime")]
                    [Validation(Required=false)]
                    public string MaintainEndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the O&amp;M window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>不展示</para>
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
                    /// <para>polarx.x4.large.2e</para>
                    /// </summary>
                    [NameInMap("NodeClass")]
                    [Validation(Required=false)]
                    public string NodeClass { get; set; }

                    /// <summary>
                    /// <para>The physical instance name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-unrbk8oyz**********</para>
                    /// </summary>
                    [NameInMap("PhyInstanceName")]
                    [Validation(Required=false)]
                    public string PhyInstanceName { get; set; }

                    [NameInMap("ReadType")]
                    [Validation(Required=false)]
                    public string ReadType { get; set; }

                    /// <summary>
                    /// <para>The region of the node. If the node is an RDS node, the regions of multiple child nodes are separated with a delimiter (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The role of the node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>master</b>: primary node</description></item>
                    /// <item><description><b>standby</b>: secondary node.</description></item>
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
                    /// <para>The storage usage, in MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16681</para>
                    /// </summary>
                    [NameInMap("StorageUsed")]
                    [Validation(Required=false)]
                    public string StorageUsed { get; set; }

                    /// <summary>
                    /// <para>The logger node version.</para>
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
                /// <item><description><b>0</b>: Not locked.</description></item>
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
                /// <para>The reason why the instance is locked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>欠费</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The end time of the O&amp;M window. Format: HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>05:00:00</para>
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the O&amp;M window. Format: HH:mm:ss.</para>
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
