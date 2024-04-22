// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribePolicyDetailsResponseBody : TeaModel {
        /// <summary>
        /// The policies.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public DescribePolicyDetailsResponseBodyPolicy Policy { get; set; }
        public class DescribePolicyDetailsResponseBodyPolicy : TeaModel {
            /// <summary>
            /// The action of the policy. Valid values:
            /// 
            /// *   enforce: blocks deployments that match the policy.
            /// *   inform: generates alerts for deployments that match the policy.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The type of the policy.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The time when the policy was created.
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The description of the policy.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether parameters are required. Valid values:
            /// 
            /// *   0: Parameters are required.
            /// *   1: Parameters are not required.
            /// </summary>
            [NameInMap("NoConfig")]
            [Validation(Required=false)]
            public int? NoConfig { get; set; }

            /// <summary>
            /// The severity level of the policy.
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// The content of the policy.
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// The time when the policy was last updated.
            /// </summary>
            [NameInMap("Updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
