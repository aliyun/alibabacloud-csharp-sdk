// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class EnableMetricRuleBlackListRequest : TeaModel {
        /// <summary>
        /// The IDs of the blacklist policies. Separate multiple IDs with commas (,). You can specify up to 50 IDs.
        /// 
        /// For information about how to obtain the ID of a blacklist policy, see [DescribeMetricRuleBlackList](https://help.aliyun.com/document_detail/457257.html).
        /// 
        /// > You can also set this parameter to a JSON array. Example: `["a9ad2ac2-3ed9-11ed-b878-0242ac12****","5cb8a9a4-198f-4651-a353-f8b28788****"]`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies whether to enable the blacklist policy. Valid values:
        /// 
        /// *   true: The blacklist policy is enabled.
        /// *   false (default): The blacklist policy is disabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public bool? IsEnable { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
