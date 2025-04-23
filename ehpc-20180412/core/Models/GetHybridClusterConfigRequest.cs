// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetHybridClusterConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the on-premises compute node. You can call this operation to query the configurations of the on-premises compute node.</para>
        /// <para>By default, the operation queries the configurations of a cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNode</para>
        /// </summary>
        [NameInMap("Node")]
        [Validation(Required=false)]
        public string Node { get; set; }

    }

}
