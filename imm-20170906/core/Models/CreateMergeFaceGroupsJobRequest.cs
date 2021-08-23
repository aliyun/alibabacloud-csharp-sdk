// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CreateMergeFaceGroupsJobRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("GroupIdFrom")]
        [Validation(Required=false)]
        public string GroupIdFrom { get; set; }

        [NameInMap("GroupIdTo")]
        [Validation(Required=false)]
        public string GroupIdTo { get; set; }

        [NameInMap("CustomMessage")]
        [Validation(Required=false)]
        public string CustomMessage { get; set; }

    }

}
