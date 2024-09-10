// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about the images.
        /// </summary>
        [NameInMap("ImageInstanceList")]
        [Validation(Required=false)]
        public List<DescribeImageInstancesResponseBodyImageInstanceList> ImageInstanceList { get; set; }
        public class DescribeImageInstancesResponseBodyImageInstanceList : TeaModel {
            /// <summary>
            /// The number of alerts that are generated for the image.
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// Indicates whether alerts are generated for the image. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// Indicates whether the image was deployed. Valid values:
            /// 
            /// *   **0**: The image was not deployed.
            /// *   **1**: The image was deployed.
            /// </summary>
            [NameInMap("Deployed")]
            [Validation(Required=false)]
            public int? Deployed { get; set; }

            /// <summary>
            /// The digest value of the image.
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// The address of the image.
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }

            /// <summary>
            /// The number of baseline risks.
            /// </summary>
            [NameInMap("HcCount")]
            [Validation(Required=false)]
            public int? HcCount { get; set; }

            /// <summary>
            /// Indicates whether baseline risks exist. Valid values:
            /// 
            /// *   **NO**
            /// *   **YES**
            /// </summary>
            [NameInMap("HcStatus")]
            [Validation(Required=false)]
            public string HcStatus { get; set; }

            /// <summary>
            /// The timestamp generated when the image was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("ImageCreate")]
            [Validation(Required=false)]
            public string ImageCreate { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The size of the image. Unit: MB.
            /// </summary>
            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public string ImageSize { get; set; }

            /// <summary>
            /// The timestamp generated when the image was updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("ImageUpdate")]
            [Validation(Required=false)]
            public string ImageUpdate { get; set; }

            /// <summary>
            /// The instance ID of the image.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The timestamp when the last scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// The region ID of the image.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The type of the image. Valid values:
            /// 
            /// *   **acr**
            /// *   **harbor**
            /// *   **quay**
            /// *   **CI/CD**
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
            /// The namespace to which the image repository belongs.
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// The type of the repository. Valid values:
            /// 
            /// *   **private**
            /// *   **public**
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// Indicates whether risks exist. Valid values:
            /// 
            /// *   **NO**
            /// *   **YES**
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// The scan progress of the image. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("ScaProgress")]
            [Validation(Required=false)]
            public int? ScaProgress { get; set; }

            /// <summary>
            /// The error code of the image scan result. Valid values:
            /// 
            /// *   **TASK_NOT_EXISTS**: The image scan task does not exist.
            /// *   **TASK_NOT_SUPPORT_REGION**: The image scan task cannot be performed in the current region.
            /// *   **forbid_create_repeat_task**: The image scan task already exists.
            /// </summary>
            [NameInMap("ScaResult")]
            [Validation(Required=false)]
            public string ScaResult { get; set; }

            /// <summary>
            /// The scan status of the image. Valid values:
            /// 
            /// *   **INIT**: The image scan task is pending startup.
            /// *   **START**: The image scan task is started.
            /// *   **MESSAGE_SEND**: The message about the image scan task is sent.
            /// *   **START_RUN**: The image analysis task is started.
            /// *   **DOWNLOAD**: The image scan result is downloaded.
            /// *   **PRE_ANALYZER**: The image pre-analysis is started.
            /// *   **WEB_SHELL_ANALYZER**: The WebShell analysis of the image is complete.
            /// *   **CVE_ANALYZER**: The Common Vulnerabilities and Exposures (CVE) analysis of the image is complete.
            /// *   **BIN_ANALYZER**: The binary analysis of the image is complete.
            /// *   **OTHER_ANALYZER**: The extended analysis of the image is complete.
            /// *   **SUCCESS**: The image scan task is complete.
            /// *   **PRE_ANALYZER_SUCCESS**: The image pre-analysis is complete.
            /// *   **FAIL**: The image scan task failed.
            /// *   **TIMEOUT**: The image scan task timed out.
            /// </summary>
            [NameInMap("ScaStatus")]
            [Validation(Required=false)]
            public string ScaStatus { get; set; }

            /// <summary>
            /// The status of the image. Valid values:
            /// 
            /// *   **NORMAL**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tag of the image.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The number of vulnerabilities in the image.
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

            /// <summary>
            /// Indicates whether vulnerabilities exist in the image. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("VulStatus")]
            [Validation(Required=false)]
            public string VulStatus { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of images returned on the current page.
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
            /// The total number of returned entries.
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
