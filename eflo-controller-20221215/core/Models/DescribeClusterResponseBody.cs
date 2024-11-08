// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeClusterResponseBody : TeaModel {
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i116913051662373010974</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Eflo-YJ-Test-Cluster</para>
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

        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<DescribeClusterResponseBodyComponents> Components { get; set; }
        public class DescribeClusterResponseBodyComponents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i149549021660892626529</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACKEdge</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

        }

        [NameInMap("ComputingIpVersion")]
        [Validation(Required=false)]
        public string ComputingIpVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-06-08T07:05:11Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        [NameInMap("Networks")]
        [Validation(Required=false)]
        public List<DescribeClusterResponseBodyNetworks> Networks { get; set; }
        public class DescribeClusterResponseBodyNetworks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vpd-iqd7xunc</para>
            /// </summary>
            [NameInMap("VpdId")]
            [Validation(Required=false)]
            public string VpdId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
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

        [NameInMap("OpenEniJumboFrame")]
        [Validation(Required=false)]
        public string OpenEniJumboFrame { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("OperatingState")]
        [Validation(Required=false)]
        public string OperatingState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>887FA855-89F4-5DB3-B305-C5879EC480E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aek2k3rqlvv6ytq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i152609221670466904596</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-08-23T06:36:17.000Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
