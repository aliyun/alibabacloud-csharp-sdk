// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetOutAccountBindDetailRequest : TeaModel {
        [NameInMap("AccountDomain")]
        [Validation(Required=false)]
        public string AccountDomain { get; set; }

        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("OutAccountType")]
        [Validation(Required=false)]
        public string OutAccountType { get; set; }

    }

}
