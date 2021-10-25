// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeGWSClusterPolicyResponseBody : TeaModel {
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsbRedirect")]
        [Validation(Required=false)]
        public string UsbRedirect { get; set; }

        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

    }

}
