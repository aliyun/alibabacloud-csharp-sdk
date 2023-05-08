// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAffectedMaliciousFileImagesResponseBody : TeaModel {
        /// <summary>
        /// The region ID of the image repository.
        /// </summary>
        [NameInMap("AffectedMaliciousFileImagesResponse")]
        [Validation(Required=false)]
        public List<DescribeAffectedMaliciousFileImagesResponseBodyAffectedMaliciousFileImagesResponse> AffectedMaliciousFileImagesResponse { get; set; }
        public class DescribeAffectedMaliciousFileImagesResponseBodyAffectedMaliciousFileImagesResponse : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// The ID of the container.
            /// </summary>
            [NameInMap("FirstScanTimestamp")]
            [Validation(Required=false)]
            public long? FirstScanTimestamp { get; set; }

            [NameInMap("HighLight")]
            [Validation(Required=false)]
            public string HighLight { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The namespace to which the image repository belongs.
            /// 
            /// >  Fuzzy match is supported.
            /// </summary>
            [NameInMap("ImageUuid")]
            [Validation(Required=false)]
            public string ImageUuid { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// Queries the details of malicious image samples.
            /// </summary>
            [NameInMap("LatestScanTimestamp")]
            [Validation(Required=false)]
            public long? LatestScanTimestamp { get; set; }

            /// <summary>
            /// The ID of the image repository.
            /// 
            /// >  You can call the [ListRepository](~~145293~~) operation to query the IDs of image repositories from the value of the **RepoId** response parameter.
            /// </summary>
            [NameInMap("LatestVerifyTimestamp")]
            [Validation(Required=false)]
            public long? LatestVerifyTimestamp { get; set; }

            /// <summary>
            /// The pod.
            /// </summary>
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The pod.
            /// </summary>
            [NameInMap("MaliciousMd5")]
            [Validation(Required=false)]
            public string MaliciousMd5 { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// The timestamp of the last verification.
            /// </summary>
            [NameInMap("RepoInstanceId")]
            [Validation(Required=false)]
            public string RepoInstanceId { get; set; }

            /// <summary>
            /// DescribeAffectedMaliciousFileImages
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("RepoRegionId")]
            [Validation(Required=false)]
            public string RepoRegionId { get; set; }

            /// <summary>
            /// The name of the image repository.
            /// 
            /// >  Fuzzy match is supported.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The UUID of the image.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the container image.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeAffectedMaliciousFileImagesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeAffectedMaliciousFileImagesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The URL to download the malicious image sample.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The image digest.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The tag that is added to the image.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The types of the assets that you want to scan.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the container image.
        /// 
        /// >  You can call the [ListRepository](~~145293~~) operation to query the IDs of container images from the value of the **InstanceId** response parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
