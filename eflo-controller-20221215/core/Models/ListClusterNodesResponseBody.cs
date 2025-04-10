// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListClusterNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The query token value returned by this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAXW/ZB9TBvH+0ZK0phtCibQgQmu1RbqplAI6Velo2OKR</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>List of nodes</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ListClusterNodesResponseBodyNodes> Nodes { get; set; }
        public class ListClusterNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>product code</para>
            /// 
            /// <b>Example:</b>
            /// <para>bcccluster</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642472468000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Machine expiration time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1762185600000</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>Hostname</para>
            /// 
            /// <b>Example:</b>
            /// <para>72432f80-273e-11ed-b57a-acde48001122</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>Hpn Zone</para>
            /// 
            /// <b>Example:</b>
            /// <para>A1</para>
            /// </summary>
            [NameInMap("HpnZone")]
            [Validation(Required=false)]
            public string HpnZone { get; set; }

            /// <summary>
            /// <para>System image ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>i190297201669099844192</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>image name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alinux3_x86_AMD_R_Host_D3_E3_24.13.00_UEFI_N_250121</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>Machine type</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b11</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>Network information</para>
            /// </summary>
            [NameInMap("Networks")]
            [Validation(Required=false)]
            public List<ListClusterNodesResponseBodyNodesNetworks> Networks { get; set; }
            public class ListClusterNodesResponseBodyNodesNetworks : TeaModel {
                /// <summary>
                /// <para>Machine network interface name</para>
                /// 
                /// <b>Example:</b>
                /// <para>bond0</para>
                /// </summary>
                [NameInMap("BondName")]
                [Validation(Required=false)]
                public string BondName { get; set; }

                /// <summary>
                /// <para>IP address within the VPC</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.22.2</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>VPC subnet ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>subnet-fwekrvg9</para>
                /// </summary>
                [NameInMap("SubnetId")]
                [Validation(Required=false)]
                public string SubnetId { get; set; }

                /// <summary>
                /// <para>VPC ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-eoiy88ju</para>
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

            }

            /// <summary>
            /// <para>Node group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-e9b74f4d450cf18d</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>Node group name</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr_master</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>Node ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-2r42tmj4z02</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>Node status</para>
            /// 
            /// <b>Example:</b>
            /// <para>Extending</para>
            /// </summary>
            [NameInMap("OperatingState")]
            [Validation(Required=false)]
            public string OperatingState { get; set; }

            /// <summary>
            /// <para>Machine SN</para>
            /// 
            /// <b>Example:</b>
            /// <para>sn_tOuUk</para>
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// <para>tag information</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListClusterNodesResponseBodyNodesTags> Tags { get; set; }
            public class ListClusterNodesResponseBodyNodesTags : TeaModel {
                /// <summary>
                /// <para>The key of tag object</para>
                /// 
                /// <b>Example:</b>
                /// <para>aa_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag object</para>
                /// 
                /// <b>Example:</b>
                /// <para>aa_value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>task id</para>
            /// 
            /// <b>Example:</b>
            /// <para>i28ddkdkkdkdd</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1mxqhw8o20tgv3xk47h</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-0jltf9vinjz3if3lltdy7</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>Zone ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BA76272-6608-5AEC-BBA8-B6F0D3D14CDB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
