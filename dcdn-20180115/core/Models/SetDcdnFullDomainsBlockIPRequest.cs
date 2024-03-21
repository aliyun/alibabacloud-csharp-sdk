// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnFullDomainsBlockIPRequest : TeaModel {
        /// <summary>
        /// The duration for which IP addresses or CIDR blocks are blocked. Unit: seconds. The value **0** specifies that IP addresses or CIDR blocks are permanently blocked. This parameter is available only if you set **OperationType** to **block**.
        /// </summary>
        [NameInMap("BlockInterval")]
        [Validation(Required=false)]
        public int? BlockInterval { get; set; }

        /// <summary>
        /// The IP addresses that you want to block or unblock. Separate multiple IP addresses with commas (,). You can specify up to 1,000 IP addresses.
        /// </summary>
        [NameInMap("IPList")]
        [Validation(Required=false)]
        public string IPList { get; set; }

        /// <summary>
        /// The action that you want to perform. Valid values:
        /// 
        /// *   **block**
        /// *   **unblock**
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// The type of the blocking duration. This parameter is available only if you set **OperationType** to **block**. Valid values:
        /// 
        /// *   **cover**: the blocking duration that is specified in the request takes effect.
        /// *   **uncover**: the longer one of the blocking duration that is specified in the request and the remaining blocking duration takes effect.
        /// *   Default value: cover.
        /// </summary>
        [NameInMap("UpdateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

    }

}
