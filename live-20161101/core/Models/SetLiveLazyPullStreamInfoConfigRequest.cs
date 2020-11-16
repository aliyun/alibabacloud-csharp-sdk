// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveLazyPullStreamInfoConfigRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=true)]
        public string AppName { get; set; }

        [NameInMap("PullDomainName")]
        [Validation(Required=true)]
        public string PullDomainName { get; set; }

        [NameInMap("PullAppName")]
        [Validation(Required=false)]
        public string PullAppName { get; set; }

        [NameInMap("PullProtocol")]
        [Validation(Required=true)]
        public string PullProtocol { get; set; }

        [NameInMap("PullAuthType")]
        [Validation(Required=false)]
        public string PullAuthType { get; set; }

        [NameInMap("PullAuthKey")]
        [Validation(Required=false)]
        public string PullAuthKey { get; set; }

        [NameInMap("PullArgs")]
        [Validation(Required=false)]
        public string PullArgs { get; set; }

        [NameInMap("LiveapiRequestFrom")]
        [Validation(Required=false)]
        public string LiveapiRequestFrom { get; set; }

    }

}
