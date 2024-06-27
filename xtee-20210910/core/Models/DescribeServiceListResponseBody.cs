// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeServiceListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeServiceListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeServiceListResponseBodyResultObject : TeaModel {
            [NameInMap("serviceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

    }

}
