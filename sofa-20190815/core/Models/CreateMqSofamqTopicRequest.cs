// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateMqSofamqTopicRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public long? MessageType { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
