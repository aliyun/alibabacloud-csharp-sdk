// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DeleteNodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i114444141733395242745</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The node group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i121824791737080429819</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

    }

}
