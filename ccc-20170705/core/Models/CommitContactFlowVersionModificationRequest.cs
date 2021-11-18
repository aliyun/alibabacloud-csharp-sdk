// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CommitContactFlowVersionModificationRequest : TeaModel {
        [NameInMap("Canvas")]
        [Validation(Required=false)]
        public string Canvas { get; set; }

        [NameInMap("ContactFlowVersionId")]
        [Validation(Required=false)]
        public string ContactFlowVersionId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
