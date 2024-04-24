// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAccountDelegatedStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The name of the Alibaba Cloud account. This parameter is returned only if the account is the delegated administrator account.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Indicates whether the Alibaba Cloud account is the delegated administrator account of the WAF instance.
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("DelegatedStatus")]
        [Validation(Required=false)]
        public bool? DelegatedStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
