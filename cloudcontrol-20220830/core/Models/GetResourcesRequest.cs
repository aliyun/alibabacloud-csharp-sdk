// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for resources.</para>
        /// <para>Specify multiple key-value pairs in JSON format to filter resources. If a List or Get operation for a cloud product supports filtering by specific properties, you can use those properties as filter conditions for this parameter.</para>
        /// <remarks>
        /// <para>The supported filter fields may vary for different resource types. For more information about the supported fields, see the OpenAPI documentation for the specific resource.</para>
        /// </remarks>
        /// <para>For example, DBInstance resources support filtering by the <c>EditionType</c> and <c>PaymentType</c> fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;EditionType&quot;: &quot;Community&quot;,
        ///   &quot;PaymentType&quot;: &quot;PostPaid&quot;
        /// }</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filter { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return on each page for a paged query. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// <list type="bullet">
        /// <item><description><para>You do not need to specify this parameter for the first query. The system returns data from the first page.</para>
        /// </description></item>
        /// <item><description><para>For subsequent queries, set this parameter to the nextToken value returned from the previous call.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter contains only digits, Cloud Control API treats it as the <c>PageNumber</c> for paging.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required if the cloud product is region-specific.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
