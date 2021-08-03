// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopPolicysResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DescribeDesktopPolicys")]
        [Validation(Required=false)]
        public List<DescribeDesktopPolicysResponseBodyDescribeDesktopPolicys> DescribeDesktopPolicys { get; set; }
        public class DescribeDesktopPolicysResponseBodyDescribeDesktopPolicys : TeaModel {
            [NameInMap("UsbRedirect")]
            [Validation(Required=false)]
            public string UsbRedirect { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public string Watermark { get; set; }

            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

        }

    }

}
