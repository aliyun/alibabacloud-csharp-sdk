// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyEnsEipAddressAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the EIP.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// The peak bandwidth of the EIP. Default value: 5. Valid values: **5** to **10000**. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The new description of the EIP. The description must be 2 to 256 characters in length and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The new name of the EIP. The name must be 2 to 128 characters in length and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
