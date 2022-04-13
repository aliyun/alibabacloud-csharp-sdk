// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedMaliciousFilesRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("FuzzyMaliciousName")]
        [Validation(Required=false)]
        public string FuzzyMaliciousName { get; set; }

        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        [NameInMap("ImageLayer")]
        [Validation(Required=false)]
        public string ImageLayer { get; set; }

        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        [NameInMap("RepoRegionId")]
        [Validation(Required=false)]
        public string RepoRegionId { get; set; }

    }

}
