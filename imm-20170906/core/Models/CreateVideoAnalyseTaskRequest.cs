// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CreateVideoAnalyseTaskRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("VideoUri")]
        [Validation(Required=false)]
        public string VideoUri { get; set; }

        [NameInMap("GrabType")]
        [Validation(Required=false)]
        public string GrabType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("SaveType")]
        [Validation(Required=false)]
        public bool? SaveType { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("TgtUri")]
        [Validation(Required=false)]
        public string TgtUri { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

    }

}
