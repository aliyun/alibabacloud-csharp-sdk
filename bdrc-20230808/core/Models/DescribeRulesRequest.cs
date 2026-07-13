// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeRulesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. You can obtain this token from the <c>NextToken</c> parameter in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cae**********699</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-000***123</para>
        /// </summary>
        [NameInMap("ResourceCategoryId")]
        [Validation(Required=false)]
        public string ResourceCategoryId { get; set; }

        [NameInMap("ResourceOwnerIds")]
        [Validation(Required=false)]
        public List<long?> ResourceOwnerIds { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resource resides.</para>
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

    }

}
