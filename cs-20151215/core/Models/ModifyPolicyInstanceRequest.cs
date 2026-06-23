// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyPolicyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The governance action of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>deny</c>: Blocks non-compliant deployments.</description></item>
        /// <item><description><c>warn</c>: Generates an alert.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The instance ID of the policy rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowed-repos-cbhhb</para>
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The namespaces to which the policy applies. If this parameter is empty, the policy applies to all namespaces.</para>
        /// </summary>
        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>The configuration parameters of the current rule instance. For more information about parameter settings rules, see <a href="https://help.aliyun.com/document_detail/359819.html">Container security policy rules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;restrictedNamespaces&quot;: [ &quot;test&quot; ]</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
