// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeployPolicyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The governance action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>deny</c>: Denies deployments that violate the rule.</para>
        /// </description></item>
        /// <item><description><para><c>warn</c>: Generates an alert for deployments that violate the rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The namespaces where the policy applies. If you omit this parameter, the policy applies to all namespaces.</para>
        /// </summary>
        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>For details on the parameters supported by each policy governance rule, see <a href="https://www.alibabacloud.com/help/doc-detail/359819.html">Container security policy rules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;repos&quot;: [     &quot;registry-vpc.cn-hangzhou.aliyuncs.com/acs/&quot;,     &quot;registry.cn-hangzhou.aliyuncs.com/acs/&quot;   ] }</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
