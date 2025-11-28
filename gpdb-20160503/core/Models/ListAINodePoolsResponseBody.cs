// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListAINodePoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the AI node resource pool.</para>
        /// </summary>
        [NameInMap("AINodePoolInfos")]
        [Validation(Required=false)]
        public List<ListAINodePoolsResponseBodyAINodePoolInfos> AINodePoolInfos { get; set; }
        public class ListAINodePoolsResponseBodyAINodePoolInfos : TeaModel {
            /// <summary>
            /// <para>AI node details.</para>
            /// </summary>
            [NameInMap("AINodeInfos")]
            [Validation(Required=false)]
            public List<ListAINodePoolsResponseBodyAINodePoolInfosAINodeInfos> AINodeInfos { get; set; }
            public class ListAINodePoolsResponseBodyAINodePoolInfosAINodeInfos : TeaModel {
                /// <summary>
                /// <para>The binding type of the AI node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model_serving</para>
                /// </summary>
                [NameInMap("BindObject")]
                [Validation(Required=false)]
                public string BindObject { get; set; }

                /// <summary>
                /// <para>The status of the AI node.</para>
                /// <list type="bullet">
                /// <item><description>unbound: The node is not bound.</description></item>
                /// <item><description>bound: The node is bound.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("BindStatus")]
                [Validation(Required=false)]
                public string BindStatus { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-09T02:07:15Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adbpg-ainode</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The name of the AI node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ai-xxxxxxxxx</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The AI node specifications. The list of supported specifications is shown below.</para>
                /// <pre><c>ADB.AIMedium.1
                /// ADB.AILarge.1
                /// ADB.AIStandard.2
                /// ADB.AIMedium.2
                /// ADB.AILarge.2
                /// ADB.AIXLarge.2
                /// ADB.AIStandard.6
                /// ADB.AIMedium.6
                /// ADB.AILarge.6
                /// ADB.AIXLarge.6
                /// ADB.AIStandard.3
                /// ADB.AIMedium.3
                /// ADB.AILarge.3
                /// ADB.AIXLarge.3
                /// ADB.AIStandard.4
                /// ADB.AIMedium.4
                /// ADB.AILarge.4
                /// ADB.AIXLarge.4
                /// ADB.AIStandard.5
                /// ADB.AIMedium.5
                /// ADB.AILarge.5
                /// ADB.AIXLarge.5
                /// ADB.AIStandard.8
                /// ADB.AIMedium.8
                /// ADB.AILarge.8
                /// ADB.AIXLarge.8
                /// ADB.AI2XLarge.8
                /// </c></pre>
                /// 
                /// <b>Example:</b>
                /// <para>ADB.AIStandard.1</para>
                /// </summary>
                [NameInMap("NodeSpec")]
                [Validation(Required=false)]
                public string NodeSpec { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-16T02:04:42Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource pool to which the AI node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aipool-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("AINodePoolId")]
            [Validation(Required=false)]
            public string AINodePoolId { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public string NodeNum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
