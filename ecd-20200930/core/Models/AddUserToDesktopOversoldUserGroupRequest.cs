// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class AddUserToDesktopOversoldUserGroupRequest : TeaModel {
        [NameInMap("AddUserAmount")]
        [Validation(Required=false)]
        public int? AddUserAmount { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("OversoldGroupId")]
        [Validation(Required=false)]
        public string OversoldGroupId { get; set; }

        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
