// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDomainQuotaResponseBody : TeaModel {
        [NameInMap("size_quota")]
        [Validation(Required=false)]
        public long? SizeQuota { get; set; }

        [NameInMap("size_used")]
        [Validation(Required=false)]
        public long? SizeUsed { get; set; }

        [NameInMap("user_count_quota")]
        [Validation(Required=false)]
        public long? UserCountQuota { get; set; }

        [NameInMap("user_count_used")]
        [Validation(Required=false)]
        public long? UserCountUsed { get; set; }

    }

}
