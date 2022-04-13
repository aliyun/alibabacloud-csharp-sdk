// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageGroupedVulListRequest : TeaModel {
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("CveId")]
        [Validation(Required=false)]
        public string CveId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        [NameInMap("ImageLayer")]
        [Validation(Required=false)]
        public string ImageLayer { get; set; }

        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        [NameInMap("IsLatest")]
        [Validation(Required=false)]
        public int? IsLatest { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public long? PatchId { get; set; }

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

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
