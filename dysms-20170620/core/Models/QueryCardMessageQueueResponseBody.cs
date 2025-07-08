// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryCardMessageQueueResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryCardMessageQueueResponseBodyList> List { get; set; }
        public class QueryCardMessageQueueResponseBodyList : TeaModel {
            [NameInMap("IsCreated")]
            [Validation(Required=false)]
            public bool? IsCreated { get; set; }

            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("QueueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
