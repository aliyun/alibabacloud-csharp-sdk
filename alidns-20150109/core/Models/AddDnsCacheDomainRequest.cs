// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsCacheDomainRequest : TeaModel {
        /// <summary>
        /// The maximum TTL period of the cached data retrieved from the origin DNS server. Unit: seconds. Valid values: 30 to 86400.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CacheTtlMax")]
        [Validation(Required=false)]
        public int? CacheTtlMax { get; set; }

        /// <summary>
        /// The minimum time-to-live (TTL) period of the cached data retrieved from the origin Domain Name System (DNS) server. Unit: seconds. Valid values: 30 to 86400.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CacheTtlMin")]
        [Validation(Required=false)]
        public int? CacheTtlMin { get; set; }

        /// <summary>
        /// The domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The instance ID of the cache-accelerated domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The remarks.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The origin DNS servers. A maximum of 10 origin DNS servers are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceDnsServer")]
        [Validation(Required=false)]
        public List<AddDnsCacheDomainRequestSourceDnsServer> SourceDnsServer { get; set; }
        public class AddDnsCacheDomainRequestSourceDnsServer : TeaModel {
            /// <summary>
            /// The domain name or IP address of the origin DNS server.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// The port of the origin DNS server.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// Specifies whether the origin DNS server supports Extension Mechanisms for DNS (EDNS). Valid values: NOT_SUPPORT and SUPPORT.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceEdns")]
        [Validation(Required=false)]
        public string SourceEdns { get; set; }

        /// <summary>
        /// The origin protocol policy. Valid values: TCP and UDP. Default value: UDP.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceProtocol")]
        [Validation(Required=false)]
        public string SourceProtocol { get; set; }

    }

}
