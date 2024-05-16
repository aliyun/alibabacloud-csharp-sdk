// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class VerifyDomainOwnerRequest : TeaModel {
        /// <summary>
        /// The domain name of which you want to verify the ownership. You can specify only one domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The verification method. Valid values:
        /// 
        /// *   **dnsCheck**: by DNS record
        /// *   **fileCheck**: by verification file
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VerifyType")]
        [Validation(Required=false)]
        public string VerifyType { get; set; }

    }

}
