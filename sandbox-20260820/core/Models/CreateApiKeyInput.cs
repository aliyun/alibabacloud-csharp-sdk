// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateApiKeyInput : TeaModel {
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("ipBlacklist")]
        [Validation(Required=false)]
        public List<IPConfig> IpBlacklist { get; set; }

        [NameInMap("ipWhitelist")]
        [Validation(Required=false)]
        public List<IPConfig> IpWhitelist { get; set; }

        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
