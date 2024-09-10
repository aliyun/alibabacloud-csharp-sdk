// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteDynamicTagGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the tag rule.
        /// 
        /// For information about how to obtain the ID of a tag rule, see [DescribeDynamicTagRuleList](https://help.aliyun.com/document_detail/150126.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DynamicTagRuleId")]
        [Validation(Required=false)]
        public string DynamicTagRuleId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
