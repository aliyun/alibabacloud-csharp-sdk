// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListPidDataProcessResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("PidDataProcessList")]
        [Validation(Required=true)]
        public List<ListPidDataProcessResponsePidDataProcessList> PidDataProcessList { get; set; }
        public class ListPidDataProcessResponsePidDataProcessList : TeaModel {
            [NameInMap("PidDataProcessId")]
            [Validation(Required=true)]
            public string PidDataProcessId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public string StartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public string EndTime { get; set; }

            [NameInMap("PidDataProcessStatus")]
            [Validation(Required=true)]
            public string PidDataProcessStatus { get; set; }

            [NameInMap("PidDataProcessProgress")]
            [Validation(Required=true)]
            public string PidDataProcessProgress { get; set; }

        }

    }

}
