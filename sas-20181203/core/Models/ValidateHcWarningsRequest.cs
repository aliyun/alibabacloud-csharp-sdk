// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ValidateHcWarningsRequest : TeaModel {
        /// <summary>
        /// The IDs of the check items. Separate multiple IDs with commas (,).
        /// 
        /// > You can call the [DescribeCheckWarningSummary](~~116179~~) operation to query the IDs of check items.
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIds { get; set; }

        /// <summary>
        /// The list of IDs of the risk items that you want to verify. Separate multiple IDs with commas (,).
        /// 
        /// > You can call the [DescribeCheckWarnings](~~DescribeCheckWarnings~~) operation to query the IDs of risk items.
        /// </summary>
        [NameInMap("RiskIds")]
        [Validation(Required=false)]
        public string RiskIds { get; set; }

        /// <summary>
        /// The UUIDs of the servers on which you want to verify the risk items. Separate multiple UUIDs with commas (,).
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
