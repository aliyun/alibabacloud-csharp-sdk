// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeClusterResourcePoolSchedulerTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CurrentSchedulerType")]
        [Validation(Required=false)]
        public string CurrentSchedulerType { get; set; }

        [NameInMap("SupportSchedulerType")]
        [Validation(Required=false)]
        public string SupportSchedulerType { get; set; }

        [NameInMap("DefaultSchedulerType")]
        [Validation(Required=false)]
        public string DefaultSchedulerType { get; set; }

    }

}
