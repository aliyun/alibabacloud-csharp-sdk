// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVulDetailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Cves")]
        [Validation(Required=false)]
        public List<DescribeVulDetailsResponseBodyCves> Cves { get; set; }
        public class DescribeVulDetailsResponseBodyCves : TeaModel {
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("CvssScore")]
            [Validation(Required=false)]
            public string CvssScore { get; set; }

        }

    }

}
