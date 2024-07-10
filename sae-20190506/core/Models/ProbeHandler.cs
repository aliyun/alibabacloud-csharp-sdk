// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ProbeHandler : TeaModel {
        [NameInMap("HttpGet")]
        [Validation(Required=false)]
        public HTTPGetAction HttpGet { get; set; }

        [NameInMap("TcpSocket")]
        [Validation(Required=false)]
        public TCPSocketAction TcpSocket { get; set; }

    }

}
