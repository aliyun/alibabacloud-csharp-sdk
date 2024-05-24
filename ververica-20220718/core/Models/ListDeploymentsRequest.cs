// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListDeploymentsRequest : TeaModel {
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        [NameInMap("labelKey")]
        [Validation(Required=false)]
        public string LabelKey { get; set; }

        [NameInMap("labelValueArray")]
        [Validation(Required=false)]
        public string LabelValueArray { get; set; }

        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
