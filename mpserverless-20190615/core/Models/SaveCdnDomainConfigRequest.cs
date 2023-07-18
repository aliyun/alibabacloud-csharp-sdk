// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class SaveCdnDomainConfigRequest : TeaModel {
        [NameInMap("AuthConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        [NameInMap("CorsConfig")]
        [Validation(Required=false)]
        public string CorsConfig { get; set; }

        [NameInMap("IpConfig")]
        [Validation(Required=false)]
        public string IpConfig { get; set; }

        [NameInMap("RefererConfig")]
        [Validation(Required=false)]
        public string RefererConfig { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UaConfig")]
        [Validation(Required=false)]
        public string UaConfig { get; set; }

    }

}
