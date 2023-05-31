// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageRiskResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of security information about the image.
        /// </summary>
        [NameInMap("ImageRiskList")]
        [Validation(Required=false)]
        public List<ListImageRiskResponseBodyImageRiskList> ImageRiskList { get; set; }
        public class ListImageRiskResponseBodyImageRiskList : TeaModel {
            /// <summary>
            /// The digest value of the image.
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// An array that consists of the details of the endpoint.
            /// </summary>
            [NameInMap("EndPointList")]
            [Validation(Required=false)]
            public List<ListImageRiskResponseBodyImageRiskListEndPointList> EndPointList { get; set; }
            public class ListImageRiskResponseBodyImageRiskListEndPointList : TeaModel {
                /// <summary>
                /// An array that consists the details of the domain name in the endpoint.
                /// </summary>
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public List<string> Domains { get; set; }

                /// <summary>
                /// The type of the domain name in the endpoint. Valid values:
                /// 
                /// *   **internet**: Internet
                /// *   **intranet**: internal network
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The endpoint of Container Registry.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }

            /// <summary>
            /// The image of the container.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The registration status of the image repository. Valid values:
            /// 
            /// *   **IN_SAS**: The image repository is registered with Security Center.
            /// *   **NOT_IN_SAS**: The image repository is not registered with Security Center.
            /// </summary>
            [NameInMap("ImageAccessType")]
            [Validation(Required=false)]
            public string ImageAccessType { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The public endpoint of the image repository.
            /// </summary>
            [NameInMap("InternetURLs")]
            [Validation(Required=false)]
            public string InternetURLs { get; set; }

            /// <summary>
            /// The region of the image repository.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The type of the image repository. Valid values:
            /// 
            /// *   **acr**
            /// *   **harbor**
            /// *   **quay**
            /// *   **CI/CD**: Jenkins
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// The ID of the image repository.
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// The name of the image repository.
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// The name of the namespace to which the repository belongs.
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// The type of the repository. Valid values:
            /// 
            /// *   `PUBLIC`
            /// *   `PRIVATE`
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// The statistics on a security event.
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// The tag that is added to the image.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// Indicates whether the image version is immutable. If the image version is immutable, only the image of the latest version in the image repository can be overwritten. Valid values:
            /// 
            /// *   **0**: The image version is mutable.
            /// *   **1**: The image version is immutable.
            /// </summary>
            [NameInMap("TagImmutable")]
            [Validation(Required=false)]
            public int? TagImmutable { get; set; }

            /// <summary>
            /// The UUID of the image.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The endpoint of the image repository in the VPC.
            /// </summary>
            [NameInMap("VpcURLs")]
            [Validation(Required=false)]
            public string VpcURLs { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListImageRiskResponseBodyPageInfo PageInfo { get; set; }
        public class ListImageRiskResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
