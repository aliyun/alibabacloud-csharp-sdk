// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeApiNameListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeApiNameListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeApiNameListResponseBodyResultObject : TeaModel {
            [NameInMap("apiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

        }

    }

}
