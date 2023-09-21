// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotProbeUuidRequest : TeaModel {
        [NameInMap("ControlNodeId")]
        [Validation(Required=false)]
        public string ControlNodeId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ProbeType")]
        [Validation(Required=false)]
        public string ProbeType { get; set; }

    }

}
