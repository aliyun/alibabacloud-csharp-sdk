// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeDynamicTagRuleListRequest : TeaModel {
        /// <summary>
        /// The ID of the tag rule.
        /// </summary>
        [NameInMap("DynamicTagRuleId")]
        [Validation(Required=false)]
        public string DynamicTagRuleId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Minimum value: 1. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The tag key.
        /// 
        /// For more information about how to obtain a tag key, see [DescribeTagKeyList](https://help.aliyun.com/document_detail/145558.html).
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        /// <summary>
        /// The ID of the region to which the tags belong.
        /// </summary>
        [NameInMap("TagRegionId")]
        [Validation(Required=false)]
        public string TagRegionId { get; set; }

        /// <summary>
        /// The tag value.
        /// 
        /// For more information about how to obtain a tag value, see [DescribeTagKeyList](https://help.aliyun.com/document_detail/145557.html).
        /// </summary>
        [NameInMap("TagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
