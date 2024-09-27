// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeletePolicyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the policy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowed-repos-mqdsf</para>
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

    }

}
