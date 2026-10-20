// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodepoolRequest : Darabonba.Model {
        /// <summary>
        /// <para>Specifies whether to force delete the node pool.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Force deletes the node pool. If the node pool contains existing instances, the existing nodes are forcefully deleted.</para>
        /// </description></item>
        /// <item><description><para>false: Does not force delete the node pool. If the node pool contains existing instances, the node pool cannot be deleted, and the API call returns an error.</para>
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

