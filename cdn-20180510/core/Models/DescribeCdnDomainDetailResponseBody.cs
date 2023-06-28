// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// The details about the accelerated domain name.
        /// </summary>
        [NameInMap("GetDomainDetailModel")]
        [Validation(Required=false)]
        public DescribeCdnDomainDetailResponseBodyGetDomainDetailModel GetDomainDetailModel { get; set; }
        public class DescribeCdnDomainDetailResponseBodyGetDomainDetailModel : TeaModel {
            /// <summary>
            /// The workload type of the accelerated domain name. Valid values:
            /// 
            /// *   **web**: images and small files
            /// *   **download**: large files
            /// *   **video**: on-demand video and audio streaming
            /// </summary>
            [NameInMap("CdnType")]
            [Validation(Required=false)]
            public string CdnType { get; set; }

            /// <summary>
            /// The CNAME that is assigned to the accelerated domain name. You must add the CNAME record in the system of your DNS service provider to map the accelerated domain name to the CNAME.
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// The description of the domain name.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The accelerated domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The status of the accelerated domain name. Valid values:
            /// 
            /// *   **online**
            /// *   **offline**
            /// *   **configuring**
            /// *   **configure_failed**
            /// *   **checking**
            /// *   **check_failed**
            /// *   **stopping**
            /// *   **deleting**
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            [NameInMap("GlobalResourcePlan")]
            [Validation(Required=false)]
            public string GlobalResourcePlan { get; set; }

            /// <summary>
            /// The time when the domain name was created.
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// The time when the domain name was last modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The CNAME for which HTTPS is enabled.
            /// </summary>
            [NameInMap("HttpsCname")]
            [Validation(Required=false)]
            public string HttpsCname { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The acceleration region.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// Indicates whether the SSL certificate is enabled. Valid values:
            /// 
            /// *   **on**
            /// *   **off**
            /// </summary>
            [NameInMap("ServerCertificateStatus")]
            [Validation(Required=false)]
            public string ServerCertificateStatus { get; set; }

            /// <summary>
            /// The information about the origin server.
            /// </summary>
            [NameInMap("SourceModels")]
            [Validation(Required=false)]
            public DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModels SourceModels { get; set; }
            public class DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModels : TeaModel {
                [NameInMap("SourceModel")]
                [Validation(Required=false)]
                public List<DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModelsSourceModel> SourceModel { get; set; }
                public class DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModelsSourceModel : TeaModel {
                    /// <summary>
                    /// The address of the origin server.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The status.
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public string Enabled { get; set; }

                    /// <summary>
                    /// The port over which requests are redirected to the origin server. Ports 443 and 80 are supported.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The priority.
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    /// <summary>
                    /// The type of the origin server. Valid values:
                    /// 
                    /// *   **ipaddr**: an origin IP address
                    /// *   **domain**: an origin domain name
                    /// *   **oss**: the domain name of an Object Storage Service (OSS) bucket
                    /// *   **fc_domain:** a Function Compute domain name
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The weight of the origin server if multiple origin servers have been specified.
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
