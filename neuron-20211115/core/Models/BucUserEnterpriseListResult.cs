// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class BucUserEnterpriseListResult : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<BucEnterprise> Data { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
