// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyInstancesSSLRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public int? SSLEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****QqEP-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----MIIE****ihfg==-----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

    }

}
