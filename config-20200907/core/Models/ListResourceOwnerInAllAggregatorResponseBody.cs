// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListResourceOwnerInAllAggregatorResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AccountInAggregator")]
        [Validation(Required=false)]
        public List<ListResourceOwnerInAllAggregatorResponseBodyAccountInAggregator> AccountInAggregator { get; set; }
        public class ListResourceOwnerInAllAggregatorResponseBodyAccountInAggregator : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

        }

    }

}
