// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListClusterNodesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAXW/ZB9TBvH+0ZK0phtCibQgQmu1RbqplAI6Velo2OKR</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ListClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class ListClusterNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1642472468000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1762185600000</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>72432f80-273e-11ed-b57a-acde48001122</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("HpnZone")]
            [Validation(Required=false)]
            public string HpnZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i190297201669099844192</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b11</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            [NameInMap("Networks")]
            [Validation(Required=false)]
            public List<ListClusterNodesResponseBodyNodesNetworks> Networks { get; set; }
            public class ListClusterNodesResponseBodyNodesNetworks : TeaModel {
                [NameInMap("BondName")]
                [Validation(Required=false)]
                public string BondName { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("SubnetId")]
                [Validation(Required=false)]
                public string SubnetId { get; set; }

                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ng-e9b74f4d450cf18d</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>emr_master</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e01-cn-2r42tmj4z02</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Extending</para>
            /// </summary>
            [NameInMap("OperatingState")]
            [Validation(Required=false)]
            public string OperatingState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sn_tOuUk</para>
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2BA76272-6608-5AEC-BBA8-B6F0D3D14CDB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
