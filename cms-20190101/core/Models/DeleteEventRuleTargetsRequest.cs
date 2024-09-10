// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteEventRuleTargetsRequest : TeaModel {
        /// <summary>
        /// The IDs of event-triggered alert rules.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<string> Ids { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the event-triggered alert rule.
        /// 
        /// For information about how to obtain the name of an event-triggered alert rule, see [DescribeEventRuleList](https://help.aliyun.com/document_detail/114996.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
