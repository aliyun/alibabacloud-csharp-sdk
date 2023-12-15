// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeMyBlockchainsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeMyBlockchainsResponseBodyResult> Result { get; set; }
        public class DescribeMyBlockchainsResponseBodyResult : TeaModel {
            [NameInMap("Bizid")]
            [Validation(Required=false)]
            public string Bizid { get; set; }

            [NameInMap("Createtime")]
            [Validation(Required=false)]
            public long? Createtime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("RejectReason")]
            [Validation(Required=false)]
            public string RejectReason { get; set; }

            [NameInMap("ReqAddr")]
            [Validation(Required=false)]
            public string ReqAddr { get; set; }

            [NameInMap("SignedAddr")]
            [Validation(Required=false)]
            public string SignedAddr { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Updatetime")]
            [Validation(Required=false)]
            public long? Updatetime { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

    }

}
