// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class InsertDevopsUserRequest : TeaModel {
        [NameInMap("UserPk")]
        [Validation(Required=false)]
        public string UserPk { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

    }

}
