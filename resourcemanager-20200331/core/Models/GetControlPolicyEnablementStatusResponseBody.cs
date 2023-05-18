// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetControlPolicyEnablementStatusResponseBody : TeaModel {
        /// <summary>
        /// The status of the Control Policy feature. Valid values:
        /// 
        /// *   Enabled: The Control Policy feature is enabled.
        /// *   PendingEnable: The Control Policy feature is being enabled.
        /// *   Disabled: The Control Policy feature is disabled.
        /// *   PendingDisable: The Control Policy feature is being disabled.
        /// </summary>
        [NameInMap("EnablementStatus")]
        [Validation(Required=false)]
        public string EnablementStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
