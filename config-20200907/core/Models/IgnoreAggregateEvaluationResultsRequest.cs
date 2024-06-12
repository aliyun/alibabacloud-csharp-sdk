// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class IgnoreAggregateEvaluationResultsRequest : TeaModel {
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
        /// The ID of the rule.
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListAggregateConfigRules](https://help.aliyun.com/document_detail/264148.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The date from which the system automatically re-evaluates the ignored incompliant resources.
        /// 
        /// >  If you leave this parameter empty, the system does not automatically re-evaluate the ignored incompliant resources. You must manually re-evaluate the ignored incompliant resources.
        /// </summary>
        [NameInMap("IgnoreDate")]
        [Validation(Required=false)]
        public string IgnoreDate { get; set; }

        /// <summary>
        /// The reason why you ignore the resource.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The resources to be ignored.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<IgnoreAggregateEvaluationResultsRequestResources> Resources { get; set; }
        public class IgnoreAggregateEvaluationResultsRequestResources : TeaModel {
            /// <summary>
            /// The ID of the region in which the resource resides.
            /// 
            /// For more information about how to obtain the ID of a region, see [ListAggregateDiscoveredResources](https://help.aliyun.com/document_detail/265983.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resources belong.
            /// 
            /// >  You must specify the ID of the current management account or a member account in the account group of the management account.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceAccountId")]
            [Validation(Required=false)]
            public long? ResourceAccountId { get; set; }

            /// <summary>
            /// The ID of the resource.
            /// 
            /// For more information about how to query the ID of a resource, see [ListAggregateDiscoveredResources](https://help.aliyun.com/document_detail/265983.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource.
            /// 
            /// For more information about how to query the type of a resource, see [ListAggregateDiscoveredResources](https://help.aliyun.com/document_detail/265983.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
