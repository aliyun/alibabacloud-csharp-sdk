// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVulListResponseBody : TeaModel {
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
        public List<DescribeVulListResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeVulListResponseBodyVulRecords : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("ExtendContentJson")]
            [Validation(Required=false)]
            public DescribeVulListResponseBodyVulRecordsExtendContentJson ExtendContentJson { get; set; }
            public class DescribeVulListResponseBodyVulRecordsExtendContentJson : TeaModel {
                [NameInMap("RpmEntityList")]
                [Validation(Required=false)]
                public List<DescribeVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList> RpmEntityList { get; set; }
                public class DescribeVulListResponseBodyVulRecordsExtendContentJsonRpmEntityList : TeaModel {
                    public string FullVersion { get; set; }
                    public string MatchDetail { get; set; }
                    public string Name { get; set; }
                    public string Path { get; set; }
                    public string UpdateCmd { get; set; }
                }
            };

            [NameInMap("FirstTs")]
            [Validation(Required=false)]
            public long? FirstTs { get; set; }

            [NameInMap("LastTs")]
            [Validation(Required=false)]
            public long? LastTs { get; set; }

            [NameInMap("ModifyTs")]
            [Validation(Required=false)]
            public long? ModifyTs { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Necessity")]
            [Validation(Required=false)]
            public string Necessity { get; set; }

            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            [NameInMap("Related")]
            [Validation(Required=false)]
            public string Related { get; set; }

            [NameInMap("RepairTs")]
            [Validation(Required=false)]
            public long? RepairTs { get; set; }

            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
