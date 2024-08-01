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
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The ID of the rule in the account group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The resources that you want to re-evaluate.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<RevertAggregateEvaluationResultsRequestResources> Resources { get; set; }
        public class RevertAggregateEvaluationResultsRequestResources : TeaModel {
            /// <summary>
            /// The ID of the region in which your resources reside.
            /// 
            /// For more information about how to obtain the ID of the region in which your resources reside, see [ListAggregateDiscoveredResources](https://help.aliyun.com/document_detail/265983.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource belongs.
            /// 
            /// >  You must specify the ID of the current management account or a member in the account group of the management account.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceAccountId")]
            [Validation(Required=false)]
            public long? ResourceAccountId { get; set; }

            /// <summary>
            /// The resource ID.
            /// 
            /// For more information about how to obtain the ID of a resource, see [ListAggregateDiscoveredResources](https://help.aliyun.com/document_detail/265983.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource.
            /// 
            /// For more information about how to obtain the type of a resource, see [ListAggregateDiscoveredResources](https://help.aliyun.com/document_detail/265983.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
