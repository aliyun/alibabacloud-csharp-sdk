// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetQueueInputStatisticInfoResponseBody : TeaModel {
        [NameInMap("QueueInputList")]
        [Validation(Required=false)]
        public GetQueueInputStatisticInfoResponseBodyQueueInputList QueueInputList { get; set; }
        public class GetQueueInputStatisticInfoResponseBodyQueueInputList : TeaModel {
            [NameInMap("ClusterStatQueueInput")]
            [Validation(Required=false)]
            public List<GetQueueInputStatisticInfoResponseBodyQueueInputListClusterStatQueueInput> ClusterStatQueueInput { get; set; }
            public class GetQueueInputStatisticInfoResponseBodyQueueInputListClusterStatQueueInput : TeaModel {
                public long? BytesInput { get; set; }
                public string Queue { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
