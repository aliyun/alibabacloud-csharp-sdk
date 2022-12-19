// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class IgnoreHcCheckWarningsRequest : TeaModel {
        /// <summary>
        /// The ID of the check item.
        /// 
        /// >  You can call the [DescribeCheckWarnings](~~DescribeCheckWarnings~~) operation to query the IDs of check items.
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIds { get; set; }

        /// <summary>
        /// The ID of the alert that is triggered by the check item. Separate multiple IDs with commas (,).
        /// 
        /// >  You can call the [DescribeCheckWarnings](~~DescribeCheckWarnings~~) operation to query the IDs of alerts that are triggered by check items.
        /// </summary>
        [NameInMap("CheckWarningIds")]
        [Validation(Required=false)]
        public string CheckWarningIds { get; set; }

        /// <summary>
        /// The reason for the current operation.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The ID of the risk item that you want to ignore or cancel ignoring.
        /// 
        /// >  You can call the [DescribeCheckWarningSummary](~~DescribeCheckWarningSummary~~) operation to query the IDs of risk items.
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public string RiskId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the operation that you want to perform. Valid values:
        /// 
        /// *   **1**: ignores a risk item
        /// *   **2**: cancels ignoring a risk item
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
