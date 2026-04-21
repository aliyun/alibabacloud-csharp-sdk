// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketPortalDeployConfig : TeaModel {
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("saeConfig")]
        [Validation(Required=false)]
        public HiMarketPortalDeployConfigSaeConfig SaeConfig { get; set; }
        public class HiMarketPortalDeployConfigSaeConfig : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("oidcRoleName")]
            [Validation(Required=false)]
            public string OidcRoleName { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("replicas")]
            [Validation(Required=false)]
            public string Replicas { get; set; }

            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
