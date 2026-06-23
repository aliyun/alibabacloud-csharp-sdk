// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodepoolRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to force delete the node pool.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Force deletes the node pool. If the node pool contains existing instances, the existing nodes are forcibly deleted.</para>
        /// </description></item>
        /// <item><description><para>false: Does not force delete the node pool. If the node pool contains existing instances, the node pool cannot be deleted, and an error is returned.</para>
        /// </description></item>
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
