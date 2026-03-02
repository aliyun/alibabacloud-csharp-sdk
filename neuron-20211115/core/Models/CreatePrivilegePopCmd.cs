// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class CreatePrivilegePopCmd : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("actions")]
        [Validation(Required=false)]
        public string Actions { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("roleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

    }

}
