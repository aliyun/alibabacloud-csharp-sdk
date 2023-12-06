// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class PutEnvironmentTunnelRequest : TeaModel {
        [NameInMap("tunnelConfig")]
        [Validation(Required=false)]
        public PutEnvironmentTunnelRequestTunnelConfig TunnelConfig { get; set; }
        public class PutEnvironmentTunnelRequestTunnelConfig : TeaModel {
            [NameInMap("hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("sshPort")]
            [Validation(Required=false)]
            public int? SshPort { get; set; }

            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("tunnelType")]
        [Validation(Required=false)]
        public string TunnelType { get; set; }

    }

}
