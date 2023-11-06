// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateResourceEvaluationResultsRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The compliance evaluation result of the resource. Valid values:
        /// 
        /// *   COMPLIANT: The resource is evaluated as compliant.
        /// *   NON_COMPLIANT: The resource is evaluated as non-compliant.
        /// *   NOT_APPLICABLE: The rule does not apply to the resource.
        /// *   INSUFFICIENT_DATA: No data is available.
        /// *   IGNORED: The resource is ignored during compliance evaluation.
        /// </summary>
        [NameInMap("ComplianceType")]
        [Validation(Required=false)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// The maximum number of entries to return for a single request. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that you want to use to initiate the current request. If the response of the previous request is truncated, you can use this token to initiate another request and obtain the remaining entries.``
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region where one or more resources that you want to query reside. For example, the value `global` indicates global regions and the value `cn-hangzhou` indicates the China (Hangzhou) region.
        /// 
        /// For more information about how to obtain the ID of a region, see [ListAggregateDiscoveredResources](~~265983~~).
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

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
        /// For more information about how to query the type of a resource, see [ListAggregateDiscoveredResources](~~265983~~).
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
