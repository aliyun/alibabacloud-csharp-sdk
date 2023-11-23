// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetCredentialReportResponseBody : TeaModel {
        /// <summary>
        /// The content of the user credential report.
        /// 
        /// The report is Base64-encoded. After you decode the report, the credential report is in the CSV format.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The time when the user credential report was generated.
        /// </summary>
        [NameInMap("GeneratedTime")]
        [Validation(Required=false)]
        public string GeneratedTime { get; set; }

        /// <summary>
        /// Indicates whether the response is truncated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public string IsTruncated { get; set; }

        /// <summary>
        /// The parameter that is used to obtain the truncated part. This parameter takes effect only when `IsTruncated` is set to true.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
