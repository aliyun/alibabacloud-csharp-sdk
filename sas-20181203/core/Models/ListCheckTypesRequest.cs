// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckTypesRequest : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the baseline.
        /// 
        /// >  You can call the [DescribeCheckWarningSummary](~~116179~~) operation to query the IDs of baselines.
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

        /// <summary>
        /// Whether to query the check item list. The default value is false. Valid values:
        /// 
        /// - **false**: Not Query
        /// - **true**: Query
        /// </summary>
        [NameInMap("ShowChecks")]
        [Validation(Required=false)]
        public bool? ShowChecks { get; set; }

        /// <summary>
        /// The data source. Default value: **default**. Valid values:
        /// 
        /// *   **agentless**: The check items of baselines for agentless detection.
        /// *   **default**: The check items of baselines for hosts.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
