// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListAuthorizeResponseBody : TeaModel {
        /// <summary>
        /// The available quota.
        /// </summary>
        [NameInMap("AvailableAuthorizeNum")]
        [Validation(Required=false)]
        public int? AvailableAuthorizeNum { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
