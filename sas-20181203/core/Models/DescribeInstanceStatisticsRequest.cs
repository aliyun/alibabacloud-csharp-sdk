// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceStatisticsRequest : TeaModel {
        /// <summary>
        /// The source of the request. Set the value to **sas**, which indicates that the request is sent from Security Center.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

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
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The UUIDs of the assets to query. Separate multiple UUIDs with commas (,). You can call the [DescribeCloudCenterInstances](~~141932~~) operation to query the UUIDs of assets.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
