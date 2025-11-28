// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class AddAINodeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource pool to which the AI node belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aipool-xxxxx</para>
        /// </summary>
        [NameInMap("AINodePoolId")]
        [Validation(Required=false)]
        public string AINodePoolId { get; set; }

        /// <summary>
        /// <para>The AI node specifications.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AINodeSpecInfos")]
        [Validation(Required=false)]
        public List<AddAINodeRequestAINodeSpecInfos> AINodeSpecInfos { get; set; }
        public class AddAINodeRequestAINodeSpecInfos : TeaModel {
            /// <summary>
            /// <para>The number of AI nodes.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public string NodeNum { get; set; }

            /// <summary>
            /// <para>The AI node specifications.</para>
            /// <pre><c>ADB.AIStandard.1
            /// ADB.AIMedium.1
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADB.AIStandard.1</para>
            /// </summary>
            [NameInMap("NodeSpec")]
            [Validation(Required=false)]
            public string NodeSpec { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

    }

}
