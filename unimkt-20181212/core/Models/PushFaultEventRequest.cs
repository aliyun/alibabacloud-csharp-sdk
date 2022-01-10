// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class PushFaultEventRequest : TeaModel {
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("DeviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        [NameInMap("FaultComment")]
        [Validation(Required=false)]
        public string FaultComment { get; set; }

        [NameInMap("FaultType")]
        [Validation(Required=false)]
        public string FaultType { get; set; }

        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
