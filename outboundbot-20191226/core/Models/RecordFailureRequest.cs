// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class RecordFailureRequest : TeaModel {
        [NameInMap("ActualTime")]
        [Validation(Required=false)]
        public long? ActualTime { get; set; }

        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        [NameInMap("DispositionCode")]
        [Validation(Required=false)]
        public string DispositionCode { get; set; }

        [NameInMap("ExceptionCodes")]
        [Validation(Required=false)]
        public string ExceptionCodes { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
