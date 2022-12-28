// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageRiskResponseBody : TeaModel {
        [NameInMap("ImageRiskList")]
        [Validation(Required=false)]
        public List<ListImageRiskResponseBodyImageRiskList> ImageRiskList { get; set; }
        public class ListImageRiskResponseBodyImageRiskList : TeaModel {
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            [NameInMap("EndPointList")]
            [Validation(Required=false)]
            public List<ListImageRiskResponseBodyImageRiskListEndPointList> EndPointList { get; set; }
            public class ListImageRiskResponseBodyImageRiskListEndPointList : TeaModel {
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public List<string> Domains { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("ImageAccessType")]
            [Validation(Required=false)]
            public string ImageAccessType { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("InternetURLs")]
            [Validation(Required=false)]
            public string InternetURLs { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

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

            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("TagImmutable")]
            [Validation(Required=false)]
            public int? TagImmutable { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("VpcURLs")]
            [Validation(Required=false)]
            public string VpcURLs { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListImageRiskResponseBodyPageInfo PageInfo { get; set; }
        public class ListImageRiskResponseBodyPageInfo : TeaModel {
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
