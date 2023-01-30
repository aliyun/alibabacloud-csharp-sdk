// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ReactivateDomainResponseBody : TeaModel {
        /// <summary>
        /// *   This operation is intended for API providers.
        /// *   You must solve the problem that is mentioned in the domain name exception prompt before you can reactivate the domain name.
        /// *   A typical reason why a custom domain name becomes abnormal is that the domain name does not have an ICP filing or the domain name is included in a blacklist by the administration. When a custom domain name is abnormal, users cannot use it to access APIs.
        /// *   You can call this operation to reactivate the domain name to resume normal access.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
