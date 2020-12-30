// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeClusterPolicyResponseBody : TeaModel {
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("UdpPort")]
        [Validation(Required=false)]
        public string UdpPort { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        [NameInMap("UsbRedirect")]
        [Validation(Required=false)]
        public string UsbRedirect { get; set; }

        [NameInMap("TaskFinished")]
        [Validation(Required=false)]
        public bool? TaskFinished { get; set; }

        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public string DomainList { get; set; }

        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string Watermark { get; set; }

    }

}
