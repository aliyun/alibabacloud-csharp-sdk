// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeUpdatePackageResultResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("AppInfo")]
        [Validation(Required=true)]
        public DescribeUpdatePackageResultResponseAppInfo AppInfo { get; set; }
        public class DescribeUpdatePackageResultResponseAppInfo : TeaModel {
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
            public DescribeUpdatePackageResultResponseAppInfoPackageInfo PackageInfo { get; set; }
            public class DescribeUpdatePackageResultResponseAppInfoPackageInfo : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=true)]
                public string Version { get; set; }

            }
            [NameInMap("DebugPackageInfo")]
            [Validation(Required=true)]
            public DescribeUpdatePackageResultResponseAppInfoDebugPackageInfo DebugPackageInfo { get; set; }
            public class DescribeUpdatePackageResultResponseAppInfoDebugPackageInfo : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=true)]
                public string Version { get; set; }

            }
        };

    }

}
