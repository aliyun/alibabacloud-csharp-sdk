// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class EnableControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// The status of the Control Policy feature. Valid values:
        /// 
        /// *   Enabled: The feature is enabled.
        /// *   PendingEnable: The feature is being enabled.
        /// *   Disabled: The feature is disabled.
        /// *   PendingDisable: The feature is being disabled.
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
