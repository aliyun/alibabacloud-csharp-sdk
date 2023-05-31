// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockStatusResponseBody : TeaModel {
        /// <summary>
        /// The total quota that you purchase for web tamper proofing.
        /// </summary>
        [NameInMap("AuthCount")]
        [Validation(Required=false)]
        public int? AuthCount { get; set; }

        /// <summary>
        /// The used quota for web tamper proofing.
        /// </summary>
        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public int? BindCount { get; set; }

        /// <summary>
        /// The number of blocked processes.
        /// </summary>
        [NameInMap("BlockCount")]
        [Validation(Required=false)]
        public int? BlockCount { get; set; }

        /// <summary>
        /// The number of protected directories.
        /// </summary>
        [NameInMap("DirCount")]
        [Validation(Required=false)]
        public int? DirCount { get; set; }

        /// <summary>
        /// The timestamp when the quota for web tamper proofing expires.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of processes that are added to the process whitelist.
        /// </summary>
        [NameInMap("WhiteCount")]
        [Validation(Required=false)]
        public int? WhiteCount { get; set; }

    }

}
