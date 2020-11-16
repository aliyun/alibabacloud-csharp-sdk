// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopPolicysResponse : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DescribeDesktopPolicys")]
        [Validation(Required=true)]
        public List<DescribeDesktopPolicysResponseDescribeDesktopPolicys> DescribeDesktopPolicys { get; set; }
        public class DescribeDesktopPolicysResponseDescribeDesktopPolicys : TeaModel {
            [NameInMap("Clipboard")]
            [Validation(Required=true)]
            public string Clipboard { get; set; }

            [NameInMap("LocalDrive")]
            [Validation(Required=true)]
            public string LocalDrive { get; set; }

            [NameInMap("UsbRedirect")]
            [Validation(Required=true)]
            public string UsbRedirect { get; set; }

            [NameInMap("Watermark")]
            [Validation(Required=true)]
            public string Watermark { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=true)]
            public string DesktopId { get; set; }

        }

    }

}
