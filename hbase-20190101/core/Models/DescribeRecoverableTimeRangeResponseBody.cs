// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRecoverableTimeRangeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeBegin")]
        [Validation(Required=false)]
        public string TimeBegin { get; set; }

        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

    }

}
