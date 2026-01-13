// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class ListSubAccountInfoResult : TeaModel {
        [NameInMap("subAccountInfos")]
        [Validation(Required=false)]
        public List<ListSubAccountInfoResultSubAccountInfos> SubAccountInfos { get; set; }
        public class ListSubAccountInfoResultSubAccountInfos : TeaModel {
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

        }

    }

}
