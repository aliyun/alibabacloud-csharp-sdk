// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class DeleteVhostRequest : TeaModel {
        [NameInMap("ConsoleSessionId")]
        [Validation(Required=false)]
        public string ConsoleSessionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("VhostName")]
        [Validation(Required=false)]
        public string VhostName { get; set; }

        [NameInMap("VhostNames")]
        [Validation(Required=false)]
        public Dictionary<string, object> VhostNames { get; set; }

    }

}
