// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class NASMountConfig : TeaModel {
        [NameInMap("enableTLS")]
        [Validation(Required=false)]
        public bool? EnableTLS { get; set; }

        [NameInMap("mountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        [NameInMap("serverAddr")]
        [Validation(Required=false)]
        public string ServerAddr { get; set; }

    }

}
