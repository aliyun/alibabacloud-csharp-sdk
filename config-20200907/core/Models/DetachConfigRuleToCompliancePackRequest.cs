// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DetachConfigRuleToCompliancePackRequest : TeaModel {
        /// <summary>
        /// The ID of the compliance package.
        /// 
        /// For more information about how to obtain the ID of a compliance package, see [ListCompliancePacks](https://help.aliyun.com/document_detail/263332.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// The rule ID. Separate multiple rule IDs with commas (,).
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListConfigRules](https://help.aliyun.com/document_detail/169607.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

    }

}
