// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeActionEventPolicyResponseBody : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeActionEventPolicy**.
        /// </summary>
        [NameInMap("EnableEventLog")]
        [Validation(Required=false)]
        public string EnableEventLog { get; set; }

        /// <summary>
        /// Indicates whether the event history feature is enabled.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
