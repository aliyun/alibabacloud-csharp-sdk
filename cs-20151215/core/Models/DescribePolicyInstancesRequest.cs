// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the policy instance that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowed-repos-cz4s2</para>
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The name of the policy that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACKPSPCapabilities</para>
        /// </summary>
        [NameInMap("policy_name")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}
