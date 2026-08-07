// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeProductsRequest : TeaModel {
        /// <summary>
        /// <para>Filters by the product type of the resource. If this parameter is not specified, all types are queried.</para>
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
        /// <para>The list of resource owner IDs. This parameter is used in cross-account scenarios. If this parameter is left empty, data of the current account is returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[123***7890]</para>
        /// </summary>
        [NameInMap("ResourceOwnerIds")]
        [Validation(Required=false)]
        public List<long?> ResourceOwnerIds { get; set; }

        /// <summary>
        /// <para>Filters by the region where the resource resides. If this parameter is not specified, all regions are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

    }

}
