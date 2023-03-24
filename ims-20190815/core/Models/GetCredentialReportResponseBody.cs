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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
