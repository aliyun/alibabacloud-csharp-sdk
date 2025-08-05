// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetDedicatedIpWarmUpDetailRequest : TeaModel {
        [NameInMap("DedicatedIp")]
        [Validation(Required=false)]
        public string DedicatedIp { get; set; }

        [NameInMap("EndDayMark")]
        [Validation(Required=false)]
        public long? EndDayMark { get; set; }

        [NameInMap("Esp")]
        [Validation(Required=false)]
        public string Esp { get; set; }

        [NameInMap("StartDayMark")]
        [Validation(Required=false)]
        public long? StartDayMark { get; set; }

    }

}
