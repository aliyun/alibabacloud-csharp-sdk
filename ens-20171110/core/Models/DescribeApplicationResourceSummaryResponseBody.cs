// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeApplicationResourceSummaryResponseBody : TeaModel {
        /// <summary>
        /// The statistical information about the resource quota and usage in different regions.
        /// </summary>
        [NameInMap("ApplicationResource")]
        [Validation(Required=false)]
        public string ApplicationResource { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
