// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DescribeRemediationRequest : TeaModel {
        /// <summary>
        /// The rule ID.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The ID of the remediation configuration.
        /// </summary>
        [NameInMap("RemediationId")]
        [Validation(Required=false)]
        public string RemediationId { get; set; }

    }

}
