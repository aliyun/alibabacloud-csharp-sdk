// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class EnableMetricRulesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the alert rules.
        /// 
        /// Valid values of N: 1 to 100.
        /// 
        /// For information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public List<string> RuleId { get; set; }

    }

}
