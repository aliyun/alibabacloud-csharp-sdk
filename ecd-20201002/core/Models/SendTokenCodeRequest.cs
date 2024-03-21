// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class SendTokenCodeRequest : TeaModel {
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TokenCode")]
        [Validation(Required=false)]
        public string TokenCode { get; set; }

    }

}
