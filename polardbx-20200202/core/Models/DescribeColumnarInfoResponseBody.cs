// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeColumnarInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeColumnarInfoResponseBodyData Data { get; set; }
        public class DescribeColumnarInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("BinlogPersistTime")]
            [Validation(Required=false)]
            public int? BinlogPersistTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>524288000</para>
            /// </summary>
            [NameInMap("BinlogSize")]
            [Validation(Required=false)]
            public int? BinlogSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("CheckSumSwitch")]
            [Validation(Required=false)]
            public string CheckSumSwitch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polarx.n8.medium.col</para>
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx-col-kernel-5.4.20-20250819_17555906</para>
            /// </summary>
            [NameInMap("ColumnarNewVersion")]
            [Validation(Required=false)]
            public string ColumnarNewVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polarx-col-kernel-5.4.20-20250819_17555906</para>
            /// </summary>
            [NameInMap("ColumnarVersion")]
            [Validation(Required=false)]
            public string ColumnarVersion { get; set; }

            [NameInMap("InstanceTopologyList")]
            [Validation(Required=false)]
            public List<DescribeColumnarInfoResponseBodyDataInstanceTopologyList> InstanceTopologyList { get; set; }
            public class DescribeColumnarInfoResponseBodyDataInstanceTopologyList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pxc-***</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("PhysicalNodes")]
                [Validation(Required=false)]
                public List<DescribeColumnarInfoResponseBodyDataInstanceTopologyListPhysicalNodes> PhysicalNodes { get; set; }
                public class DescribeColumnarInfoResponseBodyDataInstanceTopologyListPhysicalNodes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-h</para>
                    /// </summary>
                    [NameInMap("AZone")]
                    [Validation(Required=false)]
                    public string AZone { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>204800</para>
                    /// </summary>
                    [NameInMap("Disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>polarx.n8.medium.col</para>
                    /// </summary>
                    [NameInMap("NodeClass")]
                    [Validation(Required=false)]
                    public string NodeClass { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ACTIVATION</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>polarx-col-kernel-5.4.20-20250819_17555906</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>server id</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53755321</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public int? ServerId { get; set; }

        }

        /// <summary>
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
        /// <para>14036EBE-****-44DB-ACE9-AC6157D3A6FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
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
