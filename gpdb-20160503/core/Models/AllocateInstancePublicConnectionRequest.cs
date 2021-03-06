// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class AllocateInstancePublicConnectionRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=true)]
        public string DBInstanceId { get; set; }

        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=true)]
        public string ConnectionStringPrefix { get; set; }

        [NameInMap("Port")]
        [Validation(Required=true)]
        public string Port { get; set; }

    }

}
