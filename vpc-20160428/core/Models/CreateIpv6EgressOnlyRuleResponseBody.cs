// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIpv6EgressOnlyRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the egress-only rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6py-hp3w98rmlbqp01245****</para>
        /// </summary>
        [NameInMap("Ipv6EgressRuleId")]
        [Validation(Required=false)]
        public string Ipv6EgressRuleId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DFEDBEE-E5AB-49E8-A2DC-CC114C67AF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
