// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryPrevLimitNewResponseBody : TeaModel {
        [NameInMap("HourLimit")]
        [Validation(Required=false)]
        public long? HourLimit { get; set; }

        [NameInMap("IncreaseRate")]
        [Validation(Required=false)]
        public int? IncreaseRate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessRate")]
        [Validation(Required=false)]
        public int? SuccessRate { get; set; }

    }

}
