// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAnalyticdbByPrimaryDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// The number of associated analytic instances.
        /// </summary>
        [NameInMap("AnalyticDBCount")]
        [Validation(Required=false)]
        public int? AnalyticDBCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
