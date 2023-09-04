// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetMFAAuthenticationStatusResponseBody : TeaModel {
        /// <summary>
        /// The status of MFA. Valid values:
        /// 
        /// *   Enabled
        /// *   Disabled
        /// </summary>
        [NameInMap("MFAAuthenticationStatus")]
        [Validation(Required=false)]
        public string MFAAuthenticationStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
