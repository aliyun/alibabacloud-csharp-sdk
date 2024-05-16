// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchDescribeCdnIpInfoRequest : TeaModel {
        /// <summary>
        /// The list of IP addresses to query. Separate IP addresses with commas (,). You can specify up to 20 IP addresses at a time.
        /// 
        /// > *   Example of an IPv4 address: 192.0.2.1
        /// >*   Example of an IPv6 address: 2001:db8:ffff:ffff:ffff:\\*\\*\\*\\*:ffff.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpAddrList")]
        [Validation(Required=false)]
        public string IpAddrList { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
