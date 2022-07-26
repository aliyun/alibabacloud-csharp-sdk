// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsResourceUsageRequest : TeaModel {
        [NameInMap("ExpiredEndTime")]
        [Validation(Required=false)]
        public string ExpiredEndTime { get; set; }

        [NameInMap("ExpiredStartTime")]
        [Validation(Required=false)]
        public string ExpiredStartTime { get; set; }

    }

}
