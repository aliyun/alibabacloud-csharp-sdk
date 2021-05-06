// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAllAccountsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AccountList")]
        [Validation(Required=false)]
        public List<DescribeAllAccountsResponseBodyAccountList> AccountList { get; set; }
        public class DescribeAllAccountsResponseBodyAccountList : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
