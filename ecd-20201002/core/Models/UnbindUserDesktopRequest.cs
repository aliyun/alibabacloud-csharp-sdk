// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class UnbindUserDesktopRequest : TeaModel {
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("UserDesktopId")]
        [Validation(Required=false)]
        public string UserDesktopId { get; set; }

    }

}
