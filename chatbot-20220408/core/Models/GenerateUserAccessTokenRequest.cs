// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GenerateUserAccessTokenRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        [NameInMap("ForeignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        [NameInMap("Nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
