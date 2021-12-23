// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeResourceQuotaResponseBody : TeaModel {
        [NameInMap("CloudStorageDataSizeQuota")]
        [Validation(Required=false)]
        public double? CloudStorageDataSizeQuota { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StaticWebDataSizeQuota")]
        [Validation(Required=false)]
        public double? StaticWebDataSizeQuota { get; set; }

    }

}
