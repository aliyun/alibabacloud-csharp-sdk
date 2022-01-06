// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListApplicationMonitorDetectResultResponseBody : TeaModel {
        [NameInMap("ApplicationMonitorDetectResultList")]
        [Validation(Required=false)]
        public List<ListApplicationMonitorDetectResultResponseBodyApplicationMonitorDetectResultList> ApplicationMonitorDetectResultList { get; set; }
        public class ListApplicationMonitorDetectResultResponseBodyApplicationMonitorDetectResultList : TeaModel {
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("DiagStatus")]
            [Validation(Required=false)]
            public string DiagStatus { get; set; }

            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
