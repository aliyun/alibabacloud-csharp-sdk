// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsWarnCreateRequest : TeaModel {
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public string Contacts { get; set; }

        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public string DelayTime { get; set; }

        [NameInMap("BlockTime")]
        [Validation(Required=false)]
        public string BlockTime { get; set; }

        [NameInMap("AlertTime")]
        [Validation(Required=false)]
        public string AlertTime { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
