// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeAppInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("AppInfoList")]
        [Validation(Required=true)]
        public List<DescribeAppInfoResponseAppInfoList> AppInfoList { get; set; }
        public class DescribeAppInfoResponseAppInfoList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=true)]
            public long Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("PackageName")]
            [Validation(Required=true)]
            public string PackageName { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=true)]
            public string Icon { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=true)]
            public string StartDate { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=true)]
            public string EndDate { get; set; }

            [NameInMap("Type")]
            [Validation(Required=true)]
            public int? Type { get; set; }

            [NameInMap("PackageInfo")]
            [Validation(Required=true)]
            public DescribeAppInfoResponseAppInfoListPackageInfo PackageInfo { get; set; }
            public class DescribeAppInfoResponseAppInfoListPackageInfo : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=true)]
                public string Version { get; set; }
            };

            [NameInMap("DebugPackageInfo")]
            [Validation(Required=true)]
            public DescribeAppInfoResponseAppInfoListDebugPackageInfo DebugPackageInfo { get; set; }
            public class DescribeAppInfoResponseAppInfoListDebugPackageInfo : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=true)]
                public string Version { get; set; }
            };

        }

    }

}
