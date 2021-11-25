// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CreateVideoAbstractTaskRequest : TeaModel {
        [NameInMap("AbstractLength")]
        [Validation(Required=false)]
        public int? AbstractLength { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("TargetClipsUri")]
        [Validation(Required=false)]
        public string TargetClipsUri { get; set; }

        [NameInMap("TargetVideoUri")]
        [Validation(Required=false)]
        public string TargetVideoUri { get; set; }

        [NameInMap("VideoUri")]
        [Validation(Required=false)]
        public string VideoUri { get; set; }

    }

}
