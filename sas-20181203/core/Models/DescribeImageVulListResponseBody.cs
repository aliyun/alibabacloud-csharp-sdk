// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageVulListResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VulRecords")]
        [Validation(Required=false)]
        public List<DescribeImageVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeImageVulListResponseBodyVulRecords : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("CanFix")]
            [Validation(Required=false)]
            public string CanFix { get; set; }

            [NameInMap("CanUpdate")]
            [Validation(Required=false)]
            public bool? CanUpdate { get; set; }

            [NameInMap("ExtendContentJson")]
            [Validation(Required=false)]
            public DescribeImageVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeImageVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }
                [NameInMap("OsRelease")]
                [Validation(Required=false)]
                public string OsRelease { get; set; }
                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeImageVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeImageVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    public string FullVersion { get; set; }
                    public string Layer { get; set; }
                    public string MatchDetail { get; set; }
                    public List<string> MatchList { get; set; }
                    public string Name { get; set; }
                    public string Path { get; set; }
                    public string UpdateCmd { get; set; }
                    public string Version { get; set; }
                }
            };

            [NameInMap("FirstTs")]
            [Validation(Required=false)]
            public long? FirstTs { get; set; }

            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            [NameInMap("LastTs")]
            [Validation(Required=false)]
            public long? LastTs { get; set; }

            [NameInMap("Layers")]
            [Validation(Required=false)]
            public List<string> Layers { get; set; }

            [NameInMap("ModifyTs")]
            [Validation(Required=false)]
            public long? ModifyTs { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            [NameInMap("PrimaryId")]
            [Validation(Required=false)]
            public long? PrimaryId { get; set; }

            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
