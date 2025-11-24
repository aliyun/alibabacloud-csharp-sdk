// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeNodesInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance types of the nodes.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<DescribeNodesInstanceTypeResponseBodyInstanceTypes> InstanceTypes { get; set; }
        public class DescribeNodesInstanceTypeResponseBodyInstanceTypes : TeaModel {
            /// <summary>
            /// <para>The label keys of nodes which have MultiBuffer optimization supported. (Enable optimization only if pod being scheduled to node which have a label key specified by this field and its value equals with the value field)</para>
            /// 
            /// <b>Example:</b>
            /// <para>feature.node.kubernetes.io/mb-feature-enable</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance type supports Multi-Buffer acceleration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c></description></item>
            /// <item><description><c>false</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MultiBufferEnabled")]
            [Validation(Required=false)]
            public bool? MultiBufferEnabled { get; set; }

            /// <summary>
            /// <para>The instance type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g7.xlarge</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The label keys of nodes which have MultiBuffer optimization supported. (Enable optimization only if pod being scheduled to node which have a label key specified by the key field and its value equals with this field)</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
