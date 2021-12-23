// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class SaveAppAuthTokenRequest : TeaModel {
        [NameInMap("AppAuthToken")]
        [Validation(Required=false)]
        public string AppAuthToken { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("IsvAppId")]
        [Validation(Required=false)]
        public string IsvAppId { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
