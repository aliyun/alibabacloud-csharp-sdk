// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListClusterNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token to retrieve the next page of results. If this parameter is empty, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAXW/ZB9TBvH+0ZK0phtCibQgQmu1RbqplAI6Velo2OKR</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ListClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class ListClusterNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The unique code that identifies the cloud product or service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bccluster_eflocomputing_public_cn（表示灵骏中国站包年包月）、bccluster_eflocomputing_public_intl（表示灵骏国际站包年包月）</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-02T11:27:07</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-03T00:00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the node supports mounting file storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("FileSystemMountEnabled")]
            [Validation(Required=false)]
            public bool? FileSystemMountEnabled { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72432f80-273e-11ed-b57a-acde48001122</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The ID of the HPN zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A1</para>
            /// </summary>
            [NameInMap("HpnZone")]
            [Validation(Required=false)]
            public string HpnZone { get; set; }

            /// <summary>
            /// <para>The hyper node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-2r42tmj4z02</para>
            /// </summary>
            [NameInMap("HyperNodeId")]
            [Validation(Required=false)]
            public string HyperNodeId { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i190297201669099844192</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alinux3_x86_gu8xf_P_Host_D3_C7E3_550.127_Legacy_N_241230</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The machine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b11</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>Network details.</para>
            /// </summary>
            [NameInMap("Networks")]
            [Validation(Required=false)]
            public List<ListClusterNodesResponseBodyNodesNetworks> Networks { get; set; }
            public class ListClusterNodesResponseBodyNodesNetworks : TeaModel {
                /// <summary>
                /// <para>The name of the network interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bond0</para>
                /// </summary>
                [NameInMap("BondName")]
                [Validation(Required=false)]
                public string BondName { get; set; }

                /// <summary>
                /// <para>The IP address of the node in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.22.2</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The subnet ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subnet-fwekrvg9</para>
                /// </summary>
                [NameInMap("SubnetId")]
                [Validation(Required=false)]
                public string SubnetId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the network interface belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-eoiy88ju</para>
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

            }

            /// <summary>
            /// <para>The node group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-e9b74f4d450cf18d</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>The node group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr_master</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-2r42tmj4z02</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The status of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extending</para>
            /// </summary>
            [NameInMap("OperatingState")]
            [Validation(Required=false)]
            public string OperatingState { get; set; }

            /// <summary>
            /// <para>The serial number (SN) of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sn_tOuUk</para>
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// <para>The list of tags attached to the node.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListClusterNodesResponseBodyNodesTags> Tags { get; set; }
            public class ListClusterNodesResponseBodyNodesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alarm_xdc</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-skkdsdl83ksxxs3</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-0jlohur7nhbxd1ttyq8p8</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC where the node is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-f8zcet5mwerafyqlrhyoi</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The availability zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BA76272-6608-5AEC-BBA8-B6F0D3D14CDB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
