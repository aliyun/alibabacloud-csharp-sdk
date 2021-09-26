// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListSystemAlarmsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public List<ListSystemAlarmsResponseBodyAlarms> Alarms { get; set; }
        public class ListSystemAlarmsResponseBodyAlarms : TeaModel {
            [NameInMap("ReadMark")]
            [Validation(Required=false)]
            public int? ReadMark { get; set; }

            [NameInMap("AlarmDetail")]
            [Validation(Required=false)]
            public string AlarmDetail { get; set; }

            [NameInMap("AlarmType")]
            [Validation(Required=false)]
            public string AlarmType { get; set; }

            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public int? AlarmId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

    }

}
