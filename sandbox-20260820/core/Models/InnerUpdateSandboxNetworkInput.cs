// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class InnerUpdateSandboxNetworkInput : TeaModel {
        /// <summary>
        /// <para>The switch for outbound public network access from the sandbox. When set to false, it collapses to the default deny policy of the platform and shares the same outbound policy with allowOut and denyOut. This field is included in the full replacement. If omitted, no deny entries are appended based on this switch. However, if allowOut is not empty and denyOut is empty, denyOut is automatically set to 0.0.0.0/0, and IPv4 outbound traffic to destinations other than those in allowOut is denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allowInternetAccess")]
        [Validation(Required=false)]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// <para>The destinations allowed for outbound access, which can be IP addresses, CIDR blocks, exact domain names, or domain names with a wildcard only in the leftmost label (such as *.example.com). allowOut takes precedence over denyOut. The maximum list length depends on the account quota. If omitted, the existing allow list is cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;api.example.com&quot;,&quot;10.0.0.0/8&quot;]</para>
        /// </summary>
        [NameInMap("allowOut")]
        [Validation(Required=false)]
        public List<string> AllowOut { get; set; }

        /// <summary>
        /// <para>The destinations denied for outbound access, in the same format as allowOut. If a destination matches both allow and deny rules, the allow rule takes precedence. The maximum list length depends on the account quota. If omitted, the existing deny list is cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;blocked.example.com&quot;,&quot;192.168.0.0/16&quot;]</para>
        /// </summary>
        [NameInMap("denyOut")]
        [Validation(Required=false)]
        public List<string> DenyOut { get; set; }

        /// <summary>
        /// <para>The outbound network rules where the key is an exact destination hostname or the E2B reserved key @fc.sandbox.identity, and the value is a list of rule objects. The number of hosts and replacement entries is subject to the account quota limit. Omitting rules or passing a null object clears the standard host rules. OAuth options tables are updated individually. Omitting the corresponding reserved header retains the original table, while passing the character string &quot;{}&quot; clears the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;api.example.com&quot;:[{&quot;transform&quot;:{&quot;headers&quot;:{&quot;X-Example&quot;:&quot;demo&quot;}}}]}</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public Dictionary<string, List<Dictionary<string, object>>> Rules { get; set; }

    }

}
