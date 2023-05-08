// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListWithBaselineNameResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the images returned.
        /// </summary>
        [NameInMap("ImageInfos")]
        [Validation(Required=false)]
        public List<DescribeImageListWithBaselineNameResponseBodyImageInfos> ImageInfos { get; set; }
        public class DescribeImageListWithBaselineNameResponseBodyImageInfos : TeaModel {
            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The ID of the container.
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// The SHA-256 value of the image digest.
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// The number of images on which **high** baseline risks are detected.
            /// </summary>
            [NameInMap("HighRiskImage")]
            [Validation(Required=false)]
            public int? HighRiskImage { get; set; }

            /// <summary>
            /// The name of the image.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The timestamp when the image was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("ImageCreate")]
            [Validation(Required=false)]
            public long? ImageCreate { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The size of the image.
            /// </summary>
            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public int? ImageSize { get; set; }

            /// <summary>
            /// The timestamp when the image was updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("ImageUpdate")]
            [Validation(Required=false)]
            public long? ImageUpdate { get; set; }

            /// <summary>
            /// The ID of the image instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// The number of images on which **low** baseline risks are detected.
            /// </summary>
            [NameInMap("LowRiskImage")]
            [Validation(Required=false)]
            public int? LowRiskImage { get; set; }

            /// <summary>
            /// The number of images on which **medium** baseline risks are detected.
            /// </summary>
            [NameInMap("MiddleRiskImage")]
            [Validation(Required=false)]
            public int? MiddleRiskImage { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The number of images that do not have baseline risks.
            /// </summary>
            [NameInMap("NoRiskImage")]
            [Validation(Required=false)]
            public int? NoRiskImage { get; set; }

            /// <summary>
            /// The pod.
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// The region ID of the image instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
            /// The namespace to which the image repository belongs.
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// The type of the image repository.
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// Indicates whether the image is at risk. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// The version of the image.
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

            /// <summary>
            /// The total number of risk items that are detected on the image by using the baseline.
            /// </summary>
            [NameInMap("TotalItemCount")]
            [Validation(Required=false)]
            public int? TotalItemCount { get; set; }

            /// <summary>
            /// The UUID of the image.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageListWithBaselineNameResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageListWithBaselineNameResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of the images returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page. Default value: **1**.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **10**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of images on which baseline risks are detected.
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
