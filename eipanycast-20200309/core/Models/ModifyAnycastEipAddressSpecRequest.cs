// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class ModifyAnycastEipAddressSpecRequest : TeaModel {
        /// <summary>
        /// The ID of the Anycast EIP.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// The maximum bandwidth of the Anycast EIP. Unit: Mbit/s.
        /// 
        /// Valid values: **200** to **1000**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

    }

}
