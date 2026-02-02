// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyInstancesSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The RDS Supabase instances whose SSL settings are modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     &quot;ra-supabase-xxx&quot;,
        ///     &quot;ra-supabase-xxx&quot;
        ///   ]</para>
        /// </summary>
        [NameInMap("InstanceNames")]
        [Validation(Required=false)]
        public List<string> InstanceNames { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32DEFB4A-xxxx-ADD5-918E4FD7AB8C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
