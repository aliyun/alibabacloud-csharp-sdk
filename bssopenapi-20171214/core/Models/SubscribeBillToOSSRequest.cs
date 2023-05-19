// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SubscribeBillToOSSRequest : TeaModel {
        [NameInMap("BeginBillingCycle")]
        [Validation(Required=false)]
        public string BeginBillingCycle { get; set; }

        [NameInMap("BucketOwnerId")]
        [Validation(Required=false)]
        public long? BucketOwnerId { get; set; }

        [NameInMap("BucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        [NameInMap("MultAccountRelSubscribe")]
        [Validation(Required=false)]
        public string MultAccountRelSubscribe { get; set; }

        [NameInMap("RowLimitPerFile")]
        [Validation(Required=false)]
        public int? RowLimitPerFile { get; set; }

        [NameInMap("SubscribeBucket")]
        [Validation(Required=false)]
        public string SubscribeBucket { get; set; }

        [NameInMap("SubscribeType")]
        [Validation(Required=false)]
        public string SubscribeType { get; set; }

    }

}
