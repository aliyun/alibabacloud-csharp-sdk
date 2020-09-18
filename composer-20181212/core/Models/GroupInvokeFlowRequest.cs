// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GroupInvokeFlowRequest : TeaModel {
        [NameInMap("FlowId")]
        [Validation(Required=true)]
        public string FlowId { get; set; }

        [NameInMap("GroupKey")]
        [Validation(Required=true)]
        public string GroupKey { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public string Data { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=true)]
        public string ClientToken { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

    }

}
