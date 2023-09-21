// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCanFixVulListRequest : TeaModel {
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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

        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
