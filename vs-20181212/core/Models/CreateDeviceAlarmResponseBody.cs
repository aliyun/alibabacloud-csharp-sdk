// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateDeviceAlarmResponseBody : TeaModel {
        [NameInMap("AlarmDelay")]
        [Validation(Required=false)]
        public long? AlarmDelay { get; set; }

        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public string AlarmId { get; set; }

        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
