// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class SetClusterPolicyRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=true)]
        public string ClusterId { get; set; }

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
        [Validation(Required=false)]
        public string UdpPort { get; set; }

        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public string DomainList { get; set; }

        [NameInMap("AsyncMode")]
        [Validation(Required=false)]
        public bool? AsyncMode { get; set; }

    }

}
