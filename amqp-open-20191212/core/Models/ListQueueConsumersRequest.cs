// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueueConsumersRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

        [NameInMap("Queue")]
        [Validation(Required=false)]
        public string Queue { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("QueryCount")]
        [Validation(Required=false)]
        public int? QueryCount { get; set; }

    }

}
