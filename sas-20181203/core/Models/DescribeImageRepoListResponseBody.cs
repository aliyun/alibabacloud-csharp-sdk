// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoListResponseBody : TeaModel {
        [NameInMap("AddTargetCount")]
        [Validation(Required=false)]
        public int? AddTargetCount { get; set; }

        [NameInMap("AllTargetCount")]
        [Validation(Required=false)]
        public int? AllTargetCount { get; set; }

        [NameInMap("DelTargetCount")]
        [Validation(Required=false)]
        public int? DelTargetCount { get; set; }

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

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageRepoListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageRepoListResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
