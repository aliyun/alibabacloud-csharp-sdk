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
        /// <item><description>false: Does not force delete the node pool. If the node pool contains existing nodes, the node pool cannot be deleted and an error is returned.</description></item>
        /// </list>
        /// <para>Deleting a node pool does not automatically release subscription nodes. Automatic release subscription nodes, <a href="https://www.alibabacloud.com/help/en/ecs/change-the-billing-method-of-an-instance-from-subscription-to-pay-as-you-go-1">change the billing method of the nodes from subscription to pay-as-you-go</a> and then log on to the ECS console automatic release the nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
