// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to overwrite the existing data. Valid values:
        /// 
        /// *   true: The resources submitted this time will overwrite the previous associated resources.
        /// *   false: The resources submitted this time will not overwrite the previous associated resources. The associated resources after submission include the previous associated resources and the resources submitted this time.
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public string Overwrite { get; set; }

        /// <summary>
        /// The resources to be associated with the alert rule. The value is a JSON array.
        /// 
        /// >  You can add up to 100 resources each time. An alert rule can be associated with up to 3,000 resources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
