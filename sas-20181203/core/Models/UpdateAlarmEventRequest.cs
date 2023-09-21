// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateAlarmEventRequest : TeaModel {
        [NameInMap("AlarmEventIdList")]
        [Validation(Required=false)]
        public List<long?> AlarmEventIdList { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

    }

}
