// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribePoliciesResponseBody : TeaModel {
        /// <summary>
        /// A list of policies.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribePoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribePoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The policy type.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The names of the policies of each policy type.
            /// </summary>
            [NameInMap("Names")]
            [Validation(Required=false)]
            public List<string> Names { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
