// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class RevertAggregateEvaluationResultsRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The ID of the rule in the account group.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The resources that are to be reevaluated.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<RevertAggregateEvaluationResultsRequestResources> Resources { get; set; }
        public class RevertAggregateEvaluationResultsRequestResources : TeaModel {
            /// <summary>
            /// The ID of the region in which the resource resides.
            /// 
            /// For more information about how to obtain the ID of a region in which a resource resides, see [ListAggregateDiscoveredResources](~~265983~~).
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource belongs.
            /// 
            /// >  The value must be the ID of the current management account or the member account in the account group of the management account.
            /// </summary>
            [NameInMap("ResourceAccountId")]
            [Validation(Required=false)]
            public long? ResourceAccountId { get; set; }

            /// <summary>
            /// The ID of the resource.
            /// 
            /// For more information about how to obtain the ID of a resource, see [ListAggregateDiscoveredResources](~~265983~~).
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource.
            /// 
            /// For more information about how to obtain the type of a resource, see [ListAggregateDiscoveredResources](~~265983~~).
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
