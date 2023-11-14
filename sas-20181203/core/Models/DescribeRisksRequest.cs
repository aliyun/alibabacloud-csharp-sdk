// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRisksRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The maximum number of entries to return. Default value: 20.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The baseline ID.
        /// 
        /// >  You can call the [DescribeCheckWarningSummary](~~DescribeCheckWarningSummary~~) operation to query the baseline IDs.
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

        /// <summary>
        /// The name of the baseline.
        /// </summary>
        [NameInMap("RiskName")]
        [Validation(Required=false)]
        public string RiskName { get; set; }

    }

}
