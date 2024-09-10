// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ValidateHcWarningsRequest : TeaModel {
        /// <summary>
        /// The IDs of check items that you want to verify. Separate multiple IDs with commas (,).
        /// > You can use [DescribeCheckWarningSummary](https://help.aliyun.com/document_detail/116179.html) to get IDs of check items.
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIds { get; set; }

        /// <summary>
        /// The IDs of risk items that you want to verify. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("RiskIds")]
        [Validation(Required=false)]
        public string RiskIds { get; set; }

        /// <summary>
        /// The status of the check item that you want to verify.
        /// 
        /// *   1: failed
        /// *   3: passed
        /// *   5: expired
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The UUIDs of the servers on which you want to verify the risk items. Separate multiple UUIDs with commas (,).
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
