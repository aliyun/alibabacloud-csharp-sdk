// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CountSpeechBroadcastHourRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("QueryDateTimeHour")]
        [Validation(Required=true)]
        public string QueryDateTimeHour { get; set; }

        [NameInMap("ShareTaskCode")]
        [Validation(Required=true)]
        public string ShareTaskCode { get; set; }

    }

}
