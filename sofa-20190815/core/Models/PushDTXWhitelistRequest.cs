// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class PushDTXWhitelistRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PushTargetRepeatList")]
        [Validation(Required=false)]
        public List<string> PushTargetRepeatList { get; set; }

        [NameInMap("RefId")]
        [Validation(Required=false)]
        public long? RefId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
