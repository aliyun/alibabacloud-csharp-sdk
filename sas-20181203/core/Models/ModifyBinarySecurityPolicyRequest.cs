// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyBinarySecurityPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The cluster information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Namespaces\&quot;:[\&quot;default\&quot;],\&quot;ClusterId\&quot;:\&quot;c9f5b93a8da8f4341b77***********\&quot;},{\&quot;Namespaces\&quot;:[\&quot;default\&quot;],\&quot;ClusterId\&quot;:\&quot;cc12429dbb8f644f690b0***********\&quot;}]</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public string Clusters { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-policy-04-11</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The policy content in JSON format. Valid keys:</para>
        /// <list type="bullet">
        /// <item><description><b>policyMode</b>: The policy type. Default value: requireAttestor.</description></item>
        /// <item><description><b>requiredAttestors</b>: The required attestors.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PolicyMode\&quot;:\&quot;requireAttestor\&quot;,\&quot;RequiredAttestors\&quot;:[\&quot;test-xcs-04-11-****\&quot;]}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
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
        /// <para>115.213.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>Settings to enable or disable the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: Enables the mitigation policies.</description></item>
        /// <item><description><b>disabled</b>: Disables the mitigation policies.</description></item>
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
