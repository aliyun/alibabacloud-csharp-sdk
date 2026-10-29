// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodepoolRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to force delete the node pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Force deletes the node pool. If the node pool contains existing nodes, the nodes are forcibly deleted.</description></item>
        /// <item><description>false: Does not force delete the node pool. If the node pool contains existing nodes, the deletion is blocked and an error is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
