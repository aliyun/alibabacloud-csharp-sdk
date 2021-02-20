// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeHostAttackSurfacesFacetsResponseBody : TeaModel {
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public int? Hosts { get; set; }

        [NameInMap("WebPaths")]
        [Validation(Required=false)]
        public int? WebPaths { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Ports")]
        [Validation(Required=false)]
        public int? Ports { get; set; }

        [NameInMap("CrawlerRequests")]
        [Validation(Required=false)]
        public int? CrawlerRequests { get; set; }

        [NameInMap("WebTechs")]
        [Validation(Required=false)]
        public int? WebTechs { get; set; }

    }

}
