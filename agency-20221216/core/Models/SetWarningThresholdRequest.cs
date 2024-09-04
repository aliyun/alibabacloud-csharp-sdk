// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class SetWarningThresholdRequest : TeaModel {
        /// <summary>
        /// The UID of the partner‘s customer.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

        /// <summary>
        /// Percentage, 1 to 100. When the available credit limit is lower than the credit limit percentage, an email is sent to the main account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WarningValue")]
        [Validation(Required=false)]
        public string WarningValue { get; set; }

    }

}
