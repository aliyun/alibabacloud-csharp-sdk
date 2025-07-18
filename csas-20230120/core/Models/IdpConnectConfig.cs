// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpConnectConfig : TeaModel {
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        [NameInMap("UseConnector")]
        [Validation(Required=false)]
        public bool? UseConnector { get; set; }

    }

}
