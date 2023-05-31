// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAlarmMachineCountResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlarmMachineCountResponseBodyData Data { get; set; }
        public class GetAlarmMachineCountResponseBodyData : TeaModel {
            /// <summary>
            /// The number of servers on which alerts are generated.
            /// </summary>
            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public int? MachineCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
