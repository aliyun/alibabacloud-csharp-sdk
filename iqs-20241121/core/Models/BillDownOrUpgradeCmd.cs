// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class BillDownOrUpgradeCmd : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("activeDate")]
        [Validation(Required=false)]
        public string ActiveDate { get; set; }

        [NameInMap("codeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        [NameInMap("operateTypEnum")]
        [Validation(Required=false)]
        public string OperateTypEnum { get; set; }

        [NameInMap("qps")]
        [Validation(Required=false)]
        public int? Qps { get; set; }

    }

}
