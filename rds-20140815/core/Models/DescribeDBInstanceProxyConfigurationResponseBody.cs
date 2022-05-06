// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceProxyConfigurationResponseBody : TeaModel {
        [NameInMap("AttacksProtectionConfiguration")]
        [Validation(Required=false)]
        public string AttacksProtectionConfiguration { get; set; }

        [NameInMap("PersistentConnectionsConfiguration")]
        [Validation(Required=false)]
        public string PersistentConnectionsConfiguration { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TransparentSwitchConfiguration")]
        [Validation(Required=false)]
        public string TransparentSwitchConfiguration { get; set; }

    }

}
