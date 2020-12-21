// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class CreateUserGroupRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IsvSubId")]
        [Validation(Required=false)]
        public string IsvSubId { get; set; }

        [NameInMap("UserGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

        [NameInMap("ParentUserGroupId")]
        [Validation(Required=false)]
        public long ParentUserGroupId { get; set; }

    }

}
