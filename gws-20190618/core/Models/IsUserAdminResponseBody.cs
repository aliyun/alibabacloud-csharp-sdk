// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class IsUserAdminResponseBody : TeaModel {
        [NameInMap("IsAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IsAllow")]
        [Validation(Required=false)]
        public bool? IsAllow { get; set; }

    }

}
