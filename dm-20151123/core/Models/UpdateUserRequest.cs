// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class UpdateUserRequest : TeaModel {
        [NameInMap("User")]
        [Validation(Required=false)]
        public UpdateUserRequestUser User { get; set; }
        public class UpdateUserRequestUser : TeaModel {
            [NameInMap("EnableEventbridge")]
            [Validation(Required=false)]
            public bool? EnableEventbridge { get; set; }

        }

    }

}
