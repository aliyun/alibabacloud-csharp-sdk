// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class RevertEvaluationResultsRequest : TeaModel {
        /// <summary>
        /// The ID of the rule.
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListConfigRules](~~169607~~).
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The resources that are to be reevaluated.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<RevertEvaluationResultsRequestResources> Resources { get; set; }
        public class RevertEvaluationResultsRequestResources : TeaModel {
            /// <summary>
            /// The ID of the region in which the resource resides.
            /// 
            /// For more information about how to obtain the ID of the region in which a resource resides, see [ListDiscoveredResources](~~169620~~).
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource belongs.
            /// </summary>
            [NameInMap("ResourceAccountId")]
            [Validation(Required=false)]
            public long? ResourceAccountId { get; set; }

            /// <summary>
            /// The ID of the resource.
            /// 
            /// For more information about how to obtain the ID of a resource, see [ListDiscoveredResources](~~169620~~).
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource.
            /// 
            /// For more information about how to obtain the type of a resource, see [ListDiscoveredResources](~~169620~~).
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
