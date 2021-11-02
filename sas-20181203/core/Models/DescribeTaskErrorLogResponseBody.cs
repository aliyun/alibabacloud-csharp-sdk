// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTaskErrorLogResponseBody : TeaModel {
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<DescribeTaskErrorLogResponseBodyLogs> Logs { get; set; }
        public class DescribeTaskErrorLogResponseBodyLogs : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
