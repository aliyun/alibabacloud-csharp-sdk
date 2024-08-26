// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForGenerateDomainCertificateRequest : TeaModel {
        /// <summary>
        /// The domain names.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public List<string> DomainNames { get; set; }

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
        /// The IP address of the client.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
