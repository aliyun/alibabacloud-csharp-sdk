// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeCdcInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCdcInfoResponseBodyData Data { get; set; }
        public class DescribeCdcInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of days that binlogs are retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("BinlogPersistTime")]
            [Validation(Required=false)]
            public int? BinlogPersistTime { get; set; }

            /// <summary>
            /// <para>The size of the binlog.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>524288000</para>
            /// </summary>
            [NameInMap("BinlogSize")]
            [Validation(Required=false)]
            public int? BinlogSize { get; set; }

            /// <summary>
            /// <para>The latest CDC version.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx-cdc-kernel-***</para>
            /// </summary>
            [NameInMap("CdcNewVersion")]
            [Validation(Required=false)]
            public string CdcNewVersion { get; set; }

            /// <summary>
            /// <para>The checksum switch status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("CheckSumSwitch")]
            [Validation(Required=false)]
            public string CheckSumSwitch { get; set; }

            /// <summary>
            /// <para>Indicates whether bidirectional replication is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableCyclicReplication")]
            [Validation(Required=false)]
            public bool? EnableCyclicReplication { get; set; }

            /// <summary>
            /// <para>The list of instances.</para>
            /// </summary>
            [NameInMap("InstanceTopologyList")]
            [Validation(Required=false)]
            public List<DescribeCdcInfoResponseBodyDataInstanceTopologyList> InstanceTopologyList { get; set; }
            public class DescribeCdcInfoResponseBodyDataInstanceTopologyList : TeaModel {
                /// <summary>
                /// <para>The cluster type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BINLOG_X</para>
                /// </summary>
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// <para>The remarks on the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The name of the multi-stream group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The split level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RECORD</para>
                /// </summary>
                [NameInMap("HashLevel")]
                [Validation(Required=false)]
                public string HashLevel { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-***</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The array of nodes.</para>
                /// </summary>
                [NameInMap("PhysicalNodes")]
                [Validation(Required=false)]
                public List<DescribeCdcInfoResponseBodyDataInstanceTopologyListPhysicalNodes> PhysicalNodes { get; set; }
                public class DescribeCdcInfoResponseBodyDataInstanceTopologyListPhysicalNodes : TeaModel {
                    /// <summary>
                    /// <para>The zone in which the instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-h</para>
                    /// </summary>
                    [NameInMap("AZone")]
                    [Validation(Required=false)]
                    public string AZone { get; set; }

                    /// <summary>
                    /// <para>The disk size. Unit: MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>204800</para>
                    /// </summary>
                    [NameInMap("Disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// <para>The instance specifications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>polarx.x4.large.2e.cdc</para>
                    /// </summary>
                    [NameInMap("NodeClass")]
                    [Validation(Required=false)]
                    public string NodeClass { get; set; }

                    /// <summary>
                    /// <para>The node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The name of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-c-***</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>The instance status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVATION</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The instance version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>polarx-cdc-kernel-***</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The number of splits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("StreamNum")]
                [Validation(Required=false)]
                public int? StreamNum { get; set; }

            }

            /// <summary>
            /// <para>server id</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3014767486</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public int? ServerId { get; set; }

            /// <summary>
            /// <para>Indicates whether multi-stream CDC is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("VersionSupportMultiCdc")]
            [Validation(Required=false)]
            public bool? VersionSupportMultiCdc { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
