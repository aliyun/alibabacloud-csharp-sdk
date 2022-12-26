// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DeleteUserSayRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        [NameInMap("UserSayId")]
        [Validation(Required=false)]
        public long? UserSayId { get; set; }

    }

}
