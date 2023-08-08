// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyDetailsResponseBody : TeaModel {
        /// <summary>
        /// The action of the policy. Valid values:
        /// 
        /// *   `enforce`: blocks deployments that match the policy.
        /// *   `inform`: generates alerts for deployments that match the policy.
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// The type of the policy.
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The description of the policy.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether the policy is deleted. Valid values:
        /// 
        /// *   0: The policy is not deleted.
        /// *   1: The policy is deleted.
        /// </summary>
        [NameInMap("is_deleted")]
        [Validation(Required=false)]
        public int? IsDeleted { get; set; }

        /// <summary>
        /// The name of the policy that is returned.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether parameters are required. Valid values:
        /// 
        /// *   0: Parameters are required.
        /// *   1: Parameters are optional.
        /// </summary>
        [NameInMap("no_config")]
        [Validation(Required=false)]
        public int? NoConfig { get; set; }

        /// <summary>
        /// The severity level of the policy. Valid values:
        /// 
        /// *   `high`
        /// *   `medium`
        /// *   `low`
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// The content of the policy.
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
