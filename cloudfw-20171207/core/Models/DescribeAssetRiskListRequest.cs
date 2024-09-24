// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetRiskListRequest : TeaModel {
        /// <summary>
        /// The IP addresses to query. Separate the IP addresses with commas (,). You can specify up to 20 IP addresses at a time.
        /// 
        /// > 
        /// 
        /// *   Example IPv4 address: 47.97.XX.XX.
        /// 
        /// *   Example IPv6 address: 2001:db8:ffff:ffff:ffff:XXXX:ffff.
        /// </summary>
        [NameInMap("IpAddrList")]
        [Validation(Required=false)]
        public List<string> IpAddrList { get; set; }

        /// <summary>
        /// The IP version of the asset that is protected by Cloud Firewall.
        /// 
        /// Valid values:
        /// 
        /// *   **4** (default): IPv4
        /// *   **6**: IPv6
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
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

    }

}
