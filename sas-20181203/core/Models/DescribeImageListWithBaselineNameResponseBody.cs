// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListWithBaselineNameResponseBody : TeaModel {
        [NameInMap("ImageInfos")]
        [Validation(Required=false)]
        public List<DescribeImageListWithBaselineNameResponseBodyImageInfos> ImageInfos { get; set; }
        public class DescribeImageListWithBaselineNameResponseBodyImageInfos : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            [NameInMap("HighRiskImage")]
            [Validation(Required=false)]
            public int? HighRiskImage { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("ImageCreate")]
            [Validation(Required=false)]
            public long? ImageCreate { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public int? ImageSize { get; set; }

            [NameInMap("ImageUpdate")]
            [Validation(Required=false)]
            public long? ImageUpdate { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("LowRiskImage")]
            [Validation(Required=false)]
            public int? LowRiskImage { get; set; }

            [NameInMap("MiddleRiskImage")]
            [Validation(Required=false)]
            public int? MiddleRiskImage { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("NoRiskImage")]
            [Validation(Required=false)]
            public int? NoRiskImage { get; set; }

            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("TotalItemCount")]
            [Validation(Required=false)]
            public int? TotalItemCount { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageListWithBaselineNameResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageListWithBaselineNameResponseBodyPageInfo : TeaModel {
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
