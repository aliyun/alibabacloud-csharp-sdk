// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information about image repositories.
        /// </summary>
        [NameInMap("AddTargetCount")]
        [Validation(Required=false)]
        public int? AddTargetCount { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("AllTargetCount")]
        [Validation(Required=false)]
        public int? AllTargetCount { get; set; }

        /// <summary>
        /// The condition by which the feature is applied. Valid values:
        /// 
        /// *   **image_repo**: the ID of the image repository
        /// </summary>
        [NameInMap("DelTargetCount")]
        [Validation(Required=false)]
        public int? DelTargetCount { get; set; }

        /// <summary>
        /// DescribeImageRepoList
        /// </summary>
        [NameInMap("ImageRepoList")]
        [Validation(Required=false)]
        public List<DescribeImageRepoListResponseBodyImageRepoList> ImageRepoList { get; set; }
        public class DescribeImageRepoListResponseBodyImageRepoList : TeaModel {
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageRepoListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageRepoListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// Queries the statistics and configurations of the feature that protects images.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The namespace to which the image repository belongs.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The name of the image repository.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The number of image repositories that are added to Security Center.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
