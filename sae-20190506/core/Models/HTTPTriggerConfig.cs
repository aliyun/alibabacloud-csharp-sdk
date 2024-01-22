// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class HTTPTriggerConfig : TeaModel {
        [NameInMap("aclConfig")]
        [Validation(Required=false)]
        public AclConfig AclConfig { get; set; }

        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public object AuthConfig { get; set; }

        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("disableURLInternet")]
        [Validation(Required=false)]
        public bool? DisableURLInternet { get; set; }

        [NameInMap("safeMode")]
        [Validation(Required=false)]
        public bool? SafeMode { get; set; }

    }

}
