// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class Quota : TeaModel {
        [NameInMap("computeResource")]
        [Validation(Required=false)]
        public int? ComputeResource { get; set; }

        [NameInMap("docSize")]
        [Validation(Required=false)]
        public int? DocSize { get; set; }

        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
