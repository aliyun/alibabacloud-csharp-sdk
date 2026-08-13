// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyTrFirewallV2RoutePolicyScopeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7D4D635-0C70-5CEB-A609-851E94D51FBB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the firewall route policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-4d724d0139df48f1****</para>
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

    }

}
