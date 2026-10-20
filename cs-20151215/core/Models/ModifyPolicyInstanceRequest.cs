// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyPolicyInstanceRequest : Darabonba.Model {
        /// <summary>
        /// <para>The governance action of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>deny</c>: blocks non-compliant deployments.</description></item>
        /// <item><description><c>warn</c>: generates alerts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The instance ID of the policy rule instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowed-repos-cbhhb</para>
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The namespaces to which the policy applies. An empty value indicates all namespaces.</para>
        /// </summary>
        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>The configuration parameters of the current rule instance. For more information about parameter settings rules, see <a href="https://help.aliyun.com/document_detail/359819.html">Container Security Policy Rule Library</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;restrictedNamespaces&quot;: [ &quot;test&quot; ]</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}

