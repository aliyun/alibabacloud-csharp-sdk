// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListSchedulerInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchedulerInstances")]
        [Validation(Required=false)]
        public List<ListSchedulerInstancesResponseBodySchedulerInstances> SchedulerInstances { get; set; }
        public class ListSchedulerInstancesResponseBodySchedulerInstances : TeaModel {
            [NameInMap("BaseStrategy")]
            [Validation(Required=false)]
            public string BaseStrategy { get; set; }

            [NameInMap("Business")]
            [Validation(Required=false)]
            public string Business { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MaxConcurrency")]
            [Validation(Required=false)]
            public int? MaxConcurrency { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
