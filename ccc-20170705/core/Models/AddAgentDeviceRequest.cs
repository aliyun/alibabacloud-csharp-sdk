// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class AddAgentDeviceRequest : TeaModel {
        [NameInMap("BrowserVersion")]
        [Validation(Required=false)]
        public string BrowserVersion { get; set; }

        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        [NameInMap("ClientPort")]
        [Validation(Required=false)]
        public string ClientPort { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
