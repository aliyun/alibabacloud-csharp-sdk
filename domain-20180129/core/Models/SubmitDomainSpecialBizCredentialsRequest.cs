// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SubmitDomainSpecialBizCredentialsRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public long? BizId { get; set; }

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public string Credentials { get; set; }

        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
