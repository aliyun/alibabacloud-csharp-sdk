// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyUserEntitlementRequest : TeaModel {
        [NameInMap("AuthorizeDesktopId")]
        [Validation(Required=false)]
        public List<string> AuthorizeDesktopId { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RevokeDesktopId")]
        [Validation(Required=false)]
        public List<string> RevokeDesktopId { get; set; }

    }

}
