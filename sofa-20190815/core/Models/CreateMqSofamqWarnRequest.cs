// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateMqSofamqWarnRequest : TeaModel {
        [NameInMap("AlertTime")]
        [Validation(Required=false)]
        public string AlertTime { get; set; }

        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public string Contacts { get; set; }

        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public long? DelayTime { get; set; }

        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public long? Frequency { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
