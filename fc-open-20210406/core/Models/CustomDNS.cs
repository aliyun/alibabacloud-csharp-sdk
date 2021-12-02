// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CustomDNS : TeaModel {
        /// <summary>
        /// DNS resolver 配置参数列表
        /// </summary>
        [NameInMap("dnsOptions")]
        [Validation(Required=false)]
        public List<DNSOption> DnsOptions { get; set; }

        /// <summary>
        /// DNS 服务器的 IP 地址列表
        /// </summary>
        [NameInMap("nameServers")]
        [Validation(Required=false)]
        public List<string> NameServers { get; set; }

        /// <summary>
        /// DNS 搜索域的列表
        /// </summary>
        [NameInMap("searches")]
        [Validation(Required=false)]
        public List<string> Searches { get; set; }

    }

}
