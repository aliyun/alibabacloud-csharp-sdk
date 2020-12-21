// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class IsUserAdminResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("IsAdmin")]
        [Validation(Required=true)]
        public bool? IsAdmin { get; set; }

        [NameInMap("IsAllow")]
        [Validation(Required=true)]
        public bool? IsAllow { get; set; }

    }

}
