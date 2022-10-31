// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveLazyPullStreamInfoConfigRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PullAppName")]
        [Validation(Required=false)]
        public string PullAppName { get; set; }

        [NameInMap("PullDomainName")]
        [Validation(Required=false)]
        public string PullDomainName { get; set; }

        [NameInMap("PullProtocol")]
        [Validation(Required=false)]
        public string PullProtocol { get; set; }

    }

}
