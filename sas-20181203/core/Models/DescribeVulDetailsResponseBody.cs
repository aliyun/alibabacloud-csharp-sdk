// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulDetailsResponseBody : TeaModel {
        /// <summary>
        /// The details of the vulnerability.
        /// </summary>
        [NameInMap("Cves")]
        [Validation(Required=false)]
        public List<DescribeVulDetailsResponseBodyCves> Cves { get; set; }
        public class DescribeVulDetailsResponseBodyCves : TeaModel {
            /// <summary>
            /// The type of the vulnerability.
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// The vulnerability types.
            /// </summary>
            [NameInMap("Classifys")]
            [Validation(Required=false)]
            public List<DescribeVulDetailsResponseBodyCvesClassifys> Classifys { get; set; }
            public class DescribeVulDetailsResponseBodyCvesClassifys : TeaModel {
                /// <summary>
                /// The type of the vulnerability.
                /// </summary>
                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                /// <summary>
                /// The URL of the demo video for the vulnerability.
                /// </summary>
                [NameInMap("DemoVideoUrl")]
                [Validation(Required=false)]
                public string DemoVideoUrl { get; set; }

                /// <summary>
                /// The description of the vulnerability type.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// The China National Vulnerability Database (CNVD) ID.
            /// </summary>
            [NameInMap("CnvdId")]
            [Validation(Required=false)]
            public string CnvdId { get; set; }

            /// <summary>
            /// The difficulty level of exploiting the vulnerability. Valid values:
            /// 
            /// *   **LOW**
            /// *   **MEDIUM**
            /// *   **HIGH**
            /// </summary>
            [NameInMap("Complexity")]
            [Validation(Required=false)]
            public string Complexity { get; set; }

            /// <summary>
            /// The CVE content.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The Common Vulnerabilities and Exposures (CVE) ID.
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// The Common Vulnerability Scoring System (CVSS) score of the vulnerability in the Alibaba Cloud vulnerability library.
            /// </summary>
            [NameInMap("CvssScore")]
            [Validation(Required=false)]
            public string CvssScore { get; set; }

            /// <summary>
            /// The vector that is used to calculate the CVSS score.
            /// </summary>
            [NameInMap("CvssVector")]
            [Validation(Required=false)]
            public string CvssVector { get; set; }

            /// <summary>
            /// The instance name of the server.
            /// 
            /// > This parameter is deprecated. You can call the [DescribeVulList](~~DescribeVulList~~) operation to query the instances that are affected by vulnerabilities.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// 
            /// > This parameter is deprecated. You can call the [DescribeVulList](~~DescribeVulList~~) operation to query the instances that are affected by vulnerabilities.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// 
            /// > This parameter is deprecated. You can call the [DescribeVulList](~~DescribeVulList~~) operation to query the instances that are affected by vulnerabilities.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The POC content.
            /// </summary>
            [NameInMap("Poc")]
            [Validation(Required=false)]
            public string Poc { get; set; }

            /// <summary>
            /// The timestamp when the proof of concept (POC) was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("PocCreateTime")]
            [Validation(Required=false)]
            public long? PocCreateTime { get; set; }

            /// <summary>
            /// The timestamp when the POC was disclosed. Unit: milliseconds.
            /// </summary>
            [NameInMap("PocDisclosureTime")]
            [Validation(Required=false)]
            public long? PocDisclosureTime { get; set; }

            /// <summary>
            /// The service that is affected by the vulnerability.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The reference of the vulnerability in the Alibaba Cloud vulnerability library. The value is a URL.
            /// </summary>
            [NameInMap("Reference")]
            [Validation(Required=false)]
            public string Reference { get; set; }

            /// <summary>
            /// The disclosure time that is displayed for the vulnerability in the Alibaba Cloud vulnerability library. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// The fixing suggestions of the vulnerability.
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            /// <summary>
            /// The introduction to the vulnerability.
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// The ID of the asset on which the vulnerability is detected.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The name of the asset on which the vulnerability is detected.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The title of the vulnerability announcement.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The vendor that disclosed the vulnerability.
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            /// <summary>
            /// The severity of the vulnerability. Valid values:
            /// 
            /// *   **serious**
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public string VulLevel { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
