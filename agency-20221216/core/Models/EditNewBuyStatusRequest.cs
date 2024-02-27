// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class EditNewBuyStatusRequest : TeaModel {
        /// <summary>
        /// New Purchase Status</br>
        /// 
        /// - cancelBan: Cancel the restriction for New Purchase request</br>
        /// 
        /// - ban: ban the New Purchase request</br>
        /// </summary>
        [NameInMap("NewBuyStatus")]
        [Validation(Required=false)]
        public string NewBuyStatus { get; set; }

        /// <summary>
        /// Customer UID
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
