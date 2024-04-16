// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CheckVpnBgpEnabledResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the region supports BGP.
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("BgpEnabled")]
        [Validation(Required=false)]
        public bool? BgpEnabled { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
