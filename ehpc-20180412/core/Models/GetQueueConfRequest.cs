// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetQueueConfRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<GetQueueConfRequestQueues> Queues { get; set; }
        public class GetQueueConfRequestQueues : TeaModel {
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

        }

    }

}
