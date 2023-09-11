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

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public string IsTruncated { get; set; }

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
