// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeProductsRequest : TeaModel {
        /// <summary>
        /// <para>The product type of the resource. If you omit this parameter, the API returns resources of all product types. For example, specify <c>oss</c> to query resources from Object Storage Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The resource category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-000***123</para>
        /// </summary>
        [NameInMap("ResourceCategoryId")]
        [Validation(Required=false)]
        public string ResourceCategoryId { get; set; }

        /// <summary>
        /// <para>A list of resource owner IDs for cross-account resource queries. If you omit this parameter, the API returns resources from the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[123***7890]</para>
        /// </summary>
        [NameInMap("ResourceOwnerIds")]
        [Validation(Required=false)]
        public List<long?> ResourceOwnerIds { get; set; }

        /// <summary>
        /// <para>The ID of the resource\&quot;s region. If you omit this parameter, the API returns resources from all regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

    }

}
