// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyBinarySecurityPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Cluster information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Namespaces\&quot;:[\&quot;default\&quot;],\&quot;ClusterId\&quot;:\&quot;c9f5b93a8da8f4341b77***********\&quot;},{\&quot;Namespaces\&quot;:[\&quot;default\&quot;],\&quot;ClusterId\&quot;:\&quot;cc12429dbb8f644f690b0***********\&quot;}]</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public string Clusters { get; set; }

        /// <summary>
        /// <para>Policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-policy-04-11</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Policy content. JSON format, Key values:</para>
        /// <list type="bullet">
        /// <item><description><b>policyMode</b>: Type of policy, default is requireAttestor.</description></item>
        /// <item><description><b>requiredAttestors</b>: Required attestors.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PolicyMode\&quot;:\&quot;requireAttestor\&quot;,\&quot;RequiredAttestors\&quot;:[\&quot;test-xcs-04-11-hhht\&quot;]}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>Remark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.3.4</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>Set to enable or disable the policy. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: Enable the protection policy.</description></item>
        /// <item><description><b>disabled</b>: Disable the protection policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
