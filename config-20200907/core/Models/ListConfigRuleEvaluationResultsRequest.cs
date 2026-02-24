// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRuleEvaluationResultsRequest : TeaModel {
        /// <summary>
        /// <para>The compliance package ID.</para>
        /// <para>For more information about how to obtain a compliance package ID, see <a href="https://help.aliyun.com/document_detail/263332.html">ListCompliancePacks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-f1e3326622af00cb****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// <para>The compliance evaluation result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>COMPLIANT: The resource is compliant.</para>
        /// </description></item>
        /// <item><description><para>NON_COMPLIANT: The resource is non-compliant.</para>
        /// </description></item>
        /// <item><description><para>NOT_APPLICABLE: The rule does not apply to the resource.</para>
        /// </description></item>
        /// <item><description><para>INSUFFICIENT_DATA: No data is available.</para>
        /// </description></item>
        /// <item><description><para>IGNORED: The evaluation result is ignored.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NON_COMPLIANT</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ComplianceType")]
        [Validation(Required=false)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>For more information about how to obtain a rule ID, see <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-cac56457e0d900d3****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>If the response is truncated, use the <c>NextToken</c> to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IWBjqMYSy0is7zSMGu16****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region where the evaluated resource resides. Separate multiple regions with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the evaluated resource belongs. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2indxn3g****</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The type of the evaluated resource. Separate multiple resource types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

    }

}
