// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAlarmMachineCountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlarmMachineCountResponseBodyData Data { get; set; }
        public class GetAlarmMachineCountResponseBodyData : TeaModel {
            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public int? MachineCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
