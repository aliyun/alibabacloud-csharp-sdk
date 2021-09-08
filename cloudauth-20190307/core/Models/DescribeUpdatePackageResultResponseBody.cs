// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeUpdatePackageResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AppInfo")]
        [Validation(Required=false)]
        public DescribeUpdatePackageResultResponseBodyAppInfo AppInfo { get; set; }
        public class DescribeUpdatePackageResultResponseBodyAppInfo : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("PackageInfo")]
            [Validation(Required=false)]
            public DescribeUpdatePackageResultResponseBodyAppInfoPackageInfo PackageInfo { get; set; }
            public class DescribeUpdatePackageResultResponseBodyAppInfoPackageInfo : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
            [NameInMap("DebugPackageInfo")]
            [Validation(Required=false)]
            public DescribeUpdatePackageResultResponseBodyAppInfoDebugPackageInfo DebugPackageInfo { get; set; }
            public class DescribeUpdatePackageResultResponseBodyAppInfoDebugPackageInfo : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
        };

    }

}
