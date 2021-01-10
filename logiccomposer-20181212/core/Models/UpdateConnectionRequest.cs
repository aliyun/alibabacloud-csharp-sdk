// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class UpdateConnectionRequest : TeaModel {
        [NameInMap("Connector")]
        [Validation(Required=false)]
        public string Connector { get; set; }

        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        [NameInMap("ConnectionContent")]
        [Validation(Required=false)]
        public string ConnectionContent { get; set; }

        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

    }

}
