// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoTriggerRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        [NameInMap("TriggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        [NameInMap("TriggerUrl")]
        [Validation(Required=false)]
        public string TriggerUrl { get; set; }

        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        [NameInMap("TriggerTag")]
        [Validation(Required=false)]
        public string TriggerTag { get; set; }

    }

}
