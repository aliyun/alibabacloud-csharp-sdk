// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CopyConfigRulesRequest : TeaModel {
        /// <summary>
        /// The IDs of the destination account groups into which the rules are replicated. Separate multiple account group IDs with commas (,).
        /// 
        /// > If you leave this parameter empty, the compliance packages are replicated into the same account group.
        /// </summary>
        [NameInMap("DesAggregatorIds")]
        [Validation(Required=false)]
        public string DesAggregatorIds { get; set; }

        /// <summary>
        /// The ID of the account group to which the rules belong.
        /// 
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// </summary>
        [NameInMap("SrcAggregatorId")]
        [Validation(Required=false)]
        public string SrcAggregatorId { get; set; }

        /// <summary>
        /// The rule IDs. Separate multiple rule IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SrcConfigRuleIds")]
        [Validation(Required=false)]
        public string SrcConfigRuleIds { get; set; }

    }

}
