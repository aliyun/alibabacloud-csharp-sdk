// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListFreeNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned pagination token which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3f2224a5ec7224116c4f5246120abe4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ListFreeNodesResponseBodyNodes> Nodes { get; set; }
        public class ListFreeNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bccluster_eflocomputing_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652321554</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the node expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673107200</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The cluster number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A1</para>
            /// </summary>
            [NameInMap("HpnZone")]
            [Validation(Required=false)]
            public string HpnZone { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>efg1.nvga1</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-7pp2x193801</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The node status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unused</para>
            /// </summary>
            [NameInMap("OperatingState")]
            [Validation(Required=false)]
            public string OperatingState { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzkkbrpl4owgy</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The serial number of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sn_pozkHBgicd</para>
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListFreeNodesResponseBodyNodesTags> Tags { get; set; }
            public class ListFreeNodesResponseBodyNodesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aa_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aa_vakye</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA14CB86-70C4-5CB7-9E7B-6CCA77F3512B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
