// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeClusterPolicyResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("UsbRedirect")]
        [Validation(Required=true)]
        public string UsbRedirect { get; set; }

        [NameInMap("Watermark")]
        [Validation(Required=true)]
        public string Watermark { get; set; }

        [NameInMap("LocalDrive")]
        [Validation(Required=true)]
        public string LocalDrive { get; set; }

        [NameInMap("Clipboard")]
        [Validation(Required=true)]
        public string Clipboard { get; set; }

        [NameInMap("UdpPort")]
        [Validation(Required=true)]
        public string UdpPort { get; set; }

        [NameInMap("DomainList")]
        [Validation(Required=true)]
        public string DomainList { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=true)]
        public string TaskId { get; set; }

        [NameInMap("TaskFinished")]
        [Validation(Required=true)]
        public bool? TaskFinished { get; set; }

    }

}
