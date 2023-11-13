// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcBlacklistResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of the IP addresses in the blacklist of the instance.
        /// </summary>
        [NameInMap("AutoCcBlacklist")]
        [Validation(Required=false)]
        public List<DescribeAutoCcBlacklistResponseBodyAutoCcBlacklist> AutoCcBlacklist { get; set; }
        public class DescribeAutoCcBlacklistResponseBodyAutoCcBlacklist : TeaModel {
            /// <summary>
            /// The IP address of the instance.
            /// </summary>
            [NameInMap("DestIp")]
            [Validation(Required=false)]
            public string DestIp { get; set; }

            /// <summary>
            /// The validity period of the IP address in the blacklist. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The IP address in the blacklist.
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// The mode of how the IP address is added to the blacklist. Valid values:
            /// 
            /// *   **manual**: manually added
            /// *   **auto**: automatically added
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned IP addresses in the blacklist.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
