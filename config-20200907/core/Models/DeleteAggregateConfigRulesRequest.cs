// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregateConfigRulesRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of the account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The rule ID. Separate multiple rule IDs with commas (,).
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListAggregateConfigRules](https://help.aliyun.com/document_detail/264148.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

    }

}
