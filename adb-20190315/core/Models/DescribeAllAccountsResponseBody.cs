// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAllAccountsResponseBody : TeaModel {
        /// <summary>
        /// The list of accounts.
        /// </summary>
        [NameInMap("AccountList")]
        [Validation(Required=false)]
        public List<DescribeAllAccountsResponseBodyAccountList> AccountList { get; set; }
        public class DescribeAllAccountsResponseBodyAccountList : TeaModel {
            /// <summary>
            /// The name of the account.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
