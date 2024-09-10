// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListByBuildRiskResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageListByBuildRiskResponseBodyData Data { get; set; }
        public class DescribeImageListByBuildRiskResponseBodyData : TeaModel {
            /// <summary>
            /// The images.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeImageListByBuildRiskResponseBodyDataList> List { get; set; }
            public class DescribeImageListByBuildRiskResponseBodyDataList : TeaModel {
                /// <summary>
                /// The digest value of the image.
                /// </summary>
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// The timestamp generated when the first scan was performed. Unit: milliseconds.
                /// </summary>
                [NameInMap("FirstScanTime")]
                [Validation(Required=false)]
                public long? FirstScanTime { get; set; }

                /// <summary>
                /// The instance ID of the image repository.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The timestamp generated when the last scan was performed. Unit: milliseconds.
                /// </summary>
                [NameInMap("LastScanTime")]
                [Validation(Required=false)]
                public long? LastScanTime { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
                /// The risk level. Valid values:
                /// 
                /// *   **high**
                /// *   **medium**
                /// *   **low**
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// The status of the alert event. Valid values:
                /// 
                /// *   **0**: unhandled.
                /// *   **1**: ignored.
                /// *   **2**: false positive.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The tag of the image.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

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
            public DescribeImageListByBuildRiskResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageListByBuildRiskResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// The page number. Default value: **1**.
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
                /// 
                /// >  We recommend that you do not leave this parameter empty.
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

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
