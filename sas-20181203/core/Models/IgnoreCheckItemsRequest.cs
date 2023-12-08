// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class IgnoreCheckItemsRequest : TeaModel {
        /// <summary>
        /// The risk items.
        /// </summary>
        [NameInMap("CheckAndRiskTypeList")]
        [Validation(Required=false)]
        public List<IgnoreCheckItemsRequestCheckAndRiskTypeList> CheckAndRiskTypeList { get; set; }
        public class IgnoreCheckItemsRequestCheckAndRiskTypeList : TeaModel {
            /// <summary>
            /// The ID of the check item.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// The baseline type of the check item.
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

        }

        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

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
        /// The reason why you add the risk item to the whitelist.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The data source. Valid values:
        /// 
        /// *   **default**: host baseline
        /// *   **agentless**: agentless baseline
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The operation that you want to perform on the risk item.Valid values:
        /// *  **1**: adds the risk item to the whitelist
        /// *  **2**: removes the risk item from the whitelist
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// The UUIDs of the servers.
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
