// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The types of policies to be queried (default queries both custom and system predefined policies).</para>
        /// </summary>
        [NameInMap("CheckTypes")]
        [Validation(Required=false)]
        public List<string> CheckTypes { get; set; }

        /// <summary>
        /// <para>Specifies the page number from which to start displaying the query results. The starting value is <b>1</b>. The default value is <b>1</b>, indicating that the display starts from the <b>1st</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>ID of the associated parent policy.</para>
        /// <para>(The specific dependency relationship from low to high is: Section -&gt; Requirement -&gt; Standard)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000002</para>
        /// </summary>
        [NameInMap("DependentPolicyId")]
        [Validation(Required=false)]
        public long? DependentPolicyId { get; set; }

        /// <summary>
        /// <para>Language type for request and response messages, with a default value of <b>zh</b>. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Number of check item information entries displayed per page during pagination. The default value is <b>50</b>, indicating 50 entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>ID of the newly added classification setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000001</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>Name of the newly added classification setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPolicyName</para>
        /// </summary>
        [NameInMap("PolicyShowName")]
        [Validation(Required=false)]
        public string PolicyShowName { get; set; }

        /// <summary>
        /// <para>Policy type of the custom check item rule:</para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: New standard</description></item>
        /// <item><description><b>REQUIREMENT</b>: New requirement</description></item>
        /// <item><description><b>SECTION</b>: New section</description></item>
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
        /// <item><description><b>AISPM</b>: AI Configuration Management (AI-SPM)</description></item>
        /// <item><description><b>IDENTITY_PERMISSION</b>: Identity and Permission Management (CIEM)</description></item>
        /// <item><description><b>RISK</b>: Security Risk</description></item>
        /// <item><description><b>COMPLIANCE</b>: Compliance Risk</description></item>
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
