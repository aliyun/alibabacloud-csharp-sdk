// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeAttackSurfacesFacetsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public int? Domains { get; set; }

        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public int? Hosts { get; set; }

        [NameInMap("WebPaths")]
        [Validation(Required=false)]
        public int? WebPaths { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DNSMap")]
        [Validation(Required=false)]
        public int? DNSMap { get; set; }

        [NameInMap("WebServers")]
        [Validation(Required=false)]
        public int? WebServers { get; set; }

        [NameInMap("Ports")]
        [Validation(Required=false)]
        public int? Ports { get; set; }

        [NameInMap("CrawlerRequests")]
        [Validation(Required=false)]
        public int? CrawlerRequests { get; set; }

        [NameInMap("WebTechs")]
        [Validation(Required=false)]
        public int? WebTechs { get; set; }

        [NameInMap("Subdomains")]
        [Validation(Required=false)]
        public int? Subdomains { get; set; }

    }

}
