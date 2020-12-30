// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulDetailsResponseBody : TeaModel {
        [NameInMap("Cves")]
        [Validation(Required=false)]
        public List<DescribeVulDetailsResponseBodyCves> Cves { get; set; }
        public class DescribeVulDetailsResponseBodyCves : TeaModel {
            [NameInMap("Complexity")]
            [Validation(Required=false)]
            public string Complexity { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("PocCreateTime")]
            [Validation(Required=false)]
            public long? PocCreateTime { get; set; }

            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            [NameInMap("CnvdId")]
            [Validation(Required=false)]
            public string CnvdId { get; set; }

            [NameInMap("Reference")]
            [Validation(Required=false)]
            public string Reference { get; set; }

            [NameInMap("CvssScore")]
            [Validation(Required=false)]
            public string CvssScore { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            [NameInMap("PocDisclosureTime")]
            [Validation(Required=false)]
            public long? PocDisclosureTime { get; set; }

            [NameInMap("CvssVector")]
            [Validation(Required=false)]
            public string CvssVector { get; set; }

            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public string VulLevel { get; set; }

            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Poc")]
            [Validation(Required=false)]
            public string Poc { get; set; }

            [NameInMap("Classifys")]
            [Validation(Required=false)]
            public List<DescribeVulDetailsResponseBodyCvesClassifys> Classifys { get; set; }
            public class DescribeVulDetailsResponseBodyCvesClassifys : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                [NameInMap("DemoVideoUrl")]
                [Validation(Required=false)]
                public string DemoVideoUrl { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
