// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigRuleEvaluationResultsRequest : TeaModel {
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
        /// The ID of the compliance package.
        /// 
        /// For more information about how to obtain the ID of a compliance package, see [ListAggregateCompliancePacks](https://help.aliyun.com/document_detail/262059.html).
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// The compliance evaluation result of the resource. Valid values:
        /// 
        /// *   COMPLIANT: The resource is evaluated as compliant.
        /// *   NON_COMPLIANT: The resource is evaluated as non-compliant.
        /// *   NOT_APPLICABLE: The rule does not apply to your resource.
        /// *   INSUFFICIENT_DATA: No data is available.
        /// *   IGNORED: The resource is ignored during compliance evaluation.
        /// </summary>
        [NameInMap("ComplianceType")]
        [Validation(Required=false)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// The rule ID.
        /// 
        /// For more information about how to query the ID of a rule, see [ListAggregateConfigRules](https://help.aliyun.com/document_detail/264148.html).
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The maximum number of entries to return in a request. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of `NextToken`.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region whose resources you want to evaluate. Separate multiple region IDs with commas (,).
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        /// <summary>
        /// Member accountId to which the resource to be queried belongs.
        /// </summary>
        [NameInMap("ResourceAccountId")]
        [Validation(Required=false)]
        public long? ResourceAccountId { get; set; }

        /// <summary>
        /// The ID of the resource group whose resources you want to evaluate. Separate multiple resource group IDs with commas (,).
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the resources that you want to evaluate. Separate multiple resource types with commas (,).
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

    }

}
