// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class AddAINodeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>aipool-xxxxx</para>
        /// </summary>
        [NameInMap("AINodePoolId")]
        [Validation(Required=false)]
        public string AINodePoolId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AINodeSpecInfos")]
        [Validation(Required=false)]
        public List<AddAINodeRequestAINodeSpecInfos> AINodeSpecInfos { get; set; }
        public class AddAINodeRequestAINodeSpecInfos : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public string NodeNum { get; set; }

            /// <summary>
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
