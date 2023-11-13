// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebAccessModeResponseBody : TeaModel {
        /// <summary>
        /// An array consisting of the modes in which the website service is added.
        /// </summary>
        [NameInMap("DomainModes")]
        [Validation(Required=false)]
        public List<DescribeWebAccessModeResponseBodyDomainModes> DomainModes { get; set; }
        public class DescribeWebAccessModeResponseBodyDomainModes : TeaModel {
            /// <summary>
            /// The mode in which the website service is added. Valid values:
            /// 
            /// *   **0**: A record
            /// *   **1**: anti-DDoS mode
            /// *   **2**: origin redundancy mode
            /// </summary>
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public int? AccessMode { get; set; }

            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
