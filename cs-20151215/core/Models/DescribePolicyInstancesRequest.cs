// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyInstancesRequest : Darabonba.Model {
        /// <summary>
        /// <para>The name of the policy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowed-repos-cz4s2</para>
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The name of the policy governance rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACKPSPCapabilities</para>
        /// </summary>
        [NameInMap("policy_name")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}

