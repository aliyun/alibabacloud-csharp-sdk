// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeTagValueListRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100. Pages start from page 1. Default value: 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The key of the tag whose values you want to query.
        /// 
        /// For more information about how to obtain a tag key, see [DescribeTagKeyList](https://help.aliyun.com/document_detail/145558.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

    }

}
