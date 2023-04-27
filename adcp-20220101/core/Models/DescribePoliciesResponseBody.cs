// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribePoliciesResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribePoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribePoliciesResponseBodyPolicies : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Names")]
            [Validation(Required=false)]
            public List<string> Names { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
