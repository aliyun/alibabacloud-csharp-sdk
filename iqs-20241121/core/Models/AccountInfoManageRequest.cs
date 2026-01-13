// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class AccountInfoManageRequest : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("quarkKey")]
        [Validation(Required=false)]
        public string QuarkKey { get; set; }

        [NameInMap("quarkName")]
        [Validation(Required=false)]
        public string QuarkName { get; set; }

        [NameInMap("testQps")]
        [Validation(Required=false)]
        public int? TestQps { get; set; }

        [NameInMap("testQueryPerDay")]
        [Validation(Required=false)]
        public int? TestQueryPerDay { get; set; }

    }

}
