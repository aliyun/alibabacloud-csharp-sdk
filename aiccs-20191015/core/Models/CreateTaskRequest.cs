// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateTaskRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("RobotId")]
        [Validation(Required=false)]
        public string RobotId { get; set; }

        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        [NameInMap("CallString")]
        [Validation(Required=false)]
        public string CallString { get; set; }

        [NameInMap("CallStringType")]
        [Validation(Required=false)]
        public string CallStringType { get; set; }

        [NameInMap("RetryFlag")]
        [Validation(Required=false)]
        public int? RetryFlag { get; set; }

        [NameInMap("RetryCount")]
        [Validation(Required=false)]
        public int? RetryCount { get; set; }

        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        [NameInMap("RetryStatusCode")]
        [Validation(Required=false)]
        public string RetryStatusCode { get; set; }

        [NameInMap("StartNow")]
        [Validation(Required=false)]
        public bool? StartNow { get; set; }

        [NameInMap("WorkTimeList")]
        [Validation(Required=false)]
        public string WorkTimeList { get; set; }

        [NameInMap("WorkDay")]
        [Validation(Required=false)]
        public string WorkDay { get; set; }

        [NameInMap("SeatCount")]
        [Validation(Required=false)]
        public string SeatCount { get; set; }

    }

}
