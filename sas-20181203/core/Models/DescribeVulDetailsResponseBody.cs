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
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            [NameInMap("Classifys")]
            [Validation(Required=false)]
            public List<DescribeVulDetailsResponseBodyCvesClassifys> Classifys { get; set; }
            public class DescribeVulDetailsResponseBodyCvesClassifys : TeaModel {
                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                [NameInMap("DemoVideoUrl")]
                [Validation(Required=false)]
                public string DemoVideoUrl { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            [NameInMap("CnvdId")]
            [Validation(Required=false)]
            public string CnvdId { get; set; }

            [NameInMap("Complexity")]
            [Validation(Required=false)]
            public string Complexity { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            [NameInMap("CvssScore")]
            [Validation(Required=false)]
            public string CvssScore { get; set; }

            [NameInMap("CvssVector")]
            [Validation(Required=false)]
            public string CvssVector { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("Poc")]
            [Validation(Required=false)]
            public string Poc { get; set; }

            [NameInMap("PocCreateTime")]
            [Validation(Required=false)]
            public long? PocCreateTime { get; set; }

            [NameInMap("PocDisclosureTime")]
            [Validation(Required=false)]
            public long? PocDisclosureTime { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("Reference")]
            [Validation(Required=false)]
            public string Reference { get; set; }

            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public string VulLevel { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
