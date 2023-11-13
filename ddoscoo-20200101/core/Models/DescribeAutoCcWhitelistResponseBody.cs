// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcWhitelistResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of details of the IP address in the whitelist of the instance.
        /// </summary>
        [NameInMap("AutoCcWhitelist")]
        [Validation(Required=false)]
        public List<DescribeAutoCcWhitelistResponseBodyAutoCcWhitelist> AutoCcWhitelist { get; set; }
        public class DescribeAutoCcWhitelistResponseBodyAutoCcWhitelist : TeaModel {
            /// <summary>
            /// The IP address of the instance.
            /// </summary>
            [NameInMap("DestIp")]
            [Validation(Required=false)]
            public string DestIp { get; set; }

            /// <summary>
            /// The validity period of the IP address in the whitelist. Unit: seconds. **0** indicates that the IP address in the whitelist never expires.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The IP addresses that is contained in the IP address whitelist.
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// The mode of how an IP address is added to the whitelist. Valid values:
            /// 
            /// *   **manual**: manually added
            /// *   **auto**: automatically added
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned IP addresses in the whitelist.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
