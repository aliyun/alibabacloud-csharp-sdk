// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateResourceEvaluationResultsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-7f00626622af0041****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>The compliance evaluation result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>COMPLIANT: The resource is compliant.</para>
        /// </description></item>
        /// <item><description><para>NON_COMPLIANT: The resource is non-compliant.</para>
        /// </description></item>
        /// <item><description><para>NOT_APPLICABLE: The rule does not apply to the resource.</para>
        /// </description></item>
        /// <item><description><para>INSUFFICIENT_DATA: No data is available for the resource.</para>
        /// </description></item>
        /// <item><description><para>IGNORED: The evaluation result is ignored.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NON_COMPLIANT</para>
        /// </summary>
        [NameInMap("ComplianceType")]
        [Validation(Required=false)]
        public string ComplianceType { get; set; }

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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If the response is truncated, you can use this token to initiate another request to retrieve the remaining records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IWBjqMYSy0is7zSMGu16****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resource resides. For example, <c>global</c> indicates Global and <c>cn-hangzhou</c> indicates China (Hangzhou).</para>
        /// <para>For more information about how to obtain the region ID of a resource, see <a href="https://help.aliyun.com/document_detail/265983.html">ListAggregateDiscoveredResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>For more information about how to obtain the resource ID, see <a href="https://help.aliyun.com/document_detail/265983.html">ListAggregateDiscoveredResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23642660635396****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>For more information about how to obtain the resource type, see <a href="https://help.aliyun.com/document_detail/265983.html">ListAggregateDiscoveredResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::RAM::User</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The risk level of the compliance package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: high</para>
        /// </description></item>
        /// <item><description><para>2: medium</para>
        /// </description></item>
        /// <item><description><para>3: low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        /// <summary>
        /// <para>The sorting method. By default, this parameter is not specified. The supported value is <c>LastNonCompliantRecordTimestamp-Asc</c>. This value sorts resources based on the time when they first became non-compliant, in ascending order. You must set the <c>ComplianceType</c> parameter to <c>NON_COMPLIANT</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LastNonCompliantRecordTimestamp-Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
