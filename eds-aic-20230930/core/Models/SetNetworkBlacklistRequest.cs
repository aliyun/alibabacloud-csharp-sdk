// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class SetNetworkBlacklistRequest : TeaModel {
        [NameInMap("DomainBlacklist")]
        [Validation(Required=false)]
        public List<string> DomainBlacklist { get; set; }

        [NameInMap("IpBlacklist")]
        [Validation(Required=false)]
        public List<string> IpBlacklist { get; set; }

    }

}
