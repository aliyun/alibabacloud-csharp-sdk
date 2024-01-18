// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class ListEmailVerificationRequest : TeaModel {
        [NameInMap("BeginCreateTime")]
        [Validation(Required=false)]
        public long? BeginCreateTime { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        [NameInMap("VerificationStatus")]
        [Validation(Required=false)]
        public int? VerificationStatus { get; set; }

    }

}
