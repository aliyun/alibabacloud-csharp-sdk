// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockInclusiveFileTypeResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the types of files that can be protected by web tamper proofing.
        /// </summary>
        [NameInMap("InclusiveFileType")]
        [Validation(Required=false)]
        public List<string> InclusiveFileType { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the types of files that can be protected by web tamper proofing.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
