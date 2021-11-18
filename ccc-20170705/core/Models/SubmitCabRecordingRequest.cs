// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class SubmitCabRecordingRequest : TeaModel {
        [NameInMap("EarlyMediaRecording")]
        [Validation(Required=false)]
        public string EarlyMediaRecording { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceOwnerId")]
        [Validation(Required=false)]
        public long? InstanceOwnerId { get; set; }

        [NameInMap("MergedRecording")]
        [Validation(Required=false)]
        public string MergedRecording { get; set; }

        [NameInMap("ResourceRecording")]
        [Validation(Required=false)]
        public string ResourceRecording { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
