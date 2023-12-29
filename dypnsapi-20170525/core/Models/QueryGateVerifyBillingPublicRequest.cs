// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyBillingPublicRequest : TeaModel {
        /// <summary>
        /// The verification method. Valid values:
        /// 
        /// *   **0**: phone number verification
        /// *   **1**: one-click logon
        /// *   **2**: all
        /// *   **3**: facial recognition
        /// *   **4**: SMS verification
        /// </summary>
        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public int? AuthenticationType { get; set; }

        /// <summary>
        /// The month in which the bill is generated. Specify this parameter in the YYYYMM format. Example: 202111.
        /// </summary>
        [NameInMap("Month")]
        [Validation(Required=false)]
        public string Month { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
