// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ResetUserRequest : TeaModel {
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("Bizid")]
        [Validation(Required=false)]
        public string Bizid { get; set; }

        [NameInMap("Operation")]
        [Validation(Required=false)]
        public int? Operation { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
