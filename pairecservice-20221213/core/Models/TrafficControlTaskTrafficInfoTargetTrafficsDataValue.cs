// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class TrafficControlTaskTrafficInfoTargetTrafficsDataValue : TeaModel {
        [NameInMap("Traffic")]
        [Validation(Required=false)]
        public double? Traffic { get; set; }

        [NameInMap("RecordTime")]
        [Validation(Required=false)]
        public long? RecordTime { get; set; }

    }

}
