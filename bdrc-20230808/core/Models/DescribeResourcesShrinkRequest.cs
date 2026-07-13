// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The data redundancy type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LRS</para>
        /// </summary>
        [NameInMap("DataRedundancyType")]
        [Validation(Required=false)]
        public string DataRedundancyType { get; set; }

        /// <summary>
        /// <para>A filter for rules that failed the scoring.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-000c***yc9</para>
        /// </summary>
        [NameInMap("FailedRuleTemplate")]
        [Validation(Required=false)]
        public string FailedRuleTemplate { get; set; }

        /// <summary>
        /// <para>The page size. Default: 10. Maximum: 100. Values less than 10 are set to 10, and values greater than 100 are set to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. The service returns a token if the response is truncated. To retrieve the next page of results, include this token in your next request. If no token is returned, all results have been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cae**********699</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The Resource ARN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ecs:cn-hangzhou:123<em><b>7890:instance/i-123</b></em>7890</para>
        /// </summary>
        [NameInMap("ResourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// <para>The ID of the resource category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-000***123</para>
        /// </summary>
        [NameInMap("ResourceCategoryId")]
        [Validation(Required=false)]
        public string ResourceCategoryId { get; set; }

        /// <summary>
        /// <para>The resource ID. For example, for an instance, this is the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-0003***110</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>A list of resource owner IDs. Use this parameter for cross-account scenarios. If you omit this parameter, the service returns data for the current account by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[123***7890]</para>
        /// </summary>
        [NameInMap("ResourceOwnerIds")]
        [Validation(Required=false)]
        public string ResourceOwnerIdsShrink { get; set; }

        /// <summary>
        /// <para>The resource region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The sort key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>protectionScore</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The storage class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ARCHIVE</para>
        /// </summary>
        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
