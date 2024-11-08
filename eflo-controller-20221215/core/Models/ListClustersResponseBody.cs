// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListClustersResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyClusters> Clusters { get; set; }
        public class ListClustersResponseBodyClusters : TeaModel {
            [NameInMap("ClusterDescription")]
            [Validation(Required=false)]
            public string ClusterDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i137590131672134915401</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cnp_test_cluster</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AckEdgPro</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public object Components { get; set; }

            [NameInMap("ComputingIpVersion")]
            [Validation(Required=false)]
            public string ComputingIpVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1672134938</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("HpnZone")]
            [Validation(Required=false)]
            public string HpnZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public long? NodeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeGroupCount")]
            [Validation(Required=false)]
            public long? NodeGroupCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>initializing</para>
            /// </summary>
            [NameInMap("OperatingState")]
            [Validation(Required=false)]
            public string OperatingState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-aek2ajbjoloa23q</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i156365121663149566024</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1672134968</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f4f9a292c17072a2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FE2B22C-CF9D-59DE-BF63-DC9B9B33A9D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
