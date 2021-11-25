// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CreateVideoCompressTaskRequest : TeaModel {
        [NameInMap("CustomMessage")]
        [Validation(Required=false)]
        public string CustomMessage { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("TargetList")]
        [Validation(Required=false)]
        public string TargetList { get; set; }

        [NameInMap("TargetSegment")]
        [Validation(Required=false)]
        public string TargetSegment { get; set; }

        [NameInMap("TargetSubtitle")]
        [Validation(Required=false)]
        public string TargetSubtitle { get; set; }

        [NameInMap("VideoUri")]
        [Validation(Required=false)]
        public string VideoUri { get; set; }

    }

}
