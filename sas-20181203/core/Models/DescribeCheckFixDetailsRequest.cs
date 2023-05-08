// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckFixDetailsRequest : TeaModel {
        /// <summary>
        /// Indicates whether the rule is optional. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIds { get; set; }

        /// <summary>
        /// The description of the rule.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The default value of the rule.
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

    }

}
