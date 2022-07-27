// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpgradeBackupClientsRequest : TeaModel {
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ClientIds { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstanceIds { get; set; }

    }

}
