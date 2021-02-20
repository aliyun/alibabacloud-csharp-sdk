// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeDomainAttackSurfacesFacetsResponseBody : TeaModel {
        [NameInMap("WebPaths")]
        [Validation(Required=false)]
        public int? WebPaths { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WebServers")]
        [Validation(Required=false)]
        public int? WebServers { get; set; }

        [NameInMap("CrawlerRequests")]
        [Validation(Required=false)]
        public int? CrawlerRequests { get; set; }

        [NameInMap("WebTechs")]
        [Validation(Required=false)]
        public int? WebTechs { get; set; }

    }

}
