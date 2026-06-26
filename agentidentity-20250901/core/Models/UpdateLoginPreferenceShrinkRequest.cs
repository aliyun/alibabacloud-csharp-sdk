// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateLoginPreferenceShrinkRequest : TeaModel {
        [NameInMap("LoginPreference")]
        [Validation(Required=false)]
        public string LoginPreferenceShrink { get; set; }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
