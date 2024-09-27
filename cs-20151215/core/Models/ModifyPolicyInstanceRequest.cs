// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyPolicyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The action of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>deny</c>: Deployments that match the policy are denied.</description></item>
        /// <item><description><c>warn</c>: Alerts are generated for deployments that match the policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The ID of the policy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowed-repos-cbhhb</para>
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The namespaces to which the policy is applied. The policy is applied to all namespaces if this parameter is left empty.</para>
        /// </summary>
        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>The parameters of the policy instance. For more information, see <a href="https://help.aliyun.com/document_detail/359819.html">Predefined security policies of ACK</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;restrictedNamespaces&quot;: [ &quot;test&quot; ]</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
