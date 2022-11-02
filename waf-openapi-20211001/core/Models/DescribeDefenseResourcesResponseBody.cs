// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeDefenseResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeDefenseResourcesResponseBodyResources : TeaModel {
            [NameInMap("CustomHeaders")]
            [Validation(Required=false)]
            public List<string> CustomHeaders { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public Dictionary<string, object> Detail { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            [NameInMap("ResourceOrigin")]
            [Validation(Required=false)]
            public string ResourceOrigin { get; set; }

            [NameInMap("XffStatus")]
            [Validation(Required=false)]
            public int? XffStatus { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
