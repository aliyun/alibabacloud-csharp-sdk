// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRuleEvaluationResultsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the compliance package.</para>
        /// <para>For more information about how to obtain the ID of a compliance package, see <a href="https://help.aliyun.com/document_detail/263332.html">ListCompliancePacks</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-f1e3326622af00cb****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// <para>The compliance evaluation result of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>COMPLIANT: The resource is evaluated as compliant.</description></item>
        /// <item><description>NON_COMPLIANT: The resource is evaluated as non-compliant.</description></item>
        /// <item><description>NOT_APPLICABLE: The rule does not apply to the resources.</description></item>
        /// <item><description>INSUFFICIENT_DATA: No data is available.</description></item>
        /// <item><description>IGNORED: The resource is ignored during compliance evaluation.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a> operation to obtain the rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-cac56457e0d900d3****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in a request. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IWBjqMYSy0is7zSMGu16****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resources that you want to evaluate reside. Separate multiple region IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the resources that you want to evaluate belong. Separate multiple resource group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2indxn3g****</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The type of the resources that you want to evaluate. Separate multiple resource types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instane</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

    }

}
