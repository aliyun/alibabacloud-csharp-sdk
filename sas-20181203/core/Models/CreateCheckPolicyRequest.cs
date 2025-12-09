// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateCheckPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the parent policy.</para>
        /// <para>(The specific dependency order from low to high is Section -&gt; Requirement -&gt; Standard)</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DependentPolicyId")]
        [Validation(Required=false)]
        public long? DependentPolicyId { get; set; }

        /// <summary>
        /// <para>The name of the custom policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestPolicyName</para>
        /// </summary>
        [NameInMap("PolicyShowName")]
        [Validation(Required=false)]
        public string PolicyShowName { get; set; }

        /// <summary>
        /// <para>The policy category type for custom check rules:</para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: Add to a standard.</description></item>
        /// <item><description><b>REQUIREMENT</b>: Add to a requirement.</description></item>
        /// <item><description><b>SECTION</b>: Add to a section.</description></item>
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
        /// <para>The name of the major policy category (required when PolicyType is STANDARD):</para>
        /// <list type="bullet">
        /// <item><description><b>AISPM</b>: AI Configuration Management (AISPM).</description></item>
        /// <item><description><b>IDENTITY_PERMISSION</b>: Identity and Permission Management (CIEM).</description></item>
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
