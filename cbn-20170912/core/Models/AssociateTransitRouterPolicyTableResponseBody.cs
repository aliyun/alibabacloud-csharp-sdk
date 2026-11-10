// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class AssociateTransitRouterPolicyTableResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the association between the policy route table and the network instance connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pta-123asfzc</para>
        /// </summary>
        [NameInMap("AssociationId")]
        [Validation(Required=false)]
        public string AssociationId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD98358-D265-4060-87CB-A2427F5A8944</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
