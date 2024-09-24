// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficDetailRequest : TeaModel {
        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify a value in the YYYYMMDD format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The field based on which you want to sort the query results. Valid values:
        /// 
        /// *   **resourceId**
        /// *   **trafficDay**
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// The instance ID or the IP address of the asset.
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify a value in the YYYYMMDD format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The traffic type. This parameter is required. Valid values:
        /// 
        /// *   **EIP_TRAFFIC**: traffic for the Internet firewall.
        /// *   **NatGateway_TRAFFIC**: traffic for NAT firewalls.
        /// *   **VPC_TRAFFIC**: traffic for virtual private cloud (VPC) firewalls.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrafficType")]
        [Validation(Required=false)]
        public string TrafficType { get; set; }

    }

}
