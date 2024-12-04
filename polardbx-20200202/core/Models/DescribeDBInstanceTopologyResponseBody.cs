// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceTopologyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceTopologyResponseBodyData Data { get; set; }
        public class DescribeDBInstanceTopologyResponseBodyData : TeaModel {
            [NameInMap("LogicInstanceTopology")]
            [Validation(Required=false)]
            public DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopology LogicInstanceTopology { get; set; }
            public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopology : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>lvs</para>
                /// </summary>
                [NameInMap("DBInstanceConnType")]
                [Validation(Required=false)]
                public string DBInstanceConnType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-10-21T10:30:45Z 04:00:00</para>
                /// </summary>
                [NameInMap("DBInstanceCreateTime")]
                [Validation(Required=false)]
                public string DBInstanceCreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pxc-sprcym7g7wj7k</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>304726047</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pxc-sprcym7g7w****</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public int? DBInstanceStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TDE_MODIFYING</para>
                /// </summary>
                [NameInMap("DBInstanceStatusDescription")]
                [Validation(Required=false)]
                public string DBInstanceStatusDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>polarx</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("HistoryItems")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyHistoryItems> HistoryItems { get; set; }
                public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyHistoryItems : TeaModel {
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    [NameInMap("Azone")]
                    [Validation(Required=false)]
                    public string Azone { get; set; }

                    [NameInMap("CharacterType")]
                    [Validation(Required=false)]
                    public string CharacterType { get; set; }

                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

                    [NameInMap("DBInstanceName")]
                    [Validation(Required=false)]
                    public string DBInstanceName { get; set; }

                    [NameInMap("PhyInstanceName")]
                    [Validation(Required=false)]
                    public string PhyInstanceName { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                }

                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItems> Items { get; set; }
                public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-a</para>
                    /// </summary>
                    [NameInMap("Azone")]
                    [Validation(Required=false)]
                    public string Azone { get; set; }

                    [NameInMap("AzoneRoleList")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsAzoneRoleList> AzoneRoleList { get; set; }
                    public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsAzoneRoleList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-a</para>
                        /// </summary>
                        [NameInMap("Azone")]
                        [Validation(Required=false)]
                        public string Azone { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>leader</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                    }

                    [NameInMap("CharacterType")]
                    [Validation(Required=false)]
                    public string CharacterType { get; set; }

                    [NameInMap("ConnectionIp")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsConnectionIp> ConnectionIp { get; set; }
                    public class DescribeDBInstanceTopologyResponseBodyDataLogicInstanceTopologyItemsConnectionIp : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>pxc-xdb-m-pxcdym7g7w********.mysql.singapore.rds.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ConnectionString")]
                        [Validation(Required=false)]
                        public string ConnectionString { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("DBInstanceNetType")]
                        [Validation(Required=false)]
                        public int? DBInstanceNetType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3306</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                    }

                    [NameInMap("DBInstanceConnType")]
                    [Validation(Required=false)]
                    public int? DBInstanceConnType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2021-10-21T10:30:45Z</para>
                    /// </summary>
                    [NameInMap("DBInstanceCreateTime")]
                    [Validation(Required=false)]
                    public string DBInstanceCreateTime { get; set; }

                    [NameInMap("DBInstanceDescription")]
                    [Validation(Required=false)]
                    public string DBInstanceDescription { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>304726049</para>
                    /// </summary>
                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pxc-i-tk6t4z****</para>
                    /// </summary>
                    [NameInMap("DBInstanceName")]
                    [Validation(Required=false)]
                    public string DBInstanceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("DBInstanceStatus")]
                    [Validation(Required=false)]
                    public int? DBInstanceStatus { get; set; }

                    [NameInMap("DBInstanceStatusDescription")]
                    [Validation(Required=false)]
                    public string DBInstanceStatusDescription { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3145728</para>
                    /// </summary>
                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public long? DiskSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mysql</para>
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5.7</para>
                    /// </summary>
                    [NameInMap("EngineVersion")]
                    [Validation(Required=false)]
                    public string EngineVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LockMode")]
                    [Validation(Required=false)]
                    public int? LockMode { get; set; }

                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public string LockReason { get; set; }

                    [NameInMap("MaintainEndTime")]
                    [Validation(Required=false)]
                    public string MaintainEndTime { get; set; }

                    [NameInMap("MaintainStartTime")]
                    [Validation(Required=false)]
                    public string MaintainStartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4000</para>
                    /// </summary>
                    [NameInMap("MaxConnections")]
                    [Validation(Required=false)]
                    public int? MaxConnections { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7000</para>
                    /// </summary>
                    [NameInMap("MaxIops")]
                    [Validation(Required=false)]
                    public int? MaxIops { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>polarx.x4.large.2e</para>
                    /// </summary>
                    [NameInMap("NodeClass")]
                    [Validation(Required=false)]
                    public string NodeClass { get; set; }

                    [NameInMap("PhyInstanceName")]
                    [Validation(Required=false)]
                    public string PhyInstanceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>master</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StorageUsed")]
                    [Validation(Required=false)]
                    public string StorageUsed { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>polarx-cdc-kernel-2.0.0-3985896</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public int? LockMode { get; set; }

                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>05:00:00</para>
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>04:00:00</para>
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
