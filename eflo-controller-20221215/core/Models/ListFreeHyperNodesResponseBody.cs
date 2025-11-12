// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListFreeHyperNodesResponseBody : TeaModel {
        [NameInMap("HyperNodes")]
        [Validation(Required=false)]
        public List<ListFreeHyperNodesResponseBodyHyperNodes> HyperNodes { get; set; }
        public class ListFreeHyperNodesResponseBodyHyperNodes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>bccluster_eflocomputing_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-08-06T10:11:41.569</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-22T23:59:59Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alywlcb-lingjun-gpu-0025</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A1</para>
            /// </summary>
            [NameInMap("HpnZone")]
            [Validation(Required=false)]
            public string HpnZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e01-cn-7pp2x193801</para>
            /// </summary>
            [NameInMap("HyperNodeId")]
            [Validation(Required=false)]
            public string HyperNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>efg2.ks01L20Z2</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Using</para>
            /// </summary>
            [NameInMap("OperatingState")]
            [Validation(Required=false)]
            public string OperatingState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-acfmwaateahzoii</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para>Using</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            [Obsolete]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListFreeHyperNodesResponseBodyHyperNodesTags> Tags { get; set; }
            public class ListFreeHyperNodesResponseBodyHyperNodesTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Cpu_Usage</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>563d42ae0b17572449ec8c97f7f66069</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A511C02A-0127-51AA-A9F9-966382C9A1B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
