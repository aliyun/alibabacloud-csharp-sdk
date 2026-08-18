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
                /// <para>The instance creation time, in the format of yyyy-MM-dd HH:mm:ss.</para>
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
                /// <para>The engine version. Default value: 2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The historical node list.</para>
                /// </summary>
                [NameInMap("HistoryItems")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyHistoryItems> HistoryItems { get; set; }
                public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyHistoryItems : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the node is activated. For the compute layer, only the primary zone node is activated. After a primary/secondary switchover is performed on the instance, the standby compute node becomes the primary node. All storage layer nodes are activated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    /// <summary>
                    /// <para>The zone of the node. If the node is an RDS node, the zones of multiple child nodes are separated by semicolons (;).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-a</para>
                    /// </summary>
                    [NameInMap("Azone")]
                    [Validation(Required=false)]
                    public string Azone { get; set; }

                    /// <summary>
                    /// <para>The node property. Valid values:</para>
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
                    /// <para>The physical instance name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-unrbk8oyz**********</para>
                    /// </summary>
                    [NameInMap("PhyInstanceName")]
                    [Validation(Required=false)]
                    public string PhyInstanceName { get; set; }

                    /// <summary>
                    /// <para>The region of the node. If the node is an RDS node, the regions of multiple child nodes are separated by semicolons (;).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The node role. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>master</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                }

                /// <summary>
                /// <para>The node list.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItems> Items { get; set; }
                public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItems : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the node is activated. For the compute layer, only the primary zone node is activated. After a primary/secondary switchover is performed on the instance, the standby compute node becomes the primary node. All storage layer nodes are activated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    /// <summary>
                    /// <para>The zone of the node. If the node is an RDS node, the zones of multiple child nodes are separated by semicolons (;).</para>
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
                        /// 
                        /// <b>Example:</b>
                        /// <para>leader</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                    }

                    /// <summary>
                    /// <para>The node property. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Node role</para>
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
                    /// <para>Not displayed</para>
                    /// </summary>
                    [NameInMap("DBInstanceConnType")]
                    [Validation(Required=false)]
                    public int? DBInstanceConnType { get; set; }

                    /// <summary>
                    /// <para>The instance creation time.</para>
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
                    /// <para>The engine version. Valid values:</para>
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

                    /// <summary>
                    /// <para>The instance CN cluster name, such as default.</para>
                    /// </summary>
                    [NameInMap("InstanceClusterName")]
                    [Validation(Required=false)]
                    public string InstanceClusterName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the node is locked. Valid values:</para>
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
                    /// <para>The O&amp;M window end time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not displayed</para>
                    /// </summary>
                    [NameInMap("MaintainEndTime")]
                    [Validation(Required=false)]
                    public string MaintainEndTime { get; set; }

                    /// <summary>
                    /// <para>The O&amp;M window start time.</para>
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
                    /// <para>The node specifications:</para>
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

                    /// <summary>
                    /// <para>The read/write type, such as ReadWrite.</para>
                    /// </summary>
                    [NameInMap("ReadType")]
                    [Validation(Required=false)]
                    public string ReadType { get; set; }

                    /// <summary>
                    /// <para>The region of the node. If the node is an RDS node, the regions of multiple child nodes are separated by semicolons (;).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The node role. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>master</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para>The node status:</para>
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
                    /// <para>The log node version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>polarx-cdc-kernel-2.0.0-3985896</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The lock status:</para>
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
                /// <para>Overdue</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The O&amp;M window end time, in the format of HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>05:00:00</para>
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// <para>The O&amp;M window start time, in the format of HH:mm:ss.</para>
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
