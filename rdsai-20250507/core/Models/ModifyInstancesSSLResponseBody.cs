// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyInstancesSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs of the AI applications that were successfully modified.</para>
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

        /// <summary>
        /// <para>The expiration time of the custom SSL certificate. The time is in the yyyy-MM-dd HH:mm:ss format and in the UTC+8 time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-12-31 23:59:59</para>
        /// </summary>
        [NameInMap("SSLExpiredTime")]
        [Validation(Required=false)]
        public string SSLExpiredTime { get; set; }

    }

}
