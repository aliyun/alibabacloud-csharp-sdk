// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListResourceEvaluationResultsRequest : TeaModel {
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
        /// </summary>
        [NameInMap("ComplianceType")]
        [Validation(Required=false)]
        public string ComplianceType { get; set; }

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
        /// <para>The token that you want to use to initiate the current request. If the response of the previous request is truncated, you can use this token to initiate another request and obtain the remaining entries.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>IWBjqMYSy0is7zSMGu16****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the region where one or more resources you want to query reside. For example, the value <c>global</c> indicates global regions and the value <c>cn-hangzhou</c> indicates the China (Hangzhou) region.</para>
        /// <para>For more information about how to obtain the ID of the region where a resource resides, see <a href="https://help.aliyun.com/document_detail/169620.html">ListDiscoveredResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// <para>For more information about how to obtain the ID of a resource, see <a href="https://help.aliyun.com/document_detail/169620.html">ListDiscoveredResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23642660635396****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>For more information about how to query the type of a resource, see <a href="https://help.aliyun.com/document_detail/169620.html">ListDiscoveredResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::RAM::User</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
