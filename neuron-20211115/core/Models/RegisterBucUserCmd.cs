// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class RegisterBucUserCmd : TeaModel {
        [NameInMap("enterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        [NameInMap("enterpriseName")]
        [Validation(Required=false)]
        public string EnterpriseName { get; set; }

    }

}
