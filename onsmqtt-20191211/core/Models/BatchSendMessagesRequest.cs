// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20191211.Models
{
    public class BatchSendMessagesRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<BatchSendMessagesRequestMessages> Messages { get; set; }
        public class BatchSendMessagesRequestMessages : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }

            [NameInMap("ReceiptId")]
            [Validation(Required=false)]
            public string ReceiptId { get; set; }

            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<string> Topics { get; set; }

        }

    }

}
