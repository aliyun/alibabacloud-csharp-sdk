// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyActionEventPolicyResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the event history feature is enabled.
        /// </summary>
        [NameInMap("EnableEventLog")]
        [Validation(Required=false)]
        public string EnableEventLog { get; set; }

        /// <summary>
        /// The ID of the region for which the event history feature is enabled or disabled.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
