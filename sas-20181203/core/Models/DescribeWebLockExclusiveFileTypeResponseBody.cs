// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockExclusiveFileTypeResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the types of the files that have web tamper proofing disabled.
        /// </summary>
        [NameInMap("ExclusiveFileType")]
        [Validation(Required=false)]
        public List<string> ExclusiveFileType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of types of the files that have web tamper proofing disabled.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
