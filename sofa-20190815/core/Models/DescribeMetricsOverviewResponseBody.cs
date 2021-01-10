// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeMetricsOverviewResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubscriptionNum")]
        [Validation(Required=false)]
        public long? SubscriptionNum { get; set; }

        [NameInMap("BacklogNum")]
        [Validation(Required=false)]
        public long? BacklogNum { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("TopicNum")]
        [Validation(Required=false)]
        public long? TopicNum { get; set; }

        [NameInMap("DlqNum")]
        [Validation(Required=false)]
        public long? DlqNum { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("GroupNum")]
        [Validation(Required=false)]
        public long? GroupNum { get; set; }

    }

}
