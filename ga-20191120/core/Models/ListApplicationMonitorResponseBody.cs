// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListApplicationMonitorResponseBody : TeaModel {
        [NameInMap("ApplicationMonitors")]
        [Validation(Required=false)]
        public List<ListApplicationMonitorResponseBodyApplicationMonitors> ApplicationMonitors { get; set; }
        public class ListApplicationMonitorResponseBodyApplicationMonitors : TeaModel {
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("DetectThreshold")]
            [Validation(Required=false)]
            public int? DetectThreshold { get; set; }

            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            [NameInMap("OptionsJson")]
            [Validation(Required=false)]
            public string OptionsJson { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

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
