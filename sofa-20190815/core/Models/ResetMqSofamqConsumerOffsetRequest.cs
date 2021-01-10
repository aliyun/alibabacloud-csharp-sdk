// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ResetMqSofamqConsumerOffsetRequest : TeaModel {
        [NameInMap("Cell")]
        [Validation(Required=false)]
        public string Cell { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ResetTimestamp")]
        [Validation(Required=false)]
        public long? ResetTimestamp { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
