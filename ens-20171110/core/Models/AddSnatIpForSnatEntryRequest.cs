// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddSnatIpForSnatEntryRequest : TeaModel {
        /// <summary>
        /// The ID of the SNAT entry.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

        /// <summary>
        /// The EIP specified in the SNAT entry.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

    }

}
