// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class SetCreditLineRequest : TeaModel {
        /// <summary>
        /// New Credit Line
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CreditLine")]
        [Validation(Required=false)]
        public string CreditLine { get; set; }

        /// <summary>
        /// The UID of Sub Account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
