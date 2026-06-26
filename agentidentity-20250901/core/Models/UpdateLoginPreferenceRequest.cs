// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateLoginPreferenceRequest : TeaModel {
        [NameInMap("LoginPreference")]
        [Validation(Required=false)]
        public UpdateLoginPreferenceRequestLoginPreference LoginPreference { get; set; }
        public class UpdateLoginPreferenceRequestLoginPreference : TeaModel {
            [NameInMap("EnablePasswordLogin")]
            [Validation(Required=false)]
            public bool? EnablePasswordLogin { get; set; }

        }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
