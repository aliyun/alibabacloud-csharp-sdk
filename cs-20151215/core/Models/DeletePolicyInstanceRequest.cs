// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeletePolicyInstanceRequest : Darabonba.Model {
        /// <summary>
        /// <para>The instance ID of the policy rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowed-repos-mqdsf</para>
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

    }

}

