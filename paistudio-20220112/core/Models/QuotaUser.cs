// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaUser : TeaModel {
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public QuotaUserResources Resources { get; set; }
        public class QuotaUserResources : TeaModel {
            [NameInMap("Submitted")]
            [Validation(Required=false)]
            public ResourceAmount Submitted { get; set; }

            [NameInMap("Used")]
            [Validation(Required=false)]
            public ResourceAmount Used { get; set; }

        }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("WorkloadCount")]
        [Validation(Required=false)]
        public int? WorkloadCount { get; set; }

    }

}
