// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMsTransparentProxyAppRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public string Nodes { get; set; }

        [NameInMap("SupportProtocols")]
        [Validation(Required=false)]
        public string SupportProtocols { get; set; }

    }

}
