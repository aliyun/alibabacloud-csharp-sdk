// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityEventOperationsRequest : TeaModel {
        /// <summary>
        /// The value of the field that can be used in the whitelist rule.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The field that can be used in the whitelist rule.
        /// </summary>
        [NameInMap("SecurityEventId")]
        [Validation(Required=false)]
        public long? SecurityEventId { get; set; }

        /// <summary>
        /// The operation that is supported in the whitelist rule. Valid values:
        /// 
        /// *   **contains**: contains
        /// *   **notContains**: does not contain
        /// *   **regex**: regular expression
        /// *   **strEqual**: equals
        /// *   **strNotEqual**: does not equal
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
