// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListAINodePoolsResponseBody : TeaModel {
        [NameInMap("AINodePoolInfos")]
        [Validation(Required=false)]
        public List<ListAINodePoolsResponseBodyAINodePoolInfos> AINodePoolInfos { get; set; }
        public class ListAINodePoolsResponseBodyAINodePoolInfos : TeaModel {
            [NameInMap("AINodeInfos")]
            [Validation(Required=false)]
            public List<ListAINodePoolsResponseBodyAINodePoolInfosAINodeInfos> AINodeInfos { get; set; }
            public class ListAINodePoolsResponseBodyAINodePoolInfosAINodeInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>model_serving</para>
                /// </summary>
                [NameInMap("BindObject")]
                [Validation(Required=false)]
                public string BindObject { get; set; }

                [NameInMap("BindStatus")]
                [Validation(Required=false)]
                public string BindStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-09T02:07:15Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>adbpg-ainode</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ai-xxxxxxxxx</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ADB.AIStandard.1</para>
                /// </summary>
                [NameInMap("NodeSpec")]
                [Validation(Required=false)]
                public string NodeSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-16T02:04:42Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aipool-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("AINodePoolId")]
            [Validation(Required=false)]
            public string AINodePoolId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public string NodeNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
