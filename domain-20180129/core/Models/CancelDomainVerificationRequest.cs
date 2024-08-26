// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CancelDomainVerificationRequest : TeaModel {
        /// <summary>
        /// The action type. Valid values:
        /// 
        /// *   **DOMAINAUDIT**: review a domain name review.
        /// *   **AUDITCONTACT**: review a contact.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// Thee instance ID of the domain name. You can call the [QueryDomainList](https://help.aliyun.com/document_detail/67712.html) operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The language of the error message to return if the request fails. Valid values:
        /// 
        /// *   **zh**: Chinese.
        /// *   **en**: English.
        /// 
        /// Default value: **en**.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The IP address of the client. Set the value to **127.0.0.1**.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
