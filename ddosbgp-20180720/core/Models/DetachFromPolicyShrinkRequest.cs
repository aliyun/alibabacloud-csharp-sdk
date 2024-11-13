// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DetachFromPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The protected objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IpPortProtocolList")]
        [Validation(Required=false)]
        public string IpPortProtocolListShrink { get; set; }

        /// <summary>
        /// <para>The type of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: the default mitigation policies.</description></item>
        /// <item><description><b>l3</b>: IP-specific mitigation policies.</description></item>
        /// <item><description><b>l4</b>: port-specific mitigation policies.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l3</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

    }

}
