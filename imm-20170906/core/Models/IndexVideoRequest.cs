// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class IndexVideoRequest : TeaModel {
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("RemarksA")]
        [Validation(Required=false)]
        public string RemarksA { get; set; }

        [NameInMap("RemarksB")]
        [Validation(Required=false)]
        public string RemarksB { get; set; }

        [NameInMap("RemarksC")]
        [Validation(Required=false)]
        public string RemarksC { get; set; }

        [NameInMap("RemarksD")]
        [Validation(Required=false)]
        public string RemarksD { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("TgtUri")]
        [Validation(Required=false)]
        public string TgtUri { get; set; }

        [NameInMap("VideoUri")]
        [Validation(Required=false)]
        public string VideoUri { get; set; }

    }

}
