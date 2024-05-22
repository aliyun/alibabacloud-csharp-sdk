// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddrAttributeInfoRequest : TeaModel {
        /// <summary>
        /// The addresses whose source regions you want to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Addrs")]
        [Validation(Required=false)]
        public string Addrs { get; set; }

        /// <summary>
        /// The language to return some response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of the addresses. Valid values:
        /// 
        /// *   IPV4: IPv4 address
        /// *   IPV6: IPv6 address
        /// *   DOMAIN: domain name
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
