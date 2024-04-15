// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class HTTPTriggerConfig : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("disableURLInternet")]
        [Validation(Required=false)]
        public bool? DisableURLInternet { get; set; }

        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

    }

}
