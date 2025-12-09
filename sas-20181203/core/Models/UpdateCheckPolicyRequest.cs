// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateCheckPolicyRequest : TeaModel {
        /// <summary>
        /// <para>ID of the associated parent policy.</para>
        /// <para>(The specific dependency hierarchy, from low to high, is Section -&gt; Requirement -&gt; Standard).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000002</para>
        /// </summary>
        [NameInMap("DependentPolicyId")]
        [Validation(Required=false)]
        public long? DependentPolicyId { get; set; }

        /// <summary>
        /// <para>ID of the custom policy.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="~~ListCheckPolicies~~">ListCheckPolicies</a> API.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>Name of the custom classification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPolicyName</para>
        /// </summary>
        [NameInMap("PolicyShowName")]
        [Validation(Required=false)]
        public string PolicyShowName { get; set; }

        /// <summary>
        /// <para>Classification type of the custom check item rule:</para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: Add to standard.</description></item>
        /// <item><description><b>REQUIREMENT</b>: Add to requirement.</description></item>
        /// <item><description><b>SECTION</b>: Add to section.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>Name of the associated major policy category (required when PolicyType is STANDARD):</para>
        /// <list type="bullet">
        /// <item><description><b>AISPM</b>: AI Configuration Management (AISPM).</description></item>
        /// <item><description><b>RISK</b>: Security Risk.</description></item>
        /// <item><description><b>COMPLIANCE</b>: Compliance Risk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AISPM</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
