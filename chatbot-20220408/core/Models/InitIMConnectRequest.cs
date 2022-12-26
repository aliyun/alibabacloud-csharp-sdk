// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class InitIMConnectRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("UserAccessToken")]
        [Validation(Required=false)]
        public string UserAccessToken { get; set; }

    }

}
