// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeSecurityAgentStatusResponseBody : TeaModel {
        /// <summary>
        /// The status of the Security Center agent. Valid values:
        /// 
        /// *   pause: The Security Center agent suspends protection for your server.
        /// *   online: The Security Center agent is protecting your server.
        /// *   offline: The Security Center agent does not protect your server.
        /// </summary>
        [NameInMap("ClientStatus")]
        [Validation(Required=false)]
        public string ClientStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
