// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSaasInfoRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("SaasGroupCodes")]
        [Validation(Required=false)]
        public string SaasGroupCodes { get; set; }

        [NameInMap("SaasName")]
        [Validation(Required=false)]
        public string SaasName { get; set; }

    }

}
