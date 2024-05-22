// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnAssociateEnsEipAddressRequest : TeaModel {
        /// <summary>
        /// The ID of the EIP.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

    }

}
