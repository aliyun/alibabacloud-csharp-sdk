// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUsageNewestResponseBody : TeaModel {
        /// <summary>
        /// The number of accounts.
        /// </summary>
        [NameInMap("ItemCount")]
        [Validation(Required=false)]
        public int? ItemCount { get; set; }

        /// <summary>
        /// An array that consists of the accounts.
        /// </summary>
        [NameInMap("NewestStatisticItems")]
        [Validation(Required=false)]
        public List<DescribePropertyUsageNewestResponseBodyNewestStatisticItems> NewestStatisticItems { get; set; }
        public class DescribePropertyUsageNewestResponseBodyNewestStatisticItems : TeaModel {
            /// <summary>
            /// The time when the account was created.
            /// </summary>
            [NameInMap("Create")]
            [Validation(Required=false)]
            public long? Create { get; set; }

            /// <summary>
            /// The username of the account.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the accounts that are created on the server. The value is fixed as user, which indicates user accounts.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
