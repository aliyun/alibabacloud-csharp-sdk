// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeInputFeildCountByEventCodeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeInputFeildCountByEventCodeResponseBodyResultObject ResultObject { get; set; }
        public class DescribeInputFeildCountByEventCodeResponseBodyResultObject : TeaModel {
            [NameInMap("limit")]
            [Validation(Required=false)]
            public bool? Limit { get; set; }

            [NameInMap("maxTotalItem")]
            [Validation(Required=false)]
            public int? MaxTotalItem { get; set; }

            [NameInMap("totalItem")]
            [Validation(Required=false)]
            public int? TotalItem { get; set; }

        }

    }

}
