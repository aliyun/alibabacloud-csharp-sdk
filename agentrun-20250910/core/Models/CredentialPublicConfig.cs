// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CredentialPublicConfig : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> AuthConfig { get; set; }

        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("headerKey")]
        [Validation(Required=false)]
        public string HeaderKey { get; set; }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("remoteConfig")]
        [Validation(Required=false)]
        public CredentialPublicConfigRemoteConfig RemoteConfig { get; set; }
        public class CredentialPublicConfigRemoteConfig : TeaModel {
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            [NameInMap("ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            [NameInMap("uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("users")]
        [Validation(Required=false)]
        public List<CredentialPublicConfigUsers> Users { get; set; }
        public class CredentialPublicConfigUsers : TeaModel {
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
