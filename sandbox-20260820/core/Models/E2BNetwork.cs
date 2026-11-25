// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BNetwork : TeaModel {
        /// <summary>
        /// <para>The allowlist for outbound access from the sandbox. After configuration, the sandbox can only access the destinations in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;api.example.com&quot;,&quot;10.0.0.0/8&quot;]</para>
        /// </summary>
        [NameInMap("allowOut")]
        [Validation(Required=false)]
        public List<string> AllowOut { get; set; }

        /// <summary>
        /// <para>Specifies whether Direct Internet Access to the sandbox is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("allowPublicTraffic")]
        [Validation(Required=false)]
        public bool? AllowPublicTraffic { get; set; }

        /// <summary>
        /// <para>The denylist for outbound access from the sandbox. After configuration, the sandbox cannot access the destinations in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;blocked.example.com&quot;,&quot;192.168.0.0/16&quot;]</para>
        /// </summary>
        [NameInMap("denyOut")]
        [Validation(Required=false)]
        public List<string> DenyOut { get; set; }

        /// <summary>
        /// <para>The domain name used to rewrite the request Host header when accessing the sandbox. If not configured, the original Host header remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox.example.com</para>
        /// </summary>
        [NameInMap("maskRequestHost")]
        [Validation(Required=false)]
        public string MaskRequestHost { get; set; }

        /// <summary>
        /// <para>The key is the exact destination hostname or the E2B reserved key @fc.sandbox.identity, and the value is a list of rule objects. The number of hostnames and replacement entries is subject to account quota limits. GetSandboxInner echoes the current hostname rules and configured OAuth options in the same format. User tokens are only used during writes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;api.example.com&quot;:[{&quot;transform&quot;:{&quot;headers&quot;:{&quot;X-Example&quot;:&quot;demo&quot;}}}]}</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public Dictionary<string, List<Dictionary<string, object>>> Rules { get; set; }

    }

}
