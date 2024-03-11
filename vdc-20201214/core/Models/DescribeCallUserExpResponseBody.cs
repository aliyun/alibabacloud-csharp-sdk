// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeCallUserExpResponseBody : TeaModel {
        [NameInMap("ExpInfoList")]
        [Validation(Required=false)]
        public List<DescribeCallUserExpResponseBodyExpInfoList> ExpInfoList { get; set; }
        public class DescribeCallUserExpResponseBodyExpInfoList : TeaModel {
            [NameInMap("CallExp")]
            [Validation(Required=false)]
            public string CallExp { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
