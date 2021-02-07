// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetUserSsoSettingsRequest : TeaModel {
        [NameInMap("MetadataDocument")]
        [Validation(Required=false)]
        public string MetadataDocument { get; set; }

        [NameInMap("SsoEnabled")]
        [Validation(Required=false)]
        public bool? SsoEnabled { get; set; }

        [NameInMap("AuxiliaryDomain")]
        [Validation(Required=false)]
        public string AuxiliaryDomain { get; set; }

        [NameInMap("AkProxySuffix")]
        [Validation(Required=false)]
        public string AkProxySuffix { get; set; }

    }

}
