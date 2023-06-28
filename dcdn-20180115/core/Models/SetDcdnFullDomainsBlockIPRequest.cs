// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnFullDomainsBlockIPRequest : TeaModel {
        /// <summary>
        /// The blocking period. Unit: seconds.
        /// 
        /// > If you set the **OperationType** parameter to **unblock**, you do not need to set this parameter.
        /// </summary>
        [NameInMap("BlockInterval")]
        [Validation(Required=false)]
        public int? BlockInterval { get; set; }

        /// <summary>
        /// The IP addresses that are blocked or unblocked. Separate multiple IP addresses with commas (,). You can specify up to 1,000 IP addresses.
        /// </summary>
        [NameInMap("IPList")]
        [Validation(Required=false)]
        public string IPList { get; set; }

        /// <summary>
        /// The action. Valid values:
        /// 
        /// *   **block**
        /// *   **unblock**
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("UpdateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

    }

}
