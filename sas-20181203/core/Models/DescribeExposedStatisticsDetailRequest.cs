// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsDetailRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the member in the resource directory.
        /// 
        /// >  You can call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The type of the exposed asset. Valid values:
        /// 
        /// *   **exposureType**: gateway assets
        /// *   **exposurePort**: ports
        /// *   **exposureComponent**: system components
        /// *   **exposureIp**: IP addresses
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StatisticsType")]
        [Validation(Required=false)]
        public string StatisticsType { get; set; }

        /// <summary>
        /// The type of the gateway asset. This parameter is required when the **StatisticsType** parameter is set to **exposureType**. Valid values:
        /// 
        /// *   **SLB**: the public IP address of a Server Load Balancer (SLB) instance
        /// *   **DNAT**: the NAT gateway that connects to the Internet by using the DNAT feature
        /// </summary>
        [NameInMap("StatisticsTypeGatewayType")]
        [Validation(Required=false)]
        public string StatisticsTypeGatewayType { get; set; }

        /// <summary>
        /// The ID of the gateway asset. This parameter is required when the **StatisticsType** parameter is set to **exposureType**.
        /// </summary>
        [NameInMap("StatisticsTypeInstanceValue")]
        [Validation(Required=false)]
        public string StatisticsTypeInstanceValue { get; set; }

    }

}
