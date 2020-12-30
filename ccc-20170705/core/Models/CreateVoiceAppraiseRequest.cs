// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateVoiceAppraiseRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ContactFlowVersionId")]
        [Validation(Required=false)]
        public string ContactFlowVersionId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("IsAppraise")]
        [Validation(Required=false)]
        public bool? IsAppraise { get; set; }

    }

}
