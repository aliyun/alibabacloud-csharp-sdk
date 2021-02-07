// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetUserSsoSettingsResponseBody : TeaModel {
        [NameInMap("UserSsoSettings")]
        [Validation(Required=false)]
        public SetUserSsoSettingsResponseBodyUserSsoSettings UserSsoSettings { get; set; }
        public class SetUserSsoSettingsResponseBodyUserSsoSettings : TeaModel {
            [NameInMap("AuxiliaryDomain")]
            [Validation(Required=false)]
            public string AuxiliaryDomain { get; set; }
            [NameInMap("MetadataDocument")]
            [Validation(Required=false)]
            public string MetadataDocument { get; set; }
            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
