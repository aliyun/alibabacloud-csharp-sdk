// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeAppInfoResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("AppInfoList")]
        [Validation(Required=false)]
        public List<DescribeAppInfoResponseBodyAppInfoList> AppInfoList { get; set; }
        public class DescribeAppInfoResponseBodyAppInfoList : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            [NameInMap("DebugPackageInfo")]
            [Validation(Required=false)]
            public DescribeAppInfoResponseBodyAppInfoListDebugPackageInfo DebugPackageInfo { get; set; }
            public class DescribeAppInfoResponseBodyAppInfoListDebugPackageInfo : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }
            };

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("PackageInfo")]
            [Validation(Required=false)]
            public DescribeAppInfoResponseBodyAppInfoListPackageInfo PackageInfo { get; set; }
            public class DescribeAppInfoResponseBodyAppInfoListPackageInfo : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }
            };

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
