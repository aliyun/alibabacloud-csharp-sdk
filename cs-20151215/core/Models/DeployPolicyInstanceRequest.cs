// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeployPolicyInstanceRequest : TeaModel {
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
        /// <para>The namespaces to which the policy is restricted. An empty value indicates all namespaces.</para>
        /// </summary>
        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>The parameter settings of the current rule instance. For the parameters supported by each policy governance rule and the corresponding metric description, see <a href="https://www.alibabacloud.com/help/doc-detail/359819.html">Security policy rule library</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;repos&quot;: [     &quot;registry-vpc.cn-hangzhou.aliyuncs.com/acs/&quot;,     &quot;registry.cn-hangzhou.aliyuncs.com/acs/&quot;   ] }</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
