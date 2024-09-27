// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeployPolicyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The action of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>deny</c>: Deployments that match the policy are denied.</description></item>
        /// <item><description><c>warn</c>: Alerts are generated for Deployments that match the policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The namespaces to which the policy applies. If you leave this parameter empty, the policy is applicable to all namespaces of the cluster.</para>
        /// </summary>
        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>The parameter settings of the policy. For more information about the parameters supported by each policy, see <a href="https://www.alibabacloud.com/help/doc-detail/359819.html">Predefined security policies of ACK</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;restrictedNamespaces&quot;: [ &quot;test&quot; ]}</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
