// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetQueueOutputStatisticInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("QueueOutputList")]
        [Validation(Required=false)]
        public GetQueueOutputStatisticInfoResponseBodyQueueOutputList QueueOutputList { get; set; }
        public class GetQueueOutputStatisticInfoResponseBodyQueueOutputList : TeaModel {
            [NameInMap("ClusterStatQueueOutput")]
            [Validation(Required=false)]
            public List<GetQueueOutputStatisticInfoResponseBodyQueueOutputListClusterStatQueueOutput> ClusterStatQueueOutput { get; set; }
            public class GetQueueOutputStatisticInfoResponseBodyQueueOutputListClusterStatQueueOutput : TeaModel {
                public string Queue { get; set; }
                public long? BytesOutput { get; set; }
            }
        };

    }

}
