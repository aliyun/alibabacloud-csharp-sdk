// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class MountGWApiGroupAuthUserRequest : TeaModel {
        [NameInMap("ApiGroupId")]
        [Validation(Required=false)]
        public string ApiGroupId { get; set; }

        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public string AuthStatus { get; set; }

        [NameInMap("AuthUserIdListRepeatList")]
        [Validation(Required=false)]
        public List<string> AuthUserIdListRepeatList { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
