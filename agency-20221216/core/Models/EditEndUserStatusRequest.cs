// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class EditEndUserStatusRequest : TeaModel {
        /// <summary>
        /// Shutdown Status</br>
        /// 
        /// - postPayFreeze, the account have been blocked</br>
        /// 
        /// - postPayThaw, the account have been unlocked</br>
        /// </summary>
        [NameInMap("CreditStatus")]
        [Validation(Required=false)]
        public string CreditStatus { get; set; }

        /// <summary>
        /// UID
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
