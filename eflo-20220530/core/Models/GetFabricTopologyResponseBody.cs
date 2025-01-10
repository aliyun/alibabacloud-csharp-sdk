// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetFabricTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetFabricTopologyResponseBodyContent Content { get; set; }
        public class GetFabricTopologyResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>network interface controller Topology Information</para>
            /// </summary>
            [NameInMap("TopoInfo")]
            [Validation(Required=false)]
            public List<GetFabricTopologyResponseBodyContentTopoInfo> TopoInfo { get; set; }
            public class GetFabricTopologyResponseBodyContentTopoInfo : TeaModel {
                /// <summary>
                /// <para>The resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>core-1</para>
                /// </summary>
                [NameInMap("LayerName")]
                [Validation(Required=false)]
                public string LayerName { get; set; }

                /// <summary>
                /// <para>Hierarchical resource types</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>core: core layer.</description></item>
                /// <item><description>node: Lingjun node.</description></item>
                /// <item><description>lni: lingjun network interface controller.</description></item>
                /// <item><description>spine: backbone layer.</description></item>
                /// <item><description>leaf: access layer</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>core</para>
                /// </summary>
                [NameInMap("LayerType")]
                [Validation(Required=false)]
                public string LayerType { get; set; }

                /// <summary>
                /// <para>Next Level</para>
                /// </summary>
                [NameInMap("NextLayer")]
                [Validation(Required=false)]
                public List<object> NextLayer { get; set; }

            }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-j6ctp4n75306****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>Lingjun CIDR block ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-fuli****</para>
            /// </summary>
            [NameInMap("VpdId")]
            [Validation(Required=false)]
            public string VpdId { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC8C713A-A9F4-5984-A5E1-76496DF35153</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
