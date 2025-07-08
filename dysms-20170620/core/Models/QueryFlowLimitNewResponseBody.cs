// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryFlowLimitNewResponseBody : TeaModel {
        [NameInMap("DailyLimit")]
        [Validation(Required=false)]
        public long? DailyLimit { get; set; }

        [NameInMap("HourLimit")]
        [Validation(Required=false)]
        public long? HourLimit { get; set; }

        [NameInMap("MinuteLimit")]
        [Validation(Required=false)]
        public long? MinuteLimit { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
