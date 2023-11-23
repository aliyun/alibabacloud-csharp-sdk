// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetCredentialReportRequest : TeaModel {
        /// <summary>
        /// The number of entries per page. If a response is truncated because it reaches the value of `MaxItems`, the value of `IsTruncated` will be true.
        /// 
        /// Valid values: 1 to 3501. Default value: 3501.
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public string MaxItems { get; set; }

        /// <summary>
        /// The token that is used to initiate the next request if the response of the current request is truncated. You can use the token to initiate another request and obtain the remaining records.``
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
