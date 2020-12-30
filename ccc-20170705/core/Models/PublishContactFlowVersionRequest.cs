// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class PublishContactFlowVersionRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ContactFlowVersionId")]
        [Validation(Required=false)]
        public string ContactFlowVersionId { get; set; }

        [NameInMap("UseTianGong")]
        [Validation(Required=false)]
        public bool? UseTianGong { get; set; }

    }

}
