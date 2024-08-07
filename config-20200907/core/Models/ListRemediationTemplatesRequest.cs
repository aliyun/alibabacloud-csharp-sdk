// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListRemediationTemplatesRequest : TeaModel {
        /// <summary>
        /// The identifier of the managed rule.
        /// 
        /// You can call the [ListCompliancePackTemplates](https://help.aliyun.com/document_detail/261176.html) operation to obtain the managed rule identifier.
        /// </summary>
        [NameInMap("ManagedRuleIdentifier")]
        [Validation(Required=false)]
        public string ManagedRuleIdentifier { get; set; }

        /// <summary>
        /// The page number. Pages start from 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The type of the remediation template. Valid value: OOS, which stands for Operation Orchestration Service.
        /// </summary>
        [NameInMap("RemediationType")]
        [Validation(Required=false)]
        public string RemediationType { get; set; }

    }

}
